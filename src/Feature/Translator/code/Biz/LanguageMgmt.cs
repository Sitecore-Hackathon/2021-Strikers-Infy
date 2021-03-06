using Sitecore.Data.Managers;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using StrikersInfy.Feature.Translator.Models;

namespace StrikersInfy.Feature.Translator.Biz
{
    public class LanguageMgmt
    {
        public List<LangProps> GetLanguages()
        {
            var langVersions = new List<Language>();
            Sitecore.Data.Database master = Sitecore.Configuration.Factory.GetDatabase("master");
            string fastQuery = string.Format("fast:/sitecore/system/Languages//*[@@templateid = '{0}']", "{F68F13A6-3395-426A-B9A1-FA2DC60D94EB}");
            Item[] productItems = master.SelectItems(fastQuery);

            List<LangProps> langsList = new List<LangProps>();
            foreach (Item language in productItems)
            {
                bool isExist = language.Fields["{C437E416-8948-427D-A982-8ED37AE3F553}"].HasValue;
                if (isExist == true)
                {
                    string name = language.Name;
                    if (!name.Equals("en"))
                    {
                        string isoCode = language.Fields["{C437E416-8948-427D-A982-8ED37AE3F553}"].Value;
                        string dispname = language.DisplayName;

                        LangProps lang = new LangProps
                        {
                            LangName = dispname,
                            LangCode = isoCode
                        };
                        langsList.Add(lang);
                    }

                }
            }

            return langsList;
        }
    }
}