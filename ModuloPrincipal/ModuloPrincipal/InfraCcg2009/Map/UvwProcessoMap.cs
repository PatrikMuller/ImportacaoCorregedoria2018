using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class UvwProcessoMap : ClassMapping<UvwProcesso> {
        
        public UvwProcessoMap() {
			Table("uvw_Processo");
			Schema("dbo");
			Lazy(true);
			Property(x => x.Numero, map => map.NotNullable(true));
			Property(x => x.Ano, map => map.NotNullable(true));
			Property(x => x.TipoProcesso);
			Property(x => x.Municipio, map => map.NotNullable(true));
			Property(x => x.Portaria);
			Property(x => x.Placa);
			Property(x => x.Renavam);
			Property(x => x.IdTipoProcesso, map => { map.Column("id_tipo_processo"); map.NotNullable(true); });
			Property(x => x.IdProcesso, map => { map.Column("id_processo"); map.NotNullable(true); });
			Property(x => x.DataFato, map => map.Column("data_fato"));
			Property(x => x.IdMunicipio, map => { map.Column("id_municipio"); map.NotNullable(true); });
			Property(x => x.DataInstauracao, map => map.Column("data_instauracao"));
			Property(x => x.DataEncerramento, map => map.Column("data_encerramento"));
			Property(x => x.IdComissao, map => map.Column("id_comissao"));
			Property(x => x.NomeComissao, map => map.Column("nome_comissao"));
			Property(x => x.Historico);
			Property(x => x.Punicao);
			Property(x => x.Status);
        }
    }
}
