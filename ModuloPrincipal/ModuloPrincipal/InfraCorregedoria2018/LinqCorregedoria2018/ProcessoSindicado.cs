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
    
    public partial class ProcessoSindicado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessoSindicado()
        {
            this.Pena = new HashSet<Pena>();
        }
    
        public int idProcessoAcusado { get; set; }
        public Nullable<int> idProcesso { get; set; }
        public Nullable<int> idPessoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pena> Pena { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
