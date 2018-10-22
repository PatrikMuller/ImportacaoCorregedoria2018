using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModuloPrincipal.InfraCcg2009.LinqCcg2009;

namespace ModuloPrincipal.InfraCcg2009.Negocio
{
    public class NegocioCcg2009
    {

        Ccg2009Conexao db = new Ccg2009Conexao();

        public NegocioCcg2009()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //método para listar
        public List<Acusado> ListarAcusado()
        {

            return db.Acusado.ToList();

        }

        //método para listar
        public List<Testemunha> ListarTestemunha()
        {

            return db.Testemunha.ToList();

        }

        public List<Andamento> ListarAndamento()
        {

            return db.Andamento.ToList();

        }

        public List<Comissao> ListarComissao()
        {

            return db.Comissao.ToList();

        }

        public List<Denuncia> ListarDenuncia()
        {

            return db.Denuncia.ToList();

        }

        public List<Municipio> ListarMunicipio()
        {

            return db.Municipio.ToList();

        }

        public List<NadaConsta> ListarNadaConsta()
        {

            return db.NadaConsta.ToList();

        }

        public List<Processo> ListarProcesso()
        {

            return db.Processo.ToList();

        }

        public List<ProcessoAcusado> ListarProcessoAcusado()
        {

            return db.ProcessoAcusado.ToList();

        }

        public List<ProcessoTestemunha> ListarProcessoTestemunha()
        {

            return db.ProcessoTestemunha.ToList();

        }


    }
}
