using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;

using VO;

namespace PuntoVentas.SW_PuntodeVentas
{
    /// <summary>
    /// Descripción breve de WebServicePuntodeVentas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePuntodeVentas : System.Web.Services.WebService
    {


        /// //////////////////////////////////////SESION MOSTRAR//////////////////////////////////////////////7///
        /// ////////////////////////////////////// DETALLE VENTA /////////////////////////////////////////////7///

        [WebMethod]
        public List<DetalleVenta_VO> Get_Detalle(params object[] parametros)
        {
            return BLL_DetVentas.Get_Detalle(parametros);
        }


        /// ////////////////////////////////////// EMPLEADO //////////////////////////////////////////////7///


        [WebMethod]
        public List<Empleados_VO> Get_Empleados(params object[] parametros)
        {
            return BLL_Empleados.Get_Empleados(parametros);
        }

        /////////////////////////////////////// CLIENTES //////////////////////////////////////////////////////////

        [WebMethod]
        public List<Clientes_VO> Get_Clientes(params object[] parametros)
        {
            return BLL_Clientes.Get_Clientes(parametros);
        }

        ///////////////////////////////////// VENTAS ///////////////////////////////////////////////////////////
        
        [WebMethod]
        public  List<Ventas_VO> Get_Ventas(params object[] parametros)
        {
            return BLL_Ventas.Get_Ventas(parametros);
        }

        ///////////////////////////////ELIMINAR////////////////////////////////////////////////
        ///////////////////////////////EMPLEADOS////////////////////////////////////////////////

        [WebMethod]
        public  string Eliminar_Empleados(int id)
        {
            return BLL_Empleados.Eliminar_Empleados(id);
        }


        ///////////////////////////////INSERTAR////////////////////////////////////////////////
        ///////////////////////////////PRODUCTO////////////////////////////////////////////////
        [WebMethod]
        public string insert_Producto(Productos_VO producto)
        {
            return BLL_Producto.insert_Producto(producto);
        }
    }

    
}
