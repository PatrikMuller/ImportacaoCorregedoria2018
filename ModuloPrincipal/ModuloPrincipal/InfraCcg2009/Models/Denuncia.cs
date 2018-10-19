using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class Denuncia {
        public virtual int IdDenuncia { get; set; }
        public virtual string Denunciante { get; set; }
        public virtual string Denunciado { get; set; }
        public virtual string LocalFato { get; set; }
        public virtual DateTime? DataFato { get; set; }
        public virtual DateTime? HoraFato { get; set; }
        public virtual DateTime? Data { get; set; }
        public virtual DateTime? Hora { get; set; }
        public virtual string Historico { get; set; }
    }
}
