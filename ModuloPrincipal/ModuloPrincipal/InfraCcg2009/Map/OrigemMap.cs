using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class OrigemMap : ClassMapping<Origem> {
        
        public OrigemMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdProcesso, map => map.Column("id_processo"));
			Property(x => x.IdComissao, map => map.Column("id_comissao"));
        }
    }
}
