using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class UvwProcessoAcusadoMap : ClassMapping<UvwProcessoAcusado> {
        
        public UvwProcessoAcusadoMap() {
			Table("uvw_processo_acusado");
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdProcesso, map => map.Column("id_processo"));
			Property(x => x.Numero);
			Property(x => x.Ano);
			Property(x => x.Portaria);
			Property(x => x.Placa);
			Property(x => x.Renavam);
			Property(x => x.DataInstauracao);
			Property(x => x.DataEncerramento);
			Property(x => x.Historico);
			Property(x => x.Presidente);
			Property(x => x.Secretario);
			Property(x => x.Membro);
			Property(x => x.Municipio, map => map.NotNullable(true));
			Property(x => x.Cpfcnpj);
			Property(x => x.Renach);
			Property(x => x.Nome);
			Property(x => x.IdTipoProcesso, map => map.Column("id_tipo_processo"));
			Property(x => x.TipoProcesso);
			Property(x => x.TipoDocumento, map => map.NotNullable(true));
			Property(x => x.Matricula);
			Property(x => x.Punicao);
			Property(x => x.ResumoPunicao, map => map.Column("resumo_punicao"));
        }
    }
}
