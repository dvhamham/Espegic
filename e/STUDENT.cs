//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e
{
    using System;
    using System.Collections.Generic;
    
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            this.PAYMENTs = new HashSet<PAYMENT>();
        }
    
        public int ID { get; set; }
        public int FORMATION_ID { get; set; }
        public string CIN { get; set; }
        public string F_NAME { get; set; }
        public string L_NAME { get; set; }
        public string MASSAR { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string NATIONALITY { get; set; }
        public string SEX { get; set; }
        public Nullable<System.DateTime> BIRTH { get; set; }
        public string ESTABLISHEMENT { get; set; }
        public string PROVINCE { get; set; }
        public string COMMUN { get; set; }
        public string ADRESS { get; set; }
        public Nullable<int> REDUCTION { get; set; }
        public bool ARCHIVE { get; set; }
        public int CREATED_BY { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int UPDATED_BY { get; set; }
        public System.DateTime UPDATED_AT { get; set; }
    
        public virtual FORMATION FORMATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAYMENT> PAYMENTs { get; set; }
    }
}
