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
    
    public partial class EmployeeFamily
    {
        public int FamilyId { get; set; }
        public int EmpCode { get; set; }
        public string Fname { get; set; }
        public Nullable<System.DateTime> FDob { get; set; }
        public string FGender { get; set; }
        public string FRelation { get; set; }
        public string FContactNumber { get; set; }
        public string FContactAddress { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
