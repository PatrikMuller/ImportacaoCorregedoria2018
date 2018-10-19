using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using ModuloPrincipal.InfraCorregedoria2018.Models;


namespace ModuloPrincipal.InfraCorregedoria2018.Map {
    
    
    public class EnderecoMap : ClassMapping<Endereco> {
        
        public EnderecoMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.IdEndereco, map => map.Generator(Generators.Identity));
			Property(x => x.Logradouro);
			Property(x => x.Bairro);
			Property(x => x.Cep);
			ManyToOne(x => x.Municipio, map => 
			{
				map.Column("idMunicipio");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			//Bag(x => x.Pessoa, colmap =>  { colmap.Key(x => x.Column("idEndereco")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
