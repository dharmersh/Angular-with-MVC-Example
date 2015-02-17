using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJsAppDemo.DAL;

namespace AngularJsAppDemo.Business
{
    public class ServiceClass
    {
        public string MyName()
        {
            return new DAL.ServiceClass().MyName();
        }
        public List<DOL.User> View()
        {
            return new DAL.ServiceClass().View();
        }
    }
}
