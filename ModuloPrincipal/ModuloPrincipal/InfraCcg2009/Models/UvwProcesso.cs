using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class UvwProcesso {
        public virtual int Numero { get; set; }
        public virtual int Ano { get; set; }
        public virtual string TipoProcesso { get; set; }
        public virtual string Municipio { get; set; }
        public virtual string Portaria { get; set; }
        public virtual string Placa { get; set; }
        public virtual string Renavam { get; set; }
        public virtual int IdTipoProcesso { get; set; }
        public virtual int IdProcesso { get; set; }
        public virtual DateTime? DataFato { get; set; }
        public virtual string IdMunicipio { get; set; }
        public virtual DateTime? DataInstauracao { get; set; }
        public virtual DateTime? DataEncerramento { get; set; }
        public virtual int? IdComissao { get; set; }
        public virtual string NomeComissao { get; set; }
        public virtual string Historico { get; set; }
        public virtual string Punicao { get; set; }
        public virtual string Status { get; set; }
    }
}
