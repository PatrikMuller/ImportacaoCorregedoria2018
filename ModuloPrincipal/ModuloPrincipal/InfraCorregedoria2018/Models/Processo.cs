using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Processo {
        public Processo() { }
        public virtual int IdProcesso { get; set; }
        public virtual TipoProcesso TipoProcesso { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual string NumeroProcesso { get; set; }
        public virtual int? AnoProcesso { get; set; }
        public virtual DateTime DataInstauracao { get; set; }
        public virtual string PortariaInstauracao { get; set; }
        public virtual string Historico { get; set; }
        public virtual DateTime? DataEncerramento { get; set; }
    }
}
