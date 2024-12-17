using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Detalle_Venta
    {

        public static List<DetalleVenta_VO> Get_Detalle(params object[] parametros)
        {
            //creo una lista de objetox VO
            List<DetalleVenta_VO> list = new List<DetalleVenta_VO>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet ds_DetalleV = metodos_datos.execute_DataSet("SP_MostrarDetalleVentas", parametros);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in ds_DetalleV.Tables[0].Rows)
                {
                    list.Add(new DetalleVenta_VO(dr));
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
