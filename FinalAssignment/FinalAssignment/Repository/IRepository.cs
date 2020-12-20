﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignemntFinal.Repository
{
    interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(int id);
        void Insert(T entity);
        void Delete(int id);
        void Edit(T entity);

    }
}