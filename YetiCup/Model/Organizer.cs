//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YetiCup.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organizer
    {
        public int id { get; set; }
        public int championship_id { get; set; }
        public string password { get; set; }
    
        public virtual Championships Championships { get; set; }
    }
}
