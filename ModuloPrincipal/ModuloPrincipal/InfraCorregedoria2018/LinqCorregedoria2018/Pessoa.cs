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
    
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            this.ProcessoSindicado = new HashSet<ProcessoSindicado>();
            this.ProcessoTestemunha = new HashSet<ProcessoTestemunha>();
        }
    
        public int idPessoa { get; set; }
        public string tipoPessoa { get; set; }
        public string nome { get; set; }
        public string cpfcnpj { get; set; }
        public string rgie { get; set; }
        public string telefone { get; set; }
        public string matricula { get; set; }
        public Nullable<int> idEndereco { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessoSindicado> ProcessoSindicado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessoTestemunha> ProcessoTestemunha { get; set; }
    }
}