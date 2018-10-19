using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Certidao {
        public virtual int IdCertidao { get; set; }
        public virtual Corregedor Corregedor { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpfcnpj { get; set; }
        public virtual string Validador { get; set; }
        public virtual DateTime? DataEmissao { get; set; }
        public virtual DateTime? DataValidade { get; set; }
    }
}
