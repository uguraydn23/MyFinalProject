using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // class: referans tip
    // Ya Ientitiy olabilir yada ondan referans alan olabilir
    // new lene bilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        //filter null , filtrede vermeyebilirsin.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
