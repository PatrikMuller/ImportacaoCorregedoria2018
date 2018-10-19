using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class MunicipioMap : ClassMapping<Municipio> {
        
        public MunicipioMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdMunicipio, map => { map.Column("id_municipio"); map.NotNullable(true); });
			Property(x => x.Nome, map => map.NotNullable(true));
        }
    }
}
