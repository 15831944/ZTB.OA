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


 public partial class StaticFactory
{   
//TODO 此处需要增加缓存
	static  string assemblyName = System.Configuration.ConfigurationManager.AppSettings["DalAssemblyName"];
		
	public static IUserInfoDal GetUserInfoDal()
    {          
        return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserInfoDal") as IUserInfoDal;
    }
		
	public static IOrderInfoDal GetOrderInfoDal()
    {          
        return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".OrderInfoDal") as IOrderInfoDal;
    }
		
	public static IRoleInfoDal GetRoleInfoDal()
    {          
        return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".RoleInfoDal") as IRoleInfoDal;
    }

}

}

