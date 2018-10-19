using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Pessoa {
        public Pessoa() { }
        public virtual int IdPessoa { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual string TipoPessoa { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpfcnpj { get; set; }
        public virtual string Rgie { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Matricula { get; set; }
    }
}
