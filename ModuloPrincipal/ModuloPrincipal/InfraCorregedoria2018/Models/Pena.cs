using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Pena {
        public virtual int IdPena { get; set; }
        public virtual ProcessoSindicado ProcessoSindicado { get; set; }
        public virtual string Punicao { get; set; }
        public virtual DateTime? DataPublicacao { get; set; }
        public virtual string Portaria { get; set; }
        public virtual string Ativo { get; set; }
    }
}
