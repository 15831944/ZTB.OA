﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     如需对单个文件扩展请使用部分类，否则当文本模板文件再次保存时将把修改冲刷掉
// </auto-generated>
//------------------------------------------------------------------------------


namespace ZTB.OA.DALFactory
{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZTB.OA.EFDAL;
using ZTB.OA.IDAL;
using Common.Caches;


 public partial class StaticFactory
{   
    
	static  string assemblyName = System.Configuration.ConfigurationManager.AppSettings["DalAssemblyName"];
		
	public static IActionInfoDal GetActionInfoDal()
    {          
	     var tempDal = CacheHelper.GetCache(assemblyName + ".ActionInfoDal");
         if (tempDal == null)
    	 {
             tempDal = Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ActionInfoDal");
    	     CacheHelper.InsertCache(assemblyName + ".ActionInfoDal",tempDal);
    	 }
         return tempDal as IActionInfoDal;
    }
		
	public static IRUserActionInfoDal GetRUserActionInfoDal()
    {          
	     var tempDal = CacheHelper.GetCache(assemblyName + ".RUserActionInfoDal");
         if (tempDal == null)
    	 {
             tempDal = Assembly.Load(assemblyName).CreateInstance(assemblyName + ".RUserActionInfoDal");
    	     CacheHelper.InsertCache(assemblyName + ".RUserActionInfoDal",tempDal);
    	 }
         return tempDal as IRUserActionInfoDal;
    }
		
	public static IRoleInfoDal GetRoleInfoDal()
    {          
	     var tempDal = CacheHelper.GetCache(assemblyName + ".RoleInfoDal");
         if (tempDal == null)
    	 {
             tempDal = Assembly.Load(assemblyName).CreateInstance(assemblyName + ".RoleInfoDal");
    	     CacheHelper.InsertCache(assemblyName + ".RoleInfoDal",tempDal);
    	 }
         return tempDal as IRoleInfoDal;
    }
		
	public static IUserInfoDal GetUserInfoDal()
    {          
	     var tempDal = CacheHelper.GetCache(assemblyName + ".UserInfoDal");
         if (tempDal == null)
    	 {
             tempDal = Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserInfoDal");
    	     CacheHelper.InsertCache(assemblyName + ".UserInfoDal",tempDal);
    	 }
         return tempDal as IUserInfoDal;
    }

}

}

