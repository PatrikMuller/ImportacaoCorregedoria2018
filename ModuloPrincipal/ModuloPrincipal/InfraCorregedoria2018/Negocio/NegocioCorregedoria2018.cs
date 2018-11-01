using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModuloPrincipal.InfraCorregedoria2018.LinqCorregedoria2018;

namespace ModuloPrincipal.InfraCorregedoria2018.Negocio
{
    public class NegocioCorregedoria2018
    {

        Corregedoria2018Entities db = new Corregedoria2018Entities();

        public NegocioCorregedoria2018()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //método para gravar
        public void GravarCertidao(Certidao certidao)
        {

            db.Certidao.Add(certidao);

        }

        //método para gravar
        public void GravarPessoa(Pessoa pessoa)
        {

            db.Pessoa.Add(pessoa);
            db.SaveChanges();
            
        }

        //método para gravar
        public void GravarProcesso(Processo processo)
        {

            db.Processo.Add(processo);

        }
        public List<Processo> ListarProcesso(int idOrigem)
        {

            return db.Processo.Where(o => o.idProcessoOrigem == idOrigem).ToList();

        }

        //método para gravar
        public void GravarProcessoSindicado(ProcessoSindicado processoSindicado)
        {

            db.ProcessoSindicado.Add(processoSindicado);
            db.SaveChanges();

        }
        public List<ProcessoSindicado> ListarProcessoSindicado(int idProcesso)
        {

            return db.ProcessoSindicado.Where(o => o.idProcesso == idProcesso).ToList();

        }

        //método para gravar
        public void GravarProcessoTestemunha(ProcessoTestemunha processoTestemunha)
        {

            db.ProcessoTestemunha.Add(processoTestemunha);
            db.SaveChanges();

        }

        //método para gravar
        public void GravarPena(Pena pena)
        {

            db.Pena.Add(pena);
            db.SaveChanges();

        }

    }
}
