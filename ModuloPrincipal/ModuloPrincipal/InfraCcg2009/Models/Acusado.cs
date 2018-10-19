using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class Acusado {
        public virtual int IdAcusado { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpfcnpj { get; set; }
        public virtual string Rg { get; set; }
        public virtual string Cnh { get; set; }
        public virtual string Renach { get; set; }
        public virtual DateTime? DataCadastro { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Municipio { get; set; }
        public virtual string Uf { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Fone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Matricula { get; set; }
        public virtual string PessoaTipo { get; set; }
    }
}
