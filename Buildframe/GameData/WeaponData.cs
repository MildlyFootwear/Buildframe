using Buildframe.GameData;
using Buildframe.Methods.Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buildframe.GameData
{
    public class WeaponData
    {

        public List<StatsData> fireModes = new List<StatsData>();
        public Dictionary<string, StatsData> fireModesRadials = new();

        public string id = "";
        public string name = "[Weapon Name]";
        public string tags = "None";
        public string description = "";

        public string filePath = "";

        override public string ToString()
        {
            return name;
        }
    }
}
