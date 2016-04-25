using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class GameUtility
    {
        static Random random = new Random();

        public static int GetRandomNumber(int lowerLimit, int upperLimit)
        {
            return random.Next(lowerLimit, upperLimit);
        }

        /// <summary>
        /// Generate colors with different probabilities
        /// </summary>
        /// <returns>orange: 70%, banana: 10%, strawberry: 10%, blueberry: 10%</returns>
        public static Color GetRandomColor()
        {
            int temp = GetRandomNumber(0, 10);
            if (temp < 7)
            {
                return Color.Orange;
            }
            else
            {
                return (Color)GetRandomNumber(3, 6);
            }
        }
    }
}
