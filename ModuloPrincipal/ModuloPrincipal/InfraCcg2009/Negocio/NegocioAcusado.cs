using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModuloPrincipal.InfraCcg2009.LinqCcg2009;

namespace ModuloPrincipal.InfraCcg2009.Negocio
{
    public class NegocioAcusado
    {
                
        Ccg2009Conexao bd = new Ccg2009Conexao();
        
        public NegocioAcusado()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //método para listar
        public List<Acusado> Listar()
        {
                        
            List<Acusado> lista = bd.Acusado.ToList();

            return lista;
                        
        }
               

    }
}
