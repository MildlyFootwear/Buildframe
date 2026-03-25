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
