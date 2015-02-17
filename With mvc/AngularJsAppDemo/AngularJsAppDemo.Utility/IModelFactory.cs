using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJsAppDemo.Utility
{
    public interface IModelFactory<T>
    {
        List<T> View();
        T ViewByID(T model);
        void Delete(int id);
        string  Persist(T model);
    }
}
