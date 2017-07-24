using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorRepo
{
    class LoggerRepository<T> : DeCratorRepository<T>
    {
        public LoggerRepository(IRepository<T> repo) : base(repo)
        {
        }

        public override void Add(T entity)
        {
            System.Console.WriteLine("Loglama işlemi yapıldı");
            base.Add(entity);
        }
    }
}
