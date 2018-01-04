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
    
    public partial class PayrollSalaryMasterSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayrollSalaryMasterSheet()
        {
            this.PayrollEmployeeTaxDetails = new HashSet<PayrollEmployeeTaxDetail>();
            this.PayrollSalaryDetailSheets = new HashSet<PayrollSalaryDetailSheet>();
        }
    
        public int Id { get; set; }
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string MaritialStatus { get; set; }
        public int DesignationCode { get; set; }
        public int DepartmentCode { get; set; }
        public int BranchCode { get; set; }
        public decimal RankSalary { get; set; }
        public int CurrentGrade { get; set; }
        public decimal RankMaxGrade { get; set; }
        public decimal RankPerGradeAmount { get; set; }
        public decimal GradeSalary { get; set; }
        public decimal RankAndGradeSalary { get; set; }
        public decimal PfSelf { get; set; }
        public decimal PfCompany { get; set; }
        public decimal PfExtra { get; set; }
        public decimal BankAllowance { get; set; }
        public decimal RankSpecialAllowance { get; set; }
        public decimal RankInchargeShipAllowance { get; set; }
        public decimal RankOtherAllowances { get; set; }
        public decimal TotalRankAllowances { get; set; }
        public decimal SalaryWithRankAllowance { get; set; }
        public decimal RemoteAllowanceId { get; set; }
        public string RemoteAllowanceType { get; set; }
        public decimal RemoteAllowance { get; set; }
        public decimal RemoteTaxExcemption { get; set; }
        public decimal TaxableAllowanceAmount { get; set; }
        public decimal NonTaxableAllowanceAmount { get; set; }
        public decimal TaxablePfCitAmount { get; set; }
        public decimal CitAmount { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal TaxableSalary { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal SalaryAfterTaxDeduction { get; set; }
        public bool EmpAttendanceIgnore { get; set; }
        public decimal WorkingDays { get; set; }
        public decimal WorkedDays { get; set; }
        public decimal PerDaysalary { get; set; }
        public decimal DeductableDays { get; set; }
        public decimal ActualSalary { get; set; }
        public int PayrollSalaryTableId { get; set; }
        public Nullable<decimal> YearlyTaxableIncome { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Office Office { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollEmployeeTaxDetail> PayrollEmployeeTaxDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayrollSalaryDetailSheet> PayrollSalaryDetailSheets { get; set; }
        public virtual PayrollSalaryTable PayrollSalaryTable { get; set; }
    }
}