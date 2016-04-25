using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    public class Coordinate
    {
        public readonly int row;
        public readonly int col;
        
        public Color originalColor;
        Color shownColor;

        public Color ShownColor
        {
            get { return shownColor; }
            set
            {
                shownColor = value;
                Paint(this);
            }
        }

        public bool isFruitOccupied = false;

        Action<Coordinate> Paint;

        public Coordinate(int row, int col, Color originalColor, Color shownColor, Action<Coordinate> Paint)
        {
            this.row = row;
            this.col = col;
            this.originalColor = originalColor;
            this.shownColor = shownColor;
            this.Paint = Paint;
        }

        public void ResetCoordinate()
        {
            isFruitOccupied = false;
            ShownColor = originalColor;
        }

        public bool IsBreakableBarrier()
        {
            return originalColor == Color.Grey;
        }

        public bool IsPool()
        {
            return originalColor == Color.LightBlue;
        }

        public bool IsFence()
        {
            return originalColor == Color.Brown;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Coordinate c = (Coordinate)obj;
            return (row == c.row) && (col == c.col);
        }

        public override int GetHashCode()
        {
            return ShiftAndWrap(row.GetHashCode(), 2) ^ col.GetHashCode();
        }

        int ShiftAndWrap(int value, int positions)
        {
            positions = positions & 0x1F;

            // Save the existing bit pattern, but interpret it as an unsigned integer. 
            uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
            // Preserve the bits to be discarded. 
            uint wrapped = number >> (32 - positions);
            // Shift and wrap the discarded bits. 
            return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
        }

        public override string ToString()
        {
            return "Row: " + this.row + ", Column: " + this.col + "\n";
        }
    }

    public enum Color
    {
        Green, Brown, Black, Red, Yellow, Blue, Orange, LightBlue, Grey
    };

    public static class ColorExtension {
        // Fruit can be on lawn or in pool
        public static bool FitForFruit(this Color color)
        {
            return color == Color.Green || color == Color.LightBlue;
        }

        public static bool isFruitColor(this Color color)
        {
            return color != Color.Green && color != Color.Brown && color != Color.Black && color != Color.LightBlue && color != Color.Grey;
        }
    }
}
