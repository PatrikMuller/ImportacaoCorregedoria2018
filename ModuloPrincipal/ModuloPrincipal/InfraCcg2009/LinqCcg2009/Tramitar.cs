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
    
    public partial class Tramitar
    {
        public int id_tramitacao { get; set; }
        public Nullable<int> id_processo { get; set; }
        public Nullable<System.DateTime> data_envio { get; set; }
        public string usuario_envio { get; set; }
        public Nullable<int> destino { get; set; }
        public string UsuarioDestino { get; set; }
        public Nullable<System.DateTime> data_aceite { get; set; }
        public string pessoa_aceite { get; set; }
        public string observacao { get; set; }
        public string estatus { get; set; }
    }
}