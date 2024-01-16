   
using Array06DMN.Dtos;
using Array06DMN.Servicios;

namespace Array06DMN.Controladores;


class Program
{
    /// <summary>
    /// Clase principal de la aplicacion. La cual contendra al metodo main
    /// <author>DMN - 16/01/2024</author>
    /// </summary>
    /// <param name="args"></param>

    static void Main(string[] args)
    {
        /// <summary>
        /// Metodo principal por el cual la aplicacion se lanzara
        /// <author>DMN - 16/01/2024</author>
        /// </summary>
        /// <param name="args"></param>

        List<ClienteDtos> listaClientes = new List<ClienteDtos>();

        MenuInterfaz me = new MenuImplementacion();
        

        OperativaInterfaz op = new OperativaImplementacion();

       
        bool cerrarMenu = false;

        while (!cerrarMenu)
        {
            int valorIntro = me.menuPrincipal();

            switch (valorIntro)
            {

                case 0:
                    Console.WriteLine("[INFO] - Cerrar Aplicacion");
                    cerrarMenu = true;
                    break;

                case 1:
                    Console.WriteLine("[INFO] - Dar Alta Cliente");
                    op.clienteAlta(listaClientes);
                    break;

                case 2:
                    Console.WriteLine("[INFO] - Ordenar Lista Clientes");
                    op.ordenarClientes(listaClientes);

                   
                    
                    
                    foreach (ClienteDtos cliente in listaClientes)
                    {

                        Console.WriteLine(cliente.ToString());


                    }
                    
                    
                    break;

                default:
                    Console.WriteLine("[ATENCION] - Seleccion no Valida");
                    break;



            }



        }






    }

   
}