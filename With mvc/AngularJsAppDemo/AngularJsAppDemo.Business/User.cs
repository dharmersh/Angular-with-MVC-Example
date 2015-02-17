using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngularJsAppDemo.Utility;
using AngularJsAppDemo.DOL;
using AngularJsAppDemo.DAL;

namespace AngularJsAppDemo.Business
{
    public class User:IModelFactory<DOL.User>
    {
        public List<DOL.User> View()
        {
            
            return new DAL.User().View();
        }

        public DOL.User ViewByID(DOL.User model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            new DAL.User().Delete(id);
        }

        public string Persist(DOL.User model)
        {
            return new DAL.User().Persist(model);
        }
    }
}
