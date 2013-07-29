using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatterBot.Controllers
{
    public class OAuthController : Controller
    {
        public ActionResult Index()
        {
            return Content("");
        }
        
        public ActionResult Callback()
        {
            return Content("");
        }
    }
}
