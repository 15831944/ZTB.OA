
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
    public partial class ActionInfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ActionInfo()
    {

        this.DelFag = false;

        this.RoleInfo = new HashSet<RoleInfo>();

        this.RUserActionInfo = new HashSet<RUserActionInfo>();

    }


    public int Id { get; set; }

    public string Url { get; set; }

    public string HttpMethod { get; set; }

    public bool DelFag { get; set; }

    public string Remark { get; set; }

    public string ActionName { get; set; }

    public bool IsMenu { get; set; }

    public Nullable<System.DateTime> ModifyOn { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RoleInfo> RoleInfo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RUserActionInfo> RUserActionInfo { get; set; }

}

}
