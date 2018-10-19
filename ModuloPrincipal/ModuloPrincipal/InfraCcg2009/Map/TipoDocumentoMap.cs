using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class TipoDocumentoMap : ClassMapping<TipoDocumento> {
        
        public TipoDocumentoMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdTipoDocumento, map => { map.Column("id_tipo_documento"); map.NotNullable(true); });
			Property(x => x.Nome, map => map.NotNullable(true));

            //Bag(x => x.Processo, colmap =>  { colmap.Key(x => x.Column("id_tipo_documento")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
