//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lr_fifteen
{
    using System;
    using System.Collections.Generic;
    
    public partial class uspev
    {
        public byte id_s { get; set; }
        public string dics { get; set; }
        public Nullable<decimal> ocenka { get; set; }
    
        public virtual students students { get; set; }
    }
}
