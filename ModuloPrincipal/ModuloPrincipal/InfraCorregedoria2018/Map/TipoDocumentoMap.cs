using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class TipoDocumentoMap : ClassMapping<TipoDocumento> {
        
        public TipoDocumentoMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdTipoDoc, map => map.Generator(Generators.Assigned));
			Property(x => x.Nome);
        }
    }
}
