//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeeHRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportingGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupHeadEmpCode { get; set; }
        public Nullable<System.DateTime> GroupHeadStartDate { get; set; }
        public int GroupStatus { get; set; }
    }
}