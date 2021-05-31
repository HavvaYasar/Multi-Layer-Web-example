using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{   // T tipini kısıtlamak istiyorum
    // referans tip olur
    //IEntity i implemente eden bir nesne olabilir;product,costumer,category

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre yazabilmemizi sağlayaccak.

        //filtreye göre veri getirme 
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
    }

   
