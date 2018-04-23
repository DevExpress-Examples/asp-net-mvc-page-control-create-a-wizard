using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Razor.Models;
using DevExpress.Web.Mvc;
using System.ComponentModel;
using System.Reflection;

namespace DevExpress.Razor.Controllers
{
    public class RegistrationController : Controller
    {
        bool IsChangeShowTabsProperty
        {
            get
            {
                bool value = false;
                if (Session["ShowTabs"] != null)
                {
                    value = Convert.ToBoolean(Session["ShowTabs"]);
                }
                return value;
            }
            set
            {
                Session["ShowTabs"] = value;
            }
        }
        public ActionResult Index(string showTabs)
        {

            return Wizard("true");
        }
        [HttpGet]
        public ActionResult Wizard(string showTabs)
        {
            if (!String.IsNullOrWhiteSpace(showTabs))
                ViewData["ShowTabs"] = IsChangeShowTabsProperty = Convert.ToBoolean(showTabs);
            return View("Wizard", new Account());
        }
        [HttpPost]
        public ActionResult Wizard(Account account)
        {
            if (ModelState.IsValid)
                ViewData["AccountData"] = GetAccountHtmlString(account);
            ViewData["ShowTabs"] = IsChangeShowTabsProperty;
            return View("Wizard", account);
        }
     
        string GetAccountHtmlString(Account account)
        {
            return string.Format("<b>Personal Info:</b><br />{0}<br />{1}<hr />", account.FirstName, account.LastName) +
                   string.Format("<b>Date Info:</b><br />{0}<br />{1}<hr />", account.AnyDate.Value, account.States) +
                   string.Format("<b>Contact Info:</b><br />{0}<br />{1}<hr />", account.Email, account.ZipCode);
        }
    }
}
