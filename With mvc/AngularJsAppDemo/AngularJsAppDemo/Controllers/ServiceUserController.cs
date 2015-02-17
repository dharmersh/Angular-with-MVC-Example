using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJsAppDemo.DOL;
using AngularJsAppDemo.Business;


namespace AngularJsAppDemo.Controllers
{
    public class ServiceUserController : Controller
    {
        public string MyName()
        {
            return new Business.ServiceClass().MyName();
        }

        public ActionResult Index()
        {
            return View(new Business.ServiceClass().View());
        }
    }
}
