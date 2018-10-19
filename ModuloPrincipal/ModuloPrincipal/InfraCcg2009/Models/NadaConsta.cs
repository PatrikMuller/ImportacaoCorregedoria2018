using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class NadaConsta {
        public virtual int IdNadaConsta { get; set; }
        public virtual string Nome { get; set; }
        public virtual string NumeroDocumento { get; set; }
        public virtual DateTime? DataConsulta { get; set; }
        public virtual int? NumeroOcorrencias { get; set; }
        public virtual string Servidor { get; set; }
        public virtual int? Ano { get; set; }
        public virtual int? Numero { get; set; }
        public virtual string Motivo { get; set; }
        public virtual int? IdTipoDocumento { get; set; }
        public virtual string DocumentoSolicitacao { get; set; }
    }
}
