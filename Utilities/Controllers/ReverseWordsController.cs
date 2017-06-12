using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Utilities.Controllers
{
    public class ReverseWordsController : ApiController
    {
        [System.Web.Mvc.ActionName("GetReversedWords")]
        public string GetReversedWords(string param)
        {
            return Helper.ReverseWords(param);
        }
    }
}
