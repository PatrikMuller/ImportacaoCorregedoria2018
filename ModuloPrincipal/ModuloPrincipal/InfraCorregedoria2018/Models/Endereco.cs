using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Endereco {
        public Endereco() { }
        public virtual int IdEndereco { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cep { get; set; }
    }
}
