using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJsAppDemo.Business;
using AngularJsAppDemo.DOL;
using AngularJsAppDemo.Utility;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace AngularJsAppDemo.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            var newList = new Business.User().View().Select(u => new
             {
                 ID = u.ID,
                 Name = u.Name,
                 Age = u.Age,
                 Gender = u.Gender,
                 Email = u.EmailID,
                 Address = u.Address
             }).ToArray();

            var availblableTags = newList;
            
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            
            ViewBag.AvailableTags = serializer.Serialize(availblableTags);
            
            return View(new Business.User().View());
        }

        public JsonResult AddUser(List<DOL.User> user)
        {
            foreach (var userIten in user)
            {
                new Business.User().Persist(userIten);
            }

            return Json("Success", JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteUser(int id)
        {
            new Business.User().Delete(id);
            return Json("Success", JsonRequestBehavior.AllowGet);
        }
    }
}
