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
    
    public partial class Irenginio_busena
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Irenginio_busena()
        {
            this.Remontuojamas_irenginys = new HashSet<Remontuojamas_irenginys>();
        }
    
        public int id_Irenginio_busena { get; set; }
        public string name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remontuojamas_irenginys> Remontuojamas_irenginys { get; set; }
    }
}
