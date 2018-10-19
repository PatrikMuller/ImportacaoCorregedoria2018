using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;

using NHibernate.Mapping.ByCode;

//using FluentNHibernate.Mapping;
using ModuloPrincipal.InfraCcg2009.Models;


namespace ModuloPrincipal.InfraCcg2009.Map {
    
    public class AcusadoMap : ClassMapping<Acusado> {
        
        public AcusadoMap() {

            //Schema("dbo");
            //Lazy(true);
            Property(x => x.IdAcusado, map => { map.Column("id_acusado"); map.NotNullable(true); });
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
            Property(x => x.Matricula);
            Property(x => x.PessoaTipo, map => map.Column("pessoa_tipo"));

            //Id(o => o.IdAcusado).GeneratedBy.Identity();
            ////Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            //Map(x => x.Nome);
            //Map(x => x.Cpfcnpj);
            //Map(x => x.Rg);
            //Map(x => x.Cnh);
            //Map(x => x.Renach);
            //Map(x => x.DataCadastro);
            //Map(x => x.Endereco);
            //Map(x => x.Bairro);
            //Map(x => x.Municipio);
            //Map(x => x.Uf);
            //Map(x => x.Cep);
            //Map(x => x.Fone);
            //Map(x => x.Email);
            //Map(x => x.Matricula);
            //Map(x => x.PessoaTipo);

            //Id(o => o.Id).GeneratedBy.Sequence("Fabricante_Id_Seq");
            //Map(o => o.Descricao);

        }
    }
}
