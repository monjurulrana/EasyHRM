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
    
    public partial class ReportingGroupMember
    {
        public int ReportingId { get; set; }
        public int ReportingGroupId { get; set; }
        public Nullable<int> ReportingEmpCode { get; set; }
        public bool ReportingStatus { get; set; }
        public Nullable<System.DateTime> ReportingStartDate { get; set; }
    }
}
