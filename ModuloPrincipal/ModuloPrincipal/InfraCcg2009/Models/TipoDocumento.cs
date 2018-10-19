using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class TipoDocumento {
        public TipoDocumento() { }
        public virtual int IdTipoDocumento { get; set; }
        public virtual string Nome { get; set; }
    }
}
