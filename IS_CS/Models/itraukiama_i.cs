//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IS_CS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class itraukiama_i
    {
        public int fk_Prekebar_kodas { get; set; }
        public int fk_Prekiu_krepselisprekiu_krepselio_id { get; set; }
    
        public virtual Preke Preke { get; set; }
    }
}
