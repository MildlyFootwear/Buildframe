using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.GameData
{
    public class Weapon
    {

        public List<Stats> fireModes = new List<Stats>();
        public Dictionary<string, Stats> fireModesRadials = new();

        public string id = "";
        public string name = "";
        public string tags = "";
        public string description = "";

    }
}
