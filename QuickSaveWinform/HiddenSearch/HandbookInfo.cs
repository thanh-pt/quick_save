namespace HiddenSearch
{
    class HandbookInfo
    {
        public string Keyword { get; set; }
        public string StandFor { get; set; }
        public string Definition { get; set; }
        public string HowToUse { get; set; }
        public HandbookInfo(string keyword = "", string standFor = "", string definition = "", string howToUse = "")
        {
            Keyword = keyword;
            StandFor = standFor;
            Definition = definition;
            HowToUse = howToUse;
        }
    }
}
