using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class DenunciaMap : ClassMapping<Denuncia> {
        
        public DenunciaMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdDenuncia, map => { map.Column("id_denuncia"); map.NotNullable(true); });
			Property(x => x.Denunciante);
			Property(x => x.Denunciado);
			Property(x => x.LocalFato, map => map.Column("local_fato"));
			Property(x => x.DataFato, map => map.Column("data_fato"));
			Property(x => x.HoraFato, map => map.Column("hora_fato"));
			Property(x => x.Data);
			Property(x => x.Hora);
			Property(x => x.Historico);
        }
    }
}
