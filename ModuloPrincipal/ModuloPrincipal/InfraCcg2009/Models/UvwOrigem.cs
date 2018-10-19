using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class UvwOrigem {
        public virtual DateTime? DataEnvio { get; set; }
        public virtual string Origem { get; set; }
        public virtual string UsuarioEnvio { get; set; }
        public virtual string Destino { get; set; }
        public virtual DateTime? DataAceite { get; set; }
        public virtual string PessoaAceite { get; set; }
        public virtual string Obs { get; set; }
        public virtual int IdTramitacao { get; set; }
        public virtual int IdProcesso { get; set; }
        public virtual int Numero { get; set; }
        public virtual int Ano { get; set; }
        public virtual string Tipo { get; set; }
        public virtual int? IdDestino { get; set; }
        public virtual string Receptor { get; set; }
        public virtual string Status { get; set; }
    }
}
