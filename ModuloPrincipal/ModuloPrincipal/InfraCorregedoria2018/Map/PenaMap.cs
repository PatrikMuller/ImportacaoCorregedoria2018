using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class PenaMap : ClassMapping<Pena> {
        
        public PenaMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdPena, map => map.Generator(Generators.Identity));
			Property(x => x.Punicao);
			Property(x => x.DataPublicacao);
			Property(x => x.Portaria);
			Property(x => x.Ativo);
			ManyToOne(x => x.ProcessoSindicado, map => 
			{
				map.Column("idProcessoAcusado");
				map.PropertyRef("IdProcessoAcusado");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

        }
    }
}
