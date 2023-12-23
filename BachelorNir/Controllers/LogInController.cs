using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BachelorNir.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Signin()
        {
            return View();
        }
    }
}