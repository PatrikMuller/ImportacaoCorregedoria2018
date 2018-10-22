//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuloPrincipal.InfraCorregedoria2018.LinqCorregedoria2018
{
    using System;
    using System.Collections.Generic;
    
    public partial class Processo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processo()
        {
            this.ProcessoSindicado = new HashSet<ProcessoSindicado>();
            this.ProcessoTestemunha = new HashSet<ProcessoTestemunha>();
        }
    
        public int idProcesso { get; set; }
        public int idTipoProcesso { get; set; }
        public string numeroProcesso { get; set; }
        public Nullable<int> anoProcesso { get; set; }
        public System.DateTime dataInstauracao { get; set; }
        public string portariaInstauracao { get; set; }
        public string historico { get; set; }
        public Nullable<System.DateTime> dataEncerramento { get; set; }
        public Nullable<int> idMunicipio { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual tipoProcesso tipoProcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessoSindicado> ProcessoSindicado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessoTestemunha> ProcessoTestemunha { get; set; }
    }
}
