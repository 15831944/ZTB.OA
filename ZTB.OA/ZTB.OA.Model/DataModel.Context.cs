﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace ZTB.OA.Model
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DataModelContainer : DbContext
{
    public DataModelContainer()
        : base("name=DataModelContainer")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ActionInfo> ActionInfo { get; set; }

    public virtual DbSet<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }

    public virtual DbSet<RoleInfo> RoleInfo { get; set; }

    public virtual DbSet<UserInfo> UserInfo { get; set; }

    public virtual DbSet<WP_Temp> WP_Temp { get; set; }

    public virtual DbSet<WF_Instance> WF_Instance { get; set; }

    public virtual DbSet<FileInfo> FileInfo { get; set; }

    public virtual DbSet<WF_Step> WF_Step { get; set; }

}

}

