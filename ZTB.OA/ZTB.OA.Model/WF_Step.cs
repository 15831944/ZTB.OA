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
    public partial class WF_Step
    {
        public int Id { get; set; }
        public string StepName { get; set; }
        public int ProcessBy { get; set; }
        public System.DateTime SubTime { get; set; }
        public System.DateTime ProcessTime { get; set; }
        public string ProcessResult { get; set; }
        public string ProcessComment { get; set; }
        public Nullable<short> StepStatus { get; set; }
        public bool IsStartStep { get; set; }
        public bool IsEndStep { get; set; }
        public Nullable<int> ParentStepId { get; set; }
        public int WF_InstanceId { get; set; }
    
        public virtual WF_Instance WF_Instance { get; set; }
    }
}
