using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    public class GrandCanyonMapRecords : RecordGroup
    {
        public GrandCanyonMapRecords()
        {
            mapName = "Grand Canyon Game Record";
            records = new SortedSet<GameRecord>(ReadRecordsFromFile("GrandCanyon"), Comparer<GameRecord>.Create((a, b) => a.CompareTo(b)));
        }
    }
}
