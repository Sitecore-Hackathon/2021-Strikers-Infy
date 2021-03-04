using Sitecore.Data;
using Sitecore.Mvc.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Sitecore.Data.Items;

namespace StrikersInfy.Foundation.Entensions.Helpers
{
    public static class SitecoreHelperExtensions
    {
        public static HtmlString Field(this SitecoreHelper helper, ID fieldId)
        {
            return helper.Field(fieldId.ToString());
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldId, object parameters)
        {
            return helper.Field(fieldId.ToString(), parameters);
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldId, Item item, object parameters)
        {
            return helper.Field(fieldId.ToString(), item, parameters);
        }
    }
}
