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
    
    public partial class buy_tb
    {
        public int id_b { get; set; }
        public Nullable<int> idF_b { get; set; }
        public Nullable<int> count_b { get; set; }
        public Nullable<System.DateTime> date_b { get; set; }
        public Nullable<int> sale_b { get; set; }
    
        public virtual flower_tb flower_tb { get; set; }
    }
}
