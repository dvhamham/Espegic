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
    
    public partial class PAYMENT
    {
        public int ID { get; set; }
        public Nullable<int> STUDENT_ID { get; set; }
        public Nullable<int> MONTH { get; set; }
        public Nullable<int> PRICE { get; set; }
        public Nullable<int> YEAR { get; set; }
        public Nullable<System.DateTime> CREATED_AT { get; set; }
        public Nullable<int> PAYED { get; set; }
        public Nullable<int> STILL { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
    }
}
