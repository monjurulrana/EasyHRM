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
    
    public partial class PayrollEmployeeTaxDetail
    {
        public int Id { get; set; }
        public int EmployeeCode { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal DeductPercentage { get; set; }
        public decimal DeductedAmount { get; set; }
        public int OrderNumber { get; set; }
        public int PayrollMasterSheetID { get; set; }
    
        public virtual PayrollSalaryMasterSheet PayrollSalaryMasterSheet { get; set; }
    }
}
