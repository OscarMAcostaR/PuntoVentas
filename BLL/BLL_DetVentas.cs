using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_DetVentas
    {
        public static List<DetalleVenta_VO> Get_Detalle(params object[] parametros)
        {
            return DAL_Detalle_Venta.Get_Detalle(parametros);
        }
    }
}
