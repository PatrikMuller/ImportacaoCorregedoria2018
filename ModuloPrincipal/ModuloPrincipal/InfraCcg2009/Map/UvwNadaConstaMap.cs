using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class UvwNadaConstaMap : ClassMapping<UvwNadaConsta> {
        
        public UvwNadaConstaMap() {
			Table("uvw_nada_consta");
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdNadaConsta, map => { map.Column("id_nada_consta"); map.NotNullable(true); });
			Property(x => x.Data);
			Property(x => x.Nome);
			Property(x => x.Tipo);
			Property(x => x.NumeroDocumento, map => map.Column("numero_documento"));
			Property(x => x.NumeroOcorrencias, map => map.Column("numero_ocorrencias"));
			Property(x => x.Servidor);
			Property(x => x.Ano);
			Property(x => x.Numero);
			Property(x => x.IdTipoDocumento, map => map.Column("id_tipo_documento"));
			Property(x => x.DocumentoSolicitacao, map => map.Column("documento_solicitacao"));
			Property(x => x.DataConsulta, map => map.Column("data_consulta"));
			Property(x => x.Motivo);
        }
    }
}
