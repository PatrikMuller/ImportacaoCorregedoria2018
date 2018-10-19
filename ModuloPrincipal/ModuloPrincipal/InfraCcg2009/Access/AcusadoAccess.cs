using System.Collections.Generic;
using System.Linq;

using ModuloPrincipal.InfraCcg2009.Factory;
using ModuloPrincipal.InfraCcg2009.Models;
using NHibernate;


namespace ModuloPrincipal.InfraCcg2009.Access
{
    public class AcusadoAccess
    {

        public int Novo(Acusado obj)
        {
            using (ISession session = NHibernateHelperCcg2009.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(obj);

                tx.Commit();
                return obj.IdAcusado;
            }
        }

        public int Gravar(Acusado obj)
        {
            using (ISession session = NHibernateHelperCcg2009.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.IdAcusado;
            }
        }

        public Acusado Ler(int id)
        {
            using (ISession session = NHibernateHelperCcg2009.AbreSessao())
            {
                return session.Get<Acusado>(id);
            }
        }

        public void Remove(Acusado obj)
        {
            using (ISession session = NHibernateHelperCcg2009.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public List<Acusado> Lista()
        {
            using (ISession session = NHibernateHelperCcg2009.AbreSessao())
            {
                return session.Query<Acusado>().OrderBy(o => o.IdAcusado).ToList();
            }
        }

    }
}
