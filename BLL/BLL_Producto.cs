using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Producto
    {
        public static string insert_Producto(Productos_VO producto)
        {
            return DAL_Productos.insert_Producto(producto);
        }
    }
}
