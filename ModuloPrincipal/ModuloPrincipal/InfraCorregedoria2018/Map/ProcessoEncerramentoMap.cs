using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class ProcessoEncerramentoMap : ClassMapping<ProcessoEncerramento> {
        
        public ProcessoEncerramentoMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdProcessoEncerramento, map => map.NotNullable(true));
			Property(x => x.DataEncerrrametno);
        }
    }
}
