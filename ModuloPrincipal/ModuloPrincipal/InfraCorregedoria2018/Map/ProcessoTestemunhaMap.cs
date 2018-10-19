using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class ProcessoTestemunhaMap : ClassMapping<ProcessoTestemunha> {
        
        public ProcessoTestemunhaMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdProcessoTestemunha, map => map.Generator(Generators.Assigned));
			ManyToOne(x => x.Processo, map => 
			{
				map.Column("idProcesso");
				map.PropertyRef("IdProcesso");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Pessoa, map => 
			{
				map.Column("idPessoa");
				map.PropertyRef("IdPessoa");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

        }
    }
}
