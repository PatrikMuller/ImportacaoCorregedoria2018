//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuloPrincipal.InfraCcg2009.LinqCcg2009
{
    using System;
    using System.Collections.Generic;
    
    public partial class Denuncia
    {
        public int id_denuncia { get; set; }
        public string denunciante { get; set; }
        public string denunciado { get; set; }
        public string local_fato { get; set; }
        public Nullable<System.DateTime> data_fato { get; set; }
        public Nullable<System.DateTime> hora_fato { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<System.DateTime> hora { get; set; }
        public string historico { get; set; }
    }
}
