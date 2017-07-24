using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorRepo
{
    class DeCratorRepository<T> : IRepository<T>
    {
        IRepository<T> repository;

        public DeCratorRepository(IRepository<T> repo)
        {
            repository = repo;
        }

        public virtual void Add(T entity)
        {
            repository.Add(entity);
        }

        public List<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}
