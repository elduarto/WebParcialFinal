//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchases()
        {
            this.Inventory = new HashSet<Inventory>();
        }
    
        public int purchase_id { get; set; }
        public int supplier_id { get; set; }
        public System.DateTime date { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public int unit_cost { get; set; }
        public int total_cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
