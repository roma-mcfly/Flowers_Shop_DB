//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowersShop_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class type_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public type_tb()
        {
            this.flower_tb = new HashSet<flower_tb>();
        }
    
        public int id_t { get; set; }
        public string name_t { get; set; }
        public string colour_t { get; set; }
        public Nullable<int> term_t { get; set; }
        public Nullable<bool> availability_t { get; set; }
        public string photo_t { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<flower_tb> flower_tb { get; set; }
    }
}