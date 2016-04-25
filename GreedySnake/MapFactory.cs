using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class MapFactory
    {
        public static Map CreateMap(String mapName, Action<Coordinate> Paint)
        {
            if (mapName == "Yellow Stone")
            {
                return new YellowStoneMap(Paint);
            }
            else
            {
                return new GrandCanyonMap(Paint);
            }
        }
    }
}
