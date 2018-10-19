using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class MunicipioMap : ClassMapping<Municipio> {
        
        public MunicipioMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdMunicipio, map => map.Generator(Generators.Identity));
			Property(x => x.Nome);

            //Bag(x => x.Endereco, colmap =>  { colmap.Key(x => x.Column("idMunicipio")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.Processo, colmap =>  { colmap.Key(x => x.Column("idMunicipio")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
