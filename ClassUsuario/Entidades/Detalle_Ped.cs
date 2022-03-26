using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUsuario.Entidades
{
    public class Detalle_Ped
    {
       public int IdDetalles_P { get; set; }
       public int IdPedidos { get; set; }
       public string Codigo { get; set; }
       public string Descripcion { get; set; }
       public int Cantidad { get; set; }

       public decimal Precio { get; set; } 

       public decimal Total { get; set; }

        public Detalle_Ped()
        {

        }

        public Detalle_Ped(int idDetalles_P, int idPedidos, string codigo, string descripcion, int cantidad, decimal precio, decimal total)
        {
            IdDetalles_P = idDetalles_P;
            IdPedidos = idPedidos;
            Codigo = codigo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
