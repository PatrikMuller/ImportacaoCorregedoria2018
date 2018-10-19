using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class Andamento {
        public virtual int IdAndamento { get; set; }
        public virtual int IdProcesso { get; set; }
        public virtual DateTime? Data { get; set; }
        public virtual string Resumo { get; set; }
    }
}
