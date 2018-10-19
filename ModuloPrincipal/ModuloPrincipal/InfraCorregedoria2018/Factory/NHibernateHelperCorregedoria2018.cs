using NHibernate;
using FluentNHibernate.Cfg;
using System.Reflection;

using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;


namespace ModuloPrincipal.InfraCorregedoria2018.Factory
{
    public class NHibernateHelperCorregedoria2018
    {

        private static ISessionFactory factory = CriaSessionFactory();

        public static ISessionFactory CriaSessionFactory()
        {
                        
            IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2012.ConnectionString("Server=(local);Database=Corregedoria2018;User Id=userImportacao;Password=35456575;");


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
