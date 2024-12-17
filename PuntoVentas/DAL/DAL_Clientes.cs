using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Clientes
    {
        public static List<Clientes_VO> Get_Clientes(params object[] parametros)
        {
            //creo una lista de objetox VO
            List<Clientes_VO> list = new List<Clientes_VO>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet ds_Clientes = metodos_datos.execute_DataSet("LeerClientebyID", parametros);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in ds_Clientes.Tables[0].Rows)
                {
                    list.Add(new Clientes_VO(dr));
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
