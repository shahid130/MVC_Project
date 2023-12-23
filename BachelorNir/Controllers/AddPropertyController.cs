using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BachelorNir.Controllers
{
    public class AddPropertyController : Controller
    {
        // GET: AddProperty
        public ActionResult AddProperty()
        {
            return View();
        }

        public ActionResult Submit()
        {
            return View();
        }
    }
}