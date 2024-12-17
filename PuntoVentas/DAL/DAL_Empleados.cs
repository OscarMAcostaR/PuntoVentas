using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Empleados
    {

        public static List<Empleados_VO> Get_Empleados(params object[] parametros)
        {
            //creo una lista de objetox VO
            List<Empleados_VO> list = new List<Empleados_VO>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet ds_Empleados = metodos_datos.execute_DataSet("SP_MostrarEmpleados", parametros);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in ds_Empleados.Tables[0].Rows)
                {
                    list.Add(new Empleados_VO(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string Eliminar_Empleados(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("EliminarEmpleadobyId",
                    "@@p_id_empleado", id
                    );

                if (respuesta != 0)
                {
                    salida = "Ruta eliminada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }


    }

}
