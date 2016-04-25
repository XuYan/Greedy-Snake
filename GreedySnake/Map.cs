using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    abstract class Map
    {
        public const int COL_COUNT = 54;
        public const int ROW_COUNT = 29;

        protected char[,] layout;

        protected Action<Coordinate> Paint;

        public Coordinate[,] Create()
        {
            if (layout == null)
            {
                throw new Exception("Map is not created yet...");
            }

            Coordinate[,] coordinates = new Coordinate[ROW_COUNT, COL_COUNT];
            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT; col++)
                {
                    Color color = InterpretCharToColor(layout[row, col]);
                    coordinates[row, col] = new Coordinate(row, col, color, color, Paint);
                }
            }

            return coordinates;
        }

        Color InterpretCharToColor(char c)
        {
            if (c == '=')
            {
                return Color.Brown;
            }
            else if (c == '+')
            {
                return Color.Grey;
            }
            else if (c == '.')
            {
                return Color.Green;
            }
            else if (c == '~')
            {
                return Color.LightBlue;
            }
            else
            {
                throw new Exception("Contains unknown character " + c + " in map...");
            }
        }
    }
}
