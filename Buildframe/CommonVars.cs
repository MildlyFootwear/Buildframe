using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe
{
    public class CommonVars
    {
        public static string ToolName = "Buildframe";
        public static string LatestVer = "";
        public static List<string> ProhibPathChars = ["|", "<", ">", "?", "*", "//", "\\\\"];

        public static bool ToolDebug = false;

        public static string envUSERPROFILE = Environment.GetEnvironmentVariable("USERPROFILE");
        public static string envAPPLOC = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static Dictionary<string, GameData.Weapon> weaponStats = new();
        public static Dictionary<string, GameData.Stats> fireModeStats = new Dictionary<string, GameData.Stats>();
        public static Dictionary<string, GameData.Stats> modStats = new Dictionary<string, GameData.Stats>();
        public static Dictionary<string, GameData.Stats> arcaneStats = new Dictionary<string, GameData.Stats>();
        public static Dictionary<string, GameData.Stats> miscStats = new Dictionary<string, GameData.Stats>();
    }
}
