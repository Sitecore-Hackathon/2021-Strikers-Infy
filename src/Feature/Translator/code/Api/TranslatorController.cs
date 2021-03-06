using StrikersInfy.Feature.Translator.Biz;
using StrikersInfy.Feature.Translator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StrikersInfy.Feature.Translator.Api
{
    public class TranslatorController : ApiController
    {
        [HttpPost]
        public async Task<string> TranslateContentAsync(ContentProps data)
        {
            string resp = await TranslateMgmt.TranslateContent(data);
            return resp;
        }
    }
}