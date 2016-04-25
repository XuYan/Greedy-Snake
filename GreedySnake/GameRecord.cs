using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    public class GameRecord : IComparable<GameRecord>
    {
        public string Name
        {
            get;
            set;
        }

        public int SnakeLength
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public RecordGroup TargetGroup
        {
            get;
            set;
        }

        public GameRecord(string name, int length, DateTime date)
        {
            Name = name;
            SnakeLength = length;
            Date = date;
        }

        public int CompareTo(GameRecord record)
        {
            if (record == null)
            {
                return 1;
            }
            
            int result = Comparer<int>.Default.Compare(this.SnakeLength, record.SnakeLength);
            if (result == 0)
            {
                result = Comparer<DateTime>.Default.Compare(record.Date, this.Date);
            }

            return result;
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to GameRecord return false.
            GameRecord p = obj as GameRecord;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name == p.Name) && (SnakeLength == p.SnakeLength) && (Date == p.Date);
        }

        public bool Equals(GameRecord p)
        {
            // If parameter is null return false:
            if ((object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name == p.Name) && (SnakeLength == p.SnakeLength) && (Date == p.Date);
        }

        // It is recommended to override == operator for immutable class
        public static bool operator ==(GameRecord a, GameRecord b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return (a.Name == b.Name) && (a.SnakeLength == b.SnakeLength) && (a.Date == b.Date);
        }

        public static bool operator !=(GameRecord a, GameRecord b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + SnakeLength.GetHashCode();
            hash = (hash * 7) + Date.GetHashCode();

            return hash;
        }
    }
}