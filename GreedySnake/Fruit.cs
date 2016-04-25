using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace GreedySnake
{
    class Fruit
    {
        Coordinate fruitCoordinate;
        FruitType fruitType;

        Timer prepareFlashingTimer;
        Timer flashingTimer;
        Timer disappearTimer;

        int colorIndex = 0;

        public Coordinate FruitCoordinate
        {
            get
            {
                return fruitCoordinate;
            }
        }

        public FruitType FruitType
        {
            get
            {
                return fruitType;
            }
        }

        public Fruit(Coordinate fruitCoordinate) 
        {
            this.fruitCoordinate = fruitCoordinate;
            fruitCoordinate.ShownColor = GameUtility.GetRandomColor();
            fruitCoordinate.isFruitOccupied = true;

            this.fruitType = (FruitType)fruitCoordinate.ShownColor;

            SetPrepareFlashingTimer();
            SetDisappearTimer();
        }

        void SetPrepareFlashingTimer()
        {
            prepareFlashingTimer = new Timer();
            prepareFlashingTimer.Interval = 10000;
            prepareFlashingTimer.Elapsed += PrepareFlashing;
            prepareFlashingTimer.Start();
        }

        void PrepareFlashing(Object sender, System.Timers.ElapsedEventArgs args)
        {
            List<Color> flashingColors = DetermineFlashingColors();

            flashingTimer = new Timer();
            flashingTimer.Interval = 500;
            flashingTimer.Elapsed += (fromSender, arguments) => Flashing(flashingColors);
            flashingTimer.Start();
        }

        List<Color> DetermineFlashingColors()
        {
            List<Color> flashingColors = new List<Color>(new Color[] { fruitCoordinate.originalColor, fruitCoordinate.ShownColor });

            return flashingColors;
        }

        void Flashing(List<Color> flashingColors)
        {
            fruitCoordinate.ShownColor = flashingColors[colorIndex];
            colorIndex ^= 1;
        }

        void SetDisappearTimer()
        {
            disappearTimer = new Timer();
            disappearTimer.Interval = 15000;
            disappearTimer.Elapsed += Disappear;
            disappearTimer.Start();
        }

        void Disappear(object sender, System.Timers.ElapsedEventArgs e)
        {
            fruitCoordinate.ShownColor = fruitCoordinate.originalColor;
            fruitCoordinate.isFruitOccupied = false;

            OnFruitDisappeared(GetFruitDisappearEventArgs());

            StopRunningTimers();
        }

        void OnFruitDisappeared(FruitDisappearEventArgs args)
        {
            EventHandler<FruitDisappearEventArgs> handler = FruitDisappearHandler;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        FruitDisappearEventArgs GetFruitDisappearEventArgs()
        {
            FruitDisappearEventArgs args = new FruitDisappearEventArgs();
            args.fruitCoordinateArg = FruitCoordinate;

            return args;
        }

        public void StopRunningTimers()
        {
            prepareFlashingTimer.Stop();
            disappearTimer.Stop();

            if (flashingTimer != null)
            {
                flashingTimer.Stop();
            }
        }

        public event EventHandler<FruitDisappearEventArgs> FruitDisappearHandler;
    }

    public class FruitDisappearEventArgs : EventArgs
    {
        public Coordinate fruitCoordinateArg
        {
            get;
            set;
        }
    }

    public enum FruitType
    {
        Strawberry = 3, Banana = 4, Blueberry = 5, Orange = 6
    }

    public static class FruitTypeExtension
    {
        // TODO: Adjust to make orange is the most likely fruit to appear on map
        // TODO: Adjust to implement a second fruit appears immediately when the first fruit is eaten
        public static bool shouldSnakeGrow(this FruitType fruitType)
        {
            return fruitType == FruitType.Orange;
        }
    }
}
