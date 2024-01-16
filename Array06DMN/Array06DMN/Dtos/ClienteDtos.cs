using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Dtos
{
    internal class ClienteDtos
    {

        long idCliente;
        string nombreCliente = "aaaaaa";
        string apellidosCliente = "aaaaaa";
        string nombreCompletoCliente = "aaaaaa";
        int edad = 111111;



        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }



        public ClienteDtos(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.edad = edad;
        }



        public ClienteDtos() { }


        override

        public string ToString()
        {


            string todo =
                "Nombre: " + this.nombreCliente + this.apellidosCliente +
                " | Edad Cliente: " + this.edad;

            return todo;



        }



    }
}
