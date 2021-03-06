using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrikersInfy.Feature.Translator.Models
{
    public class TranslationResponse
    {
        public TranslationRes[] Translation { get; set; }
    }

    public class TranslationRes
    {
        public Translation[] translations { get; set; }
    }

    public class Translation
    {
        public string text { get; set; }
        public string to { get; set; }
    }
}


