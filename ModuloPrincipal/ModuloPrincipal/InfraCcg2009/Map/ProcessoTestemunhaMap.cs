using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class ProcessoTestemunhaMap : ClassMapping<ProcessoTestemunha> {
        
        public ProcessoTestemunhaMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdProcesso, map => { map.Column("id_processo"); map.NotNullable(true); });
			Property(x => x.IdTestemunha, map => { map.Column("id_testemunha"); map.NotNullable(true); });
        }
    }
}
