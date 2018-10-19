using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class ProcessoTestemunha {
        public virtual int IdProcessoTestemunha { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
