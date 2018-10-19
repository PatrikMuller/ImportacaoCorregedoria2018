using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class CorregedorMap : ClassMapping<Corregedor> {
        
        public CorregedorMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.Idcorregedor, map => map.Generator(Generators.Identity));
			Property(x => x.Nome);
			Property(x => x.ImagePath);
			Property(x => x.Datainicio);
			Property(x => x.Datafinal);
			Property(x => x.Status);
			Property(x => x.Imagem);

            //Bag(x => x.Certidao, colmap =>  { colmap.Key(x => x.Column("idcorregedor")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
