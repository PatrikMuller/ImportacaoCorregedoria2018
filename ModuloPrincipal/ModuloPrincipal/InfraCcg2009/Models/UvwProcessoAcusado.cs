using System;
using System.Text;
using System.Collections.Generic;


namespace ModuloPrincipal.InfraCcg2009.Models {
    
    public class UvwProcessoAcusado {
        public virtual int? IdProcesso { get; set; }
        public virtual int? Numero { get; set; }
        public virtual int? Ano { get; set; }
        public virtual string Portaria { get; set; }
        public virtual string Placa { get; set; }
        public virtual string Renavam { get; set; }
        public virtual string DataInstauracao { get; set; }
        public virtual string DataEncerramento { get; set; }
        public virtual string Historico { get; set; }
        public virtual string Presidente { get; set; }
        public virtual string Secretario { get; set; }
        public virtual string Membro { get; set; }
        public virtual string Municipio { get; set; }
        public virtual string Cpfcnpj { get; set; }
        public virtual string Renach { get; set; }
        public virtual string Nome { get; set; }
        public virtual int? IdTipoProcesso { get; set; }
        public virtual string TipoProcesso { get; set; }
        public virtual string TipoDocumento { get; set; }
        public virtual string Matricula { get; set; }
        public virtual string Punicao { get; set; }
        public virtual string ResumoPunicao { get; set; }
    }
}
