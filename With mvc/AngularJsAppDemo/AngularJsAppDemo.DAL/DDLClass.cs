using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngularJsAppDemo.DOL;

namespace AngularJsAppDemo.DAL
{
    public class DDLClass
    {
        DataModelContainer container = new DataModelContainer();
        public List<DOL.Role> RoleList()
        {
            var list = container.Roles.ToList();
            return list;
        }
        public List<DOL.ControllerName> ControllerList()
        {
            var list = container.ControllerNames.ToList();
            return list;
        }
        public List<DOL.Action> ActionList()
        {
            var list = container.Actions.ToList();
            return list;
        }
        public List<DOL.User> UserList()
        {
            var list = container.Users.ToList();
            return list;
        }
    }
}
