using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Utilities.Controllers
{
    public class FibonacciController : ApiController
    {
        [System.Web.Mvc.ActionName("GetFibonacci")]
        public ulong GetFibonacci(int param)
        {
            return Helper.GetFibonacci(param);
        }
    }
}
