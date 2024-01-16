using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menu principal de opciones al usuario.
        /// Recogera el valor introducido por el mismo, y lo devolvera al metodo main
        /// 
        /// <author>DMN - 16/01/2024</author>
        /// </summary>
        /// <returns>int seleccionUsu</returns>
        public int menuPrincipal();
    }
}
