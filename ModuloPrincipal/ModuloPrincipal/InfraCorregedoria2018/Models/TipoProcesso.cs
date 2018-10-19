using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class TipoProcesso {
        public TipoProcesso() { }
        public virtual int IdTipoProcesso { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sigla { get; set; }
    }
}
