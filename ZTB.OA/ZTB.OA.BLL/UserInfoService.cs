﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTB.OA.DALFactory;
using ZTB.OA.EFDAL;
using ZTB.OA.IBLL;
using ZTB.OA.IDAL;
using ZTB.OA.Model;

namespace ZTB.OA.BLL
{
    public class UserInfoService: BaseService<UserInfo>, IUserInfoService
    {
        public  IDbSession DbSession { get; set; }

        //public UserInfoService(IDbSession dbSession):base(dbSession)
        //{
        //  //  DbSession = dbSession;
        //}

        //菜鸟级别
        //UserInfoDal userInfoDal = new UserInfoDal();
        //IUserInfoDal userInfoDal =  new UserInfoDal();//依赖接口编程

        //稍微高级点的开发人员
        // IUserInfoDal userInfoDal = StaticFactory.GetUserInfoDal();

        //更高级 Ioc DI 依赖注入
        //IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();

        //public override void SetCurrentDal()
        //{
        //    CurrentDal = DbSession.UserInfoDal;
        //}
    }
}
