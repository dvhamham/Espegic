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
    
    public partial class MODULE
    {
        public int ID { get; set; }
        public int FORMATION_ID { get; set; }
        public string NAME { get; set; }
        public bool ARCHIVE { get; set; }
        public int CREATED_BY { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int UPDATED_BY { get; set; }
        public System.DateTime UPDATED_AT { get; set; }
    
        public virtual FORMATION FORMATION { get; set; }
    }
}
