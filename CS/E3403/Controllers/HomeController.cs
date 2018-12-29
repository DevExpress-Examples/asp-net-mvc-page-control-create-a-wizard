using E3403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;

namespace E3403.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Account());
        }
    }
}