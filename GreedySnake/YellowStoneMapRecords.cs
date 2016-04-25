using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    public class YellowStoneMapRecords : RecordGroup
    {
        public YellowStoneMapRecords() {
            mapName = "Yellow Stone Map Records";
            records = new SortedSet<GameRecord>(ReadRecordsFromFile("YellowStone"), Comparer<GameRecord>.Create((a, b) => a.CompareTo(b)));
        }
    }
}
