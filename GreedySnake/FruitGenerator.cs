using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GreedySnake
{
    class FruitGenerator
    {
        const int FRUIT_GENERATION_COUNT_PER_TIME = 1;

        Coordinate[,] map;

        bool _shouldStop = false;

        public Dictionary<Coordinate, Fruit> coordinate_fruit_mapping = new Dictionary<Coordinate, Fruit>();

        AutoResetEvent fruitWaitEvent = new AutoResetEvent(false);

        public FruitGenerator(Coordinate[,] map)
        {
            coordinate_fruit_mapping.Clear();
            fruitWaitEvent = new AutoResetEvent(false);
            _shouldStop = false;

            this.map = map;
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

        public void Generate()
        {
            while (!_shouldStop)
            {
                for (int count = 0; count < FRUIT_GENERATION_COUNT_PER_TIME - coordinate_fruit_mapping.Count(); count++)
                {
                    Fruit fruit = new Fruit(DetermineFruitCoordinate());
                    fruit.FruitDisappearHandler += GenerateNewFruit;

                    AddToMapping(fruit.FruitCoordinate, fruit);
                }

                fruitWaitEvent.WaitOne();
            }
        }

        /// <summary>
        /// Generate a new fruit on map everytime a fruit disappears
        /// </summary>
        public void GenerateNewFruit(object sender, FruitDisappearEventArgs args)
        {
            RemoveMapping(args.fruitCoordinateArg); // Remove old fruit from coordinate-fruit mapping
            fruitWaitEvent.Set();
        }

        Coordinate DetermineFruitCoordinate()
        {
            Coordinate fruitCoordinate;

            do
            {
                fruitCoordinate = 
                    map[GameUtility.GetRandomNumber(0, map.GetLength(0)), GameUtility.GetRandomNumber(0, map.GetLength(1))];
            } while (!fruitCoordinate.ShownColor.FitForFruit());

            return fruitCoordinate;
        }

        public Fruit GetFruitFromCoordinate(Coordinate coordinate)
        {
            if (!coordinate_fruit_mapping.ContainsKey(coordinate))
            {
                throw new Exception("No fruit found for coordinate (" + coordinate.row + ", " + coordinate.col + ")");
            }

            return coordinate_fruit_mapping[coordinate];
        }

        void AddToMapping(Coordinate coordinate, Fruit fruit)
        {
            coordinate_fruit_mapping.Add(coordinate, fruit);
        }

        public void RemoveMapping(Coordinate coordinate)
        {
            coordinate_fruit_mapping.Remove(coordinate);
        }
    }
}