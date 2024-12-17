using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Clientes
    {
        public static List<Clientes_VO> Get_Clientes(params object[] parametros)
        {
            return DAL_Clientes.Get_Clientes(parametros);        }
    }
}
