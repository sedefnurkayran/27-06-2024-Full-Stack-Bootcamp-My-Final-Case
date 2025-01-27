﻿using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{

    public interface IGenericDal<T> where T : class
    {

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAllList();
        T GetById(int id);

        List<T> GetAllList(Expression<Func<T, bool>> filter);
    }

}
