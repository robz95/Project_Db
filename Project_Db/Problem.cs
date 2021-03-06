//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Problem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Problem()
        {
            this.AssigneeLogs = new HashSet<AssigneeLog>();
            this.ProblemCallLogs = new HashSet<ProblemCallLog>();
        }
    
        public int ProblemID { get; set; }
        public string EquipementID { get; set; }
        public string EmployeeID { get; set; }
        public byte[] ProblemType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string TimeResolved { get; set; }
        public string Solution { get; set; }
        public int ProblemTypeTypeID { get; set; }
        public int EquipementEquipmentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssigneeLog> AssigneeLogs { get; set; }
        public virtual Equipement Equipement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProblemCallLog> ProblemCallLogs { get; set; }
        public virtual ProblemType ProblemType1 { get; set; }
    }
}
