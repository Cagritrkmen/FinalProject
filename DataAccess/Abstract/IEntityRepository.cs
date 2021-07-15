using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{//generic constraint
    //class:referans tip olabilir demek
    //IEntity: ya IEntity olabilir ya da bunu implemente eden nesne olabilir 
    // new(): IEntity olamaz(aslında newlenemez demek soyut nesneler newlenemez yani interfaceler) 
   public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
