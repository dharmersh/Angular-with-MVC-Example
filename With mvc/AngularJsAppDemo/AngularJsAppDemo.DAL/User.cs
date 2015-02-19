using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngularJsAppDemo.Utility;
using AngularJsAppDemo.DOL;
using System.Data.Entity.Validation;

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
                        model.Gender = "M";
                        model.MiddleName = "";
                        model.LastName="";
                        container.Users.Add(model);
                        message = "Added Successfully";
                    }
                    container.SaveChanges();
                }
                return message;
            }
           catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}
