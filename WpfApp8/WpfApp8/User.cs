//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp8
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int kod_user { get; set; }
        public Nullable<int> kod_Person { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}
