using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsAppDemo.Controllers
{
    public class DDLController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CreateDropDown(string modelName)
        {
            try
            {
                var list = new object();
                switch (modelName)
                {
                    case "Role":
                        list = new Business.DDLClass().RoleList().Select(r => new
                        {
                            value = r.ID,
                            label = r.RoleName
                        });
                        break;
                    case "Controller":
                        list = new Business.DDLClass().ControllerList().Select(r => new
                        {
                            value = r.ID,
                            label = r.Name
                        });
                        break;
                    case "Action":
                        list = new Business.DDLClass().ActionList().Select(r => new
                        {
                            value = r.ID,
                            label = r.ActionName
                        }); ;
                        break;
                    case "User":
                        list = new Business.DDLClass().UserList().Select(r => new
                        {
                            value = r.ID,
                            label = r.Name
                        }); ;
                        break;
                }
                var jsonString = JsonConvert.SerializeObject(list);

                return Json(list, modelName, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                throw;
            }
        }
    }
}
