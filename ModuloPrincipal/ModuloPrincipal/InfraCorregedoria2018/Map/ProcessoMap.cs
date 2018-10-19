using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class ProcessoMap : ClassMapping<Processo> {
        
        public ProcessoMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdProcesso, map => map.Generator(Generators.Identity));
			Property(x => x.NumeroProcesso);
			Property(x => x.AnoProcesso);
			Property(x => x.DataInstauracao, map => map.NotNullable(true));
			Property(x => x.PortariaInstauracao, map => map.NotNullable(true));
			Property(x => x.Historico, map => map.NotNullable(true));
			Property(x => x.DataEncerramento);
			ManyToOne(x => x.TipoProcesso, map => { map.Column("idTipoProcesso"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Municipio, map => 
			{
				map.Column("idMunicipio");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			//Bag(x => x.ProcessoSindicado, colmap =>  { colmap.Key(x => x.Column("idProcesso")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.ProcessoTestemunha, colmap =>  { colmap.Key(x => x.Column("idProcesso")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
