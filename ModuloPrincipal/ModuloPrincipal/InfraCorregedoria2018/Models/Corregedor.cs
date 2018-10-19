using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCorregedoria2018.Models {
    
    public class Corregedor {
        public Corregedor() { }
        public virtual int Idcorregedor { get; set; }
        public virtual string Nome { get; set; }
        public virtual string ImagePath { get; set; }
        public virtual DateTime? Datainicio { get; set; }
        public virtual DateTime? Datafinal { get; set; }
        public virtual string Status { get; set; }
        public virtual byte[] Imagem { get; set; }
    }
}
