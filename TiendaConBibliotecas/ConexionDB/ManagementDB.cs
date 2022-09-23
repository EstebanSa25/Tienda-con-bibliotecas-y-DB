using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class ManagementDB
    {
        Conexion _conexionDB = new Conexion();
        public bool insertar(Tienda tienda)
        {
            int i = 0;
           
                return _conexionDB.EjecutarComando($"insert into Tabla2 values({tienda.NumPedido},'{tienda.Descripcion}','{tienda.Precio}','{tienda.TotalConIVA}')");

        }
    }//classs 
    }

