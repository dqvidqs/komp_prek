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
    
    public partial class Grazinima
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grazinima()
        {
            this.Patvirtinimas = new HashSet<Patvirtinima>();
            this.Uzsakymas = new HashSet<Uzsakyma>();
        }
    
        public int nr { get; set; }
        public System.DateTime data { get; set; }
        public string grazinimo_aprasymas { get; set; }
        public int fk_grazinimo_priezastis { get; set; }
        public int fk_Klientas_paskyros_id { get; set; }
        public int fk_Grazinimo_busena { get; set; }
    
        public virtual Grazinimo_priezastis Grazinimo_priezastis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patvirtinima> Patvirtinimas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzsakyma> Uzsakymas { get; set; }
        public virtual Grazinimo_busena Grazinimo_busena { get; set; }
    }
}
