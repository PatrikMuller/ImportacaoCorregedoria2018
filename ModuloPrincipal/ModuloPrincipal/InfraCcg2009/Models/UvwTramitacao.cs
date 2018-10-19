using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class UvwTramitacao {
        public virtual int IdProcesso { get; set; }
        public virtual int Numero { get; set; }
        public virtual int Ano { get; set; }
        public virtual int IdTipoProcesso { get; set; }
        public virtual string Tipo { get; set; }
        public virtual DateTime? DataEnvio { get; set; }
        public virtual int? Destino { get; set; }
        public virtual string UsuarioEnvio { get; set; }
        public virtual DateTime? DataAceite { get; set; }
        public virtual string PessoaAceite { get; set; }
        public virtual string NomeDestino { get; set; }
        public virtual int IdTramitacao { get; set; }
    }
}
