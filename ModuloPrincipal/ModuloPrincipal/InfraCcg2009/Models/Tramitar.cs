using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class Tramitar {
        public virtual int IdTramitacao { get; set; }
        public virtual int? IdProcesso { get; set; }
        public virtual DateTime? DataEnvio { get; set; }
        public virtual string UsuarioEnvio { get; set; }
        public virtual int? Destino { get; set; }
        public virtual string UsuarioDestino { get; set; }
        public virtual DateTime? DataAceite { get; set; }
        public virtual string PessoaAceite { get; set; }
        public virtual string Observacao { get; set; }
        public virtual string Estatus { get; set; }
    }
}
