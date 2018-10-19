using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class TipoProcessoMap : ClassMapping<TipoProcesso> {
        
        public TipoProcessoMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdTipoProcesso, map => map.Generator(Generators.Assigned));
			Property(x => x.Nome);
			Property(x => x.Sigla);

            //Bag(x => x.Processo, colmap =>  { colmap.Key(x => x.Column("idTipoProcesso")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
