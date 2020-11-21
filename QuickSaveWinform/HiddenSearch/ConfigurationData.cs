namespace HiddenSearch
{
    public class ConfigurationData
    {
        public string DataFileName { get; set; }
        public double ActiveOpacity { get; set; }
        public double DeactiveOpacity { get; set; }

        public ConfigurationData()
        {
            DataFileName = "quiz.xlsx";
            ActiveOpacity = 0.2;
            DeactiveOpacity = 0.05;
        }
    }
}
