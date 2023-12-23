using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BachelorNir.Controllers
{
    public class CreateAccountController : Controller
    {
        // GET: CreateAccount
        public ActionResult Signup()
        {
            return View();
        }
    }
}