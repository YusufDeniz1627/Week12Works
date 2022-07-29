using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //T'yi kısıtlamak için int,string vb. degerler girilmemesi adına filtrelemek için Genereic Constraint ile kısıtlıyoruz
    //IEntity : IEntity olabilir veya onu implemente eden bir class olabilir!!
    //new(): new'lenebilir olmalı IEntity interface oldugu için new'lenemez.!
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
