using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("###     SELECCIONE UNA OPCION  ###");
            Console.WriteLine("##################################");
            Console.WriteLine("# [0] -> Cerrar Aplicacion       #");
            Console.WriteLine("# [1] -> Dar Alta Cliente        #");
            Console.WriteLine("# [2] -> Ordenar Lista Clientes  #");
            Console.WriteLine("##################################");

            int seleccionUsu = Convert.ToInt32(Console.ReadLine());
           return seleccionUsu;



            



        }


    }
}
