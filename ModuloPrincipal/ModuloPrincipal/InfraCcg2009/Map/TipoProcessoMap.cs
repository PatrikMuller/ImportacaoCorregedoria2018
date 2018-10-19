using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class TipoProcessoMap : ClassMapping<TipoProcesso> {
        
        public TipoProcessoMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdTipoProcesso, map => { map.Column("id_tipo_processo"); map.NotNullable(true); });
			Property(x => x.Nome);
			Property(x => x.Sigla);
            
            //Bag(x => x.Processo, colmap =>  { colmap.Key(x => x.Column("id_tipo_processo")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
