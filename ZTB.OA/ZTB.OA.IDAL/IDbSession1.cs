﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     如需对单个文件扩展请使用部分类，否则当文本模板文件再次保存时将把修改冲刷掉
// </auto-generated>
//------------------------------------------------------------------------------


namespace ZTB.OA.IDAL
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


 public partial interface IDbSession 
{   

		IActionInfoDal ActionInfoDal { get;}            

		IRUserActionInfoDal RUserActionInfoDal { get;}            

		IRoleInfoDal RoleInfoDal { get;}            

		IUserInfoDal UserInfoDal { get;}            

		int SaveChanges();
}

}

