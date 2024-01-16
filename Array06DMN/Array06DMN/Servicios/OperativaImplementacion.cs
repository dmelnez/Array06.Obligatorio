using Array06DMN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

      public void clienteAlta(List<ClienteDtos> listaAntigua)
        {
            ClienteDtos clienteNuevo = new ClienteDtos();

            Console.WriteLine("ID Cliente: ");
            clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Nombre: ");
            clienteNuevo.NombreCliente = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            clienteNuevo.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Edad: ");
            clienteNuevo.Edad = Convert.ToInt32(Console.ReadLine());

            listaAntigua.Add(clienteNuevo);
            



        }
        


        public void ordenarClientes(List<ClienteDtos> listaAntigua)
        {
            
        
            if(listaAntigua.Count >= 3) { 
         
         

                for (int i = 0; i < listaAntigua.Count - 1; i++)
                {
                    for (int j = 0; j < listaAntigua.Count - 1 - i; j++)
                    {
                        if (listaAntigua[j].Edad < listaAntigua[j + 1].Edad)
                        {
                            ClienteDtos aux = listaAntigua[j];
                            listaAntigua[j] = listaAntigua[j + 1];
                            listaAntigua[j + 1] = aux;
                        }
                    }
                }
            }


            else
            {
                Console.WriteLine("#########################################");
                Console.WriteLine("# Debe de haber un minimo de 3 usuarios #");
                Console.WriteLine("#########################################");

            }



        }

    }
}
