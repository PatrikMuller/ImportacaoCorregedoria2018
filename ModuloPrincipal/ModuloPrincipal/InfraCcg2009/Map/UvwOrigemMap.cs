using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class UvwOrigemMap : ClassMapping<UvwOrigem> {
        
        public UvwOrigemMap() {
			Table("uvw_origem");
			Schema("dbo");
			Lazy(true);
			Property(x => x.DataEnvio, map => map.Column("data_envio"));
			Property(x => x.Origem);
			Property(x => x.UsuarioEnvio, map => map.Column("usuario_envio"));
			Property(x => x.Destino);
			Property(x => x.DataAceite, map => map.Column("data_aceite"));
			Property(x => x.PessoaAceite, map => map.Column("pessoa_aceite"));
			Property(x => x.Obs);
			Property(x => x.IdTramitacao, map => { map.Column("id_tramitacao"); map.NotNullable(true); });
			Property(x => x.IdProcesso, map => { map.Column("id_processo"); map.NotNullable(true); });
			Property(x => x.Numero, map => map.NotNullable(true));
			Property(x => x.Ano, map => map.NotNullable(true));
			Property(x => x.Tipo);
			Property(x => x.IdDestino, map => map.Column("id_destino"));
			Property(x => x.Receptor);
			Property(x => x.Status);
        }
    }
}
