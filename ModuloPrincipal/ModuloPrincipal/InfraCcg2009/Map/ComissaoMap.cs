using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class ComissaoMap : ClassMapping<Comissao> {
        
        public ComissaoMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdComissao, map => { map.Column("id_comissao"); map.NotNullable(true); });
			Property(x => x.Nome);
			//Bag(x => x.IdComissao Origem, colmap =>  { colmap.Key(x => x.Column("id_comissao")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.IdComissao, colmap =>  { colmap.Key(x => x.Column("destino")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
