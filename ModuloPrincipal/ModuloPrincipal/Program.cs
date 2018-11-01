using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ModuloPrincipal.InfraCcg2009.Access;
//using ModuloPrincipal.InfraCcg2009.Models;

using ModuloPrincipal.InfraCcg2009.Negocio;
using ModuloPrincipal.InfraCcg2009.LinqCcg2009;

using ModuloPrincipal.InfraCorregedoria2018.Negocio;
using ModuloPrincipal.InfraCorregedoria2018.LinqCorregedoria2018;

namespace ModuloPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ccg2009Entities dbCcg2009 = new Ccg2009Entities();

            //AcusadoAccess acusadoAccess = new AcusadoAccess();

            //List<Acusado> lista = acusadoAccess.Lista();

            //Acusado obj = acusadoAccess.Ler(34);


            NegocioCcg2009 origem = new NegocioCcg2009();
            NegocioCorregedoria2018 destino = new NegocioCorregedoria2018();


            List<Acusado> acusados = origem.ListarAcusado();
            List<Testemunha> testemunhas = origem.ListarTestemunha();


            Console.ReadKey();


            //foreach (var obj in acusados)
            //{

            //    Pessoa pessoa = new Pessoa();

            //    pessoa.tipoPessoa = "F";
            //    pessoa.nome = obj.nome;
            //    pessoa.cpfcnpj = obj.cpfcnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            //    pessoa.rgie = obj.rg.Trim().Replace(" ", "").Replace(".", "").Replace("-", "");

            //    //REPLACE(REPLACE(REPLACE(cpfcnpj, '.', ''), '-', ''), '/', '') AS cpfcnpjTratado,                 
            //    //RTRIM(LTRIM(replace(REPLACE(REPLACE(rg, ' ', ''), '.', ''), '-', ''))) AS rgTratado,
            //    //pessoa.telefone = "";
            //    pessoa.matricula = obj.matricula;

            //    Endereco endereco = new Endereco();

            //    endereco.logradouro = obj.endereco;
            //    endereco.bairro = obj.bairro;
            //    endereco.idMunicipio = Convert.ToInt32(1);
            //    endereco.cep = obj.cep;

            //    pessoa.Endereco = endereco;

            //    //Verificar se tem o mesmo cpf
            //    destino.GravarPessoa(pessoa);

            //    List<InfraCcg2009.LinqCcg2009.ProcessoAcusado> processoAcusados = origem.ListarProcessoAcusado(obj.id_acusado);

            //    foreach (var pa in processoAcusados)
            //    {
            //        ProcessoSindicado processoSindicado = new ProcessoSindicado();
            //        processoSindicado.idProcesso = pa.id_processo;
            //        processoSindicado.idPessoa = pessoa.idPessoa;

            //        destino.GravarProcessoSindicado(processoSindicado);
            //    }

            //    //List<InfraCcg2009.LinqCcg2009.ProcessoTestemunha> processoTestemunhas = origem.ListarProcessoTestemunha();

            //    //foreach (var pt in processoTestemunhas)
            //    //{
            //    //    InfraCorregedoria2018.LinqCorregedoria2018.ProcessoTestemunha Testemunha = new InfraCorregedoria2018.LinqCorregedoria2018.ProcessoTestemunha();
            //    //    Testemunha.idProcesso = pt.id_processo;
            //    //    Testemunha.idPessoa = pessoa.idPessoa;

            //    //    destino.GravarProcessoTestemunha(Testemunha);
            //    //}

            //}


            List<InfraCcg2009.LinqCcg2009.Processo> processos = origem.ListarProcesso();

            foreach (var p in processos)
            {

                //Pegar o Processo de destino pelo ID da Origem
                List<InfraCorregedoria2018.LinqCorregedoria2018.Processo> processosDestino = destino.ListarProcesso(p.id_processo);

                foreach (var pDestino in processosDestino)
                {
                    //Pegar todos os sindicados de destino
                    List<InfraCorregedoria2018.LinqCorregedoria2018.ProcessoSindicado> processoSindicadosDestino = destino.ListarProcessoSindicado(pDestino.idProcesso);

                    //Incluir a pena para cada Sindicado
                    foreach (var psDestino in processoSindicadosDestino)
                    {
                        Pena pena = new Pena();

                        pena.idProcessoAcusado = psDestino.idProcessoAcusado;
                        pena.portaria = p.portaria_encerramento;
                        pena.dataPublicacao = p.data_encerramento;
                        pena.punicao = p.punicao;
                        pena.ativo = "A";
                                                
                        destino.GravarPena(pena);
                    }

                }

            }

                        
            Console.ReadKey();


        }
    }
}
