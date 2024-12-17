using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Empleados
    {
        public static List<Empleados_VO> Get_Empleados(params object[] parametros)
        {
            return DAL_Empleados.Get_Empleados(parametros);
        }

        public static string Eliminar_Empleados(int id)
        {
            return DAL_Empleados.Eliminar_Empleados(id);
        }
    }
}
