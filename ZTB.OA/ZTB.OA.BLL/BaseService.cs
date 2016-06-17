﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZTB.OA.DALFactory;
using ZTB.OA.IDAL;

namespace ZTB.OA.BLL
{
    /// <summary>
    /// 父类比
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseService<T> where T : class, new()
    {

        public IBaseDal<T> CurrentDal { get; set; }

        public IDbSession DbSession
        {
            get { return DbSessionFactory.GetCurrentDbSession(); }
        }

        public BaseService()
        {
            SetCurrentDal();
        }

        public abstract void SetCurrentDal();//抽象方法，子类必须实现


        #region 查询
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamba)
        {
            return CurrentDal.GetEntities(whereLamba);
        }

        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda,
            Expression<Func<T, S>> orderLambda, bool isAsc)
        {
            return CurrentDal.GetPageEntities(pageSize, pageIndex, out total, whereLambda, orderLambda, isAsc);

        }
        #endregion

        public T Add(T entity)
        {
            CurrentDal.Add(entity);
            DbSession.SaveChanges();
            return entity;
        }

        public bool Update(T entity)
        {
            CurrentDal.Update(entity);
            return DbSession.SaveChanges() > 0;

        }
        public bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return DbSession.SaveChanges() > 0;
        }

    }
}