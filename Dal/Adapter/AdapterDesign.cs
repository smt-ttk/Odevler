using Dal.Interface;
using System.Linq;
using Dal.Model;

namespace Dal.Adapter
{
    internal class AdapterDesign : ICrud
    {
        public void Delete<T>(int id) where T : class
        {
            T model = Find<T>(id);

            using(AdapterDesignContext adapterDesignContext = new AdapterDesignContext())
            {
                adapterDesignContext.Set<T>().Remove(model);
                adapterDesignContext.SaveChangesAsync();
            }
            
        }

        public T Find<T>(int id) where T : class
        {
            T item;

           using(AdapterDesignContext adapterDesignContext = new AdapterDesignContext())
            {
              

                item = adapterDesignContext.Set<T>().Find(id);
            }

            return item;
        }

        public T Insert<T>(T model) where T : class
        {
            using (AdapterDesignContext adapterDesignContext = new AdapterDesignContext())
            {
                adapterDesignContext.Set<T>().Add(model);
                adapterDesignContext.SaveChanges();
            }
            return model;
        }

        public T Update<T>(T model) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}