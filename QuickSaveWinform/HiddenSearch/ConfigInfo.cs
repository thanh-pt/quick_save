namespace HiddenSearch
{
    public class ConfigInfo
    {
        public string DataFileName { get; set; }
        public double ActiveOpacity { get; set; }
        public double DeactiveOpacity { get; set; }

        public ConfigInfo()
        {
            DataFileName = "quiz.xlsx";
            ActiveOpacity = 0.2;
            DeactiveOpacity = 0.05;
        }
    }
}
