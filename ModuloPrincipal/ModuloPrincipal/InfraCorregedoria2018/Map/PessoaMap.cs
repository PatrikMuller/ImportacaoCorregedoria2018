using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class PessoaMap : ClassMapping<Pessoa> {
        
        public PessoaMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdPessoa, map => map.Generator(Generators.Identity));
			Property(x => x.TipoPessoa);
			Property(x => x.Nome);
			Property(x => x.Cpfcnpj);
			Property(x => x.Rgie);
			Property(x => x.Telefone);
			Property(x => x.Matricula);
			ManyToOne(x => x.Endereco, map => 
			{
				map.Column("idEndereco");
				map.PropertyRef("IdEndereco");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			//Bag(x => x.ProcessoSindicado, colmap =>  { colmap.Key(x => x.Column("idPessoa")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			//Bag(x => x.ProcessoTestemunha, colmap =>  { colmap.Key(x => x.Column("idPessoa")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
