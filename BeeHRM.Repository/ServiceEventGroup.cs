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
    
    public partial class ServiceEventGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceEventGroup()
        {
            this.EmployeeJobHistories = new HashSet<EmployeeJobHistory>();
        }
    
        public int ServiceEventId { get; set; }
        public string ServiceEventGroupName { get; set; }
        public string ServiceEventGroupDetails { get; set; }
        public Nullable<int> ServiceEventOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeJobHistory> EmployeeJobHistories { get; set; }
    }
}
