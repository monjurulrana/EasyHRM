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
    
    public partial class sp_AttendanceEntireYearReport_Result
    {
        public int AttEmpCode { get; set; }
        public Nullable<System.DateTime> AttDate { get; set; }
        public bool Isabsent { get; set; }
        public string AttCheckIn { get; set; }
        public string AttCheckOut { get; set; }
        public Nullable<System.TimeSpan> AttShiftStart { get; set; }
        public Nullable<System.TimeSpan> AttShiftEnd { get; set; }
        public bool IsWeekend { get; set; }
        public Nullable<int> IsHoliday { get; set; }
        public Nullable<int> IsLeave { get; set; }
        public bool IsTraining { get; set; }
        public Nullable<int> IsOfficialVisit { get; set; }
        public Nullable<int> CheckAbsent { get; set; }
        public string leaveTpeName { get; set; }
    }
}