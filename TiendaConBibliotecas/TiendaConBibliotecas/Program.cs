using ConexionDB;
using Model;

namespace TiendaConBibliotecas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementDB _managementDB = new ManagementDB();
            ManagementDB _managementDB2 = new ManagementDB();
            Tienda tienda1=new Tienda();
            Tienda tienda2 = new Tienda();
            tienda1.ExtraerDatos();
            
            bool estado = _managementDB.insertar(tienda1);
            bool estado2 = _managementDB2.insertar(tienda1);

        }
    }
}