using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLinq
{
    class Conectar
    {
        LinqEntities BD = new LinqEntities();
        

        //Realizar una consulta simple
        public personales  ConsultaSimple(int id)
        {
            var resultado = (from x in BD.personales
          
                            select x).FirstOrDefault ();

            return resultado;
           
        }
    }
}
