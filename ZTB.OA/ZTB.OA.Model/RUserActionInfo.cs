
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
    using System.Collections.Generic;
    
[Serializable]
    public partial class RUserActionInfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public RUserActionInfo()
    {

        this.DelFag = false;

    }


    public int Id { get; set; }

    public bool HasPermission { get; set; }

    public Nullable<bool> DelFag { get; set; }

    public Nullable<System.DateTime> ModifyOn { get; set; }

    public int UserInfoId { get; set; }

    public int ActionInfoId { get; set; }



    public virtual UserInfo UserInfo { get; set; }

    public virtual ActionInfo ActionInfo { get; set; }

}

}
