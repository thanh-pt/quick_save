using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenSearch
{
    class HandbookObject
    {
        public string Keyword { get; set; }
        public string StandFor { get; set; }
        public string Definition { get; set; }
        public string HowToUse { get; set; }
        public HandbookObject(string keyword = "", string standFor = "", string definition = "", string howToUse = "")
        {
            Keyword = keyword;
            StandFor = standFor;
            Definition = definition;
            HowToUse = howToUse;
        }
    }
}
