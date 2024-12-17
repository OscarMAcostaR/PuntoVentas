using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Ventas
    {
        public static List<Ventas_VO> Get_Ventas(params object[] parametros)
        {
            return DAL_Ventas.Get_Ventas(parametros);
        }
    }
}
