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
    
    public partial class PayrollAllowanceDetail
    {
        public int Id { get; set; }
        public int AllowanceMasterId { get; set; }
        public int EmployeeCode { get; set; }
        public string PercentageAmount { get; set; }
        public Nullable<decimal> Value { get; set; }
    
        public virtual PayrollAllowanceMaster PayrollAllowanceMaster { get; set; }
    }
}
