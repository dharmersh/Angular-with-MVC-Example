using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJsAppDemo.DAL;
using AngularJsAppDemo.DOL;

namespace AngularJsAppDemo.Business
{
    public class DDLClass
    {
        public List<DOL.Role> RoleList()
        {
            return new DAL.DDLClass().RoleList();
        }
        public List<DOL.ControllerName> ControllerList()
        {
            return new DAL.DDLClass().ControllerList();
        }
        public List<DOL.Action> ActionList()
        {
            return new DAL.DDLClass().ActionList();
        }
        public List<DOL.User> UserList()
        {
            return new DAL.DDLClass().UserList();
        }
    }
}
