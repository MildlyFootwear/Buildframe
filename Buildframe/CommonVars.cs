using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe
{
    public class CommonVars
    {
        public static string ToolName = Settings.Default.ToolName;
        public static string LatestVer = null;
        public static List<string> ProhibPathChars = ["|", "<", ">", "?", "*", "/", "\\",":", "="];

        public static bool ToolDebug = false;
        public static bool DebuggingWeaponCalc = false;
        public static bool DebuggingLoading = false;
        public static bool DebuggingMainWindow = false;
        public static bool DebuggingStatWindow = false;

        public static string envUSERPROFILE = Environment.GetEnvironmentVariable("USERPROFILE");
        public static string envAPPLOC = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static Dictionary<string, GameData.WeaponData> weaponStats = new();
        public static Dictionary<string, GameData.StatsData> fireModeStats = new();
        public static Dictionary<string, GameData.StatsData> modStats = new();
        public static Dictionary<string, GameData.StatsData> arcaneStats = new();
        public static Dictionary<string, GameData.StatsData> miscStats = new();
    }
}
