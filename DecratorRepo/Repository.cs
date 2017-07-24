using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorRepo
{
    class Repository<T> : IRepository<T> where T : class
    {
        NorthwindEntities db;
        DbSet<T> dbset;
        public Repository()
        {
            db = new NorthwindEntities();
            dbset = db.Set<T>();

        }

        public void Add(T entity)
        {
            dbset.Add(entity);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbset.ToList();
        }
    }
}
