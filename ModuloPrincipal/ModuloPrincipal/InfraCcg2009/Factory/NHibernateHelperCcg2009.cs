//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using NHibernate;
//using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using System.Reflection;

//using NHibernate.Driver;
//using NHibernate.Bytecode;
//using NHibernate.Dialect;
//using NHibernate.Connection;
//using System.Collections;
//using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
//using System.Collections;

namespace ModuloPrincipal.InfraCcg2009.Factory
{
    public class NHibernateHelperCcg2009
    {

        private static ISessionFactory factory = CriaSessionFactory();

        public static ISessionFactory CriaSessionFactory()
        {

            //Casa
            //IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString("Server=localhost;Port=5432;Database=money_sic;User Id=postgres;Password=123456;"); 

            //Trabalho
            //IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString("Server=localhost;Port=5432;Database=money_sic;User Id=login_money;Password=123456;");

            IPersistenceConfigurer configDB = MsSqlConfiguration. MsSql2012.ConnectionString("Server=(local);Database=Ccg2009;User Id=userImportacao;Password=35456575; ");


            var configMap = Fluently.Configure().Database(configDB)
                //Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.PessoaFisicaMapping>());

                .Mappings(x => { x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()); })
                //.Mappings(m => m.FluentMappings.Add<CarrinhoMapping>())
                //.Mappings(_ => _.FluentMappings.AddFromAssemblyOf<Carrinho>())

                //ExposeConfiguration( y => new SchemaExport(y).Create(true, false));
                .ExposeConfiguration(y => new SchemaUpdate(y).Execute(true, true))
                .BuildConfiguration()
                .BuildSessionFactory();

            factory = configMap;

            return factory;
        }

        public static ISession AbreSessao()
        {
            return CriaSessionFactory().OpenSession();
        }

    }
}
