using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJsAppDemo.DAL.MyServiceReference;
namespace AngularJsAppDemo.DAL
{
    public class ServiceClass
    {
        UserServiceClient client = new UserServiceClient();
        public string MyName()
        {
            return client.MyName();
        }

        public List<DOL.User> View()
        {
            var list = client.View().ToList<DOL.User>();
            return list;
        }

    }
}
