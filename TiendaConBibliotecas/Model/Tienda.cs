using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tienda
    {
        public int NumPedido { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public float TotalConIVA { get; set; }
        public Tienda()
        {
            NumPedido = 0;
            Descripcion = "";
            Precio = 0;
            TotalConIVA = 0;
        }
        public float CalculacionIVA(float Precio)
        {
            return (float)(Precio * 0.13);
        }
        public void ExtraerDatos()
        {
            Console.WriteLine("Digite el numero de pedido");
            NumPedido = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la descripcion del pedido");
            Descripcion = Console.ReadLine();
            Console.WriteLine("Digite el monto sin impuestos");
            Precio = float.Parse(Console.ReadLine());
            TotalConIVA = (float)(CalculacionIVA(Precio) + Precio);
        }
    }//clase

    
}
