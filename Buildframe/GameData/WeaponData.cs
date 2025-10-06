using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.GameData
{
    public class WeaponData
    {

        public List<StatsData> fireModes = new List<StatsData>();
        public Dictionary<string, StatsData> fireModesRadials = new();

        public string id = "";
        public string name = "";
        public string tags = "";
        public string description = "";

        override public string ToString()
        {
            return name;
        }
    }
}
