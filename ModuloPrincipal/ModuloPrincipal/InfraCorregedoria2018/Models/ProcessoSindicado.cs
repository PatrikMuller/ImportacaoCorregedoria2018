using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class ProcessoSindicado {
        public ProcessoSindicado() { }
        public virtual int IdProcessoAcusado { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
