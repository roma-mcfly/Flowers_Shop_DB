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
    
    public partial class flower_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public flower_tb()
        {
            this.buy_tb = new HashSet<buy_tb>();
        }
    
        public int id_f { get; set; }
        public string name_f { get; set; }
        public Nullable<int> idT_f { get; set; }
        public Nullable<int> cost_f { get; set; }
        public Nullable<int> count_f { get; set; }
        public Nullable<bool> availability_f { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buy_tb> buy_tb { get; set; }
        public virtual type_tb type_tb { get; set; }
    }
}
