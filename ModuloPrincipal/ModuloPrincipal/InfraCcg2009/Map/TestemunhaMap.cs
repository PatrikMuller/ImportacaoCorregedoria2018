using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    
    public class TestemunhaMap : ClassMapping<Testemunha> {
        
        public TestemunhaMap() {
			Schema("dbo");
			Lazy(true);
			Property(x => x.IdTestemunha, map => { map.Column("id_testemunha"); map.NotNullable(true); });
			Property(x => x.Nome);
			Property(x => x.Cpfcnpj);
			Property(x => x.Rg);
			Property(x => x.Cnh);
			Property(x => x.Renach);
			Property(x => x.DataCadastro, map => map.Column("data_cadastro"));
			Property(x => x.Endereco);
			Property(x => x.Bairro);
			Property(x => x.Municipio);
			Property(x => x.Uf);
			Property(x => x.Cep);
			Property(x => x.Fone);
			Property(x => x.Email);
        }
    }
}
