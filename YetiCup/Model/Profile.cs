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
    
    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            this.Participants = new HashSet<Participants>();
        }
    
        public int user_id { get; set; }
        public string fist_name { get; set; }
        public string second_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string location { get; set; }
        public string School { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participants> Participants { get; set; }
        public virtual Users Users { get; set; }
    }
}
