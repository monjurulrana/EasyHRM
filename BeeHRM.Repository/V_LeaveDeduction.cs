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
    
    public partial class V_LeaveDeduction
    {
        public int EmpCode { get; set; }
        public Nullable<int> LeaveYearId { get; set; }
        public int LeaveTypeId { get; set; }
        public Nullable<decimal> TotalTakenDays { get; set; }
    }
}
