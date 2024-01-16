using Array06DMN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de preguntar al usuario los campos necesarios para comepletar los atributos
        /// Que compondran a un nuevo cliente
        /// <author>DMN - 16/01/2024</author>
        /// </summary>
        public void clienteAlta(List<ClienteDtos> listaAntigua);

        /// <summary>
        /// Metodo encargado de ordenar deforma descendente el campo edad de cada cliente
        /// <author>DMN - 16/01/2024</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void ordenarClientes(List<ClienteDtos> listaAntigua);


    }
}
