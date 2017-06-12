using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Utilities.Controllers
{
    public class TriangleTypeController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Mvc.ActionName("GetTriangleType")]
        public string GetTriangleType(Triangle param)
        {
            double a = param.SideA;
            double b = param.SideB;
            double c = param.SideC;
            return Helper.GetTriangleType(a, b, c);
        }
    }
}
