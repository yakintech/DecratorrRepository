﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorRepo
{
    interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
    }
}
