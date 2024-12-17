using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Productos
    {
        public static string insert_Producto(Productos_VO producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("CrearProducto",
                    "@p_nombre", producto.Nombre,
                    "@p_precio", producto.Precio,
                    "@p_stock", producto.Stock,
                    "@p_id_proveedor", producto.Id_proveedor
                    );

                if (respuesta != 0)
                {
                    salida = "Producto registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
