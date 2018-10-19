using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class Processo {
        public Processo() { }
        public virtual int IdProcesso { get; set; }
        public virtual int Numero { get; set; }
        public virtual int Ano { get; set; }
        public virtual int IdTipoProcesso { get; set; }
        public virtual int IdTipoDocumento { get; set; }
        public virtual string IdMunicipio { get; set; }
        public virtual DateTime? Data { get; set; }
        public virtual DateTime? DataInstauracao { get; set; }
        public virtual DateTime? DataEncerramento { get; set; }
        public virtual string Placa { get; set; }
        public virtual string Renavam { get; set; }
        public virtual string PresidenteComissao { get; set; }
        public virtual string SecretarioComissao { get; set; }
        public virtual string MembroComissao { get; set; }
        public virtual string LocalFato { get; set; }
        public virtual DateTime? DataFato { get; set; }
        public virtual string PortariaInstautaracao { get; set; }
        public virtual string Historico { get; set; }
        public virtual string PortariaEncerramento { get; set; }
        public virtual string Punicao { get; set; }
        public virtual string Andamento { get; set; }
        public virtual int? IdComissao { get; set; }
        public virtual string ResumoPunicao { get; set; }
        public virtual string Status { get; set; }
    }
}
