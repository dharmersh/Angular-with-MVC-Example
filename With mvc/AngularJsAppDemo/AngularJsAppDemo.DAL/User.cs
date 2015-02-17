using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngularJsAppDemo.Utility;
using AngularJsAppDemo.DOL;

namespace AngularJsAppDemo.DAL
{
    public class User : IModelFactory<DOL.User>
    {
        DataModelContainer container = new DataModelContainer();
        public List<DOL.User> View()
        {
            try
            {
                return container.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        public DOL.User ViewByID(DOL.User model)
        {
            try
            {
                return container.Users.FirstOrDefault(u => u.ID == model.ID);
            }
            catch
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var user = container.Users.FirstOrDefault(u => u.ID == id);
                container.Users.Remove(user);
                container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public string Persist(DOL.User model)
        {
            string message = string.Empty;
            try
            {
                if (model != null)
                {
                    if (model.ID > 0)
                    {
                        var user = container.Users.FirstOrDefault(u => u.ID == model.ID);
                        user.Name = model.Name;
                        user.Age = model.Age;
                        user.Address = model.Address;
                        message = "Update Successfully";
                    }
                    else
                    {
                        container.Users.Add(model);
                    }
                    container.SaveChanges();
                }
                return message;
            }
            catch
            {
                throw;
            }
        }
    }
}
