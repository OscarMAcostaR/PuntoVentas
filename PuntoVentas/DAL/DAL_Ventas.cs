using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Ventas
    {
        public static List<Ventas_VO> Get_Ventas(params object[] parametros)
        {
            //creo una lista de objetox VO
            List<Ventas_VO> list = new List<Ventas_VO>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet ds_Ventas = metodos_datos.execute_DataSet("LeerVentabyId", parametros);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in ds_Ventas.Tables[0].Rows)
                {
                    list.Add(new Ventas_VO(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
