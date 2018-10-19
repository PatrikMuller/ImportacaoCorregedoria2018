using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ModuloPrincipal.InfraCcg2009.Access;
//using ModuloPrincipal.InfraCcg2009.Models;

using ModuloPrincipal.InfraCcg2009.Negocio;
using ModuloPrincipal.InfraCcg2009.LinqCcg2009;

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

            NegocioAcusado negocio = new NegocioAcusado();

            List<Acusado> lista = negocio.Listar();


            Console.ReadKey();

        }
    }
}
