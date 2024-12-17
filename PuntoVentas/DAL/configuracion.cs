using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class configuracion
    {
        //Cadena de Conexión
        //Data Source = nombre del servidor de BD
        // localhost
        // .
        // Nombre de mi instancia
        //Inital Catalog = nombre de la BD
        //Integrated Security = true (Credenciales de la máquina)
        //= false (Credenciales de acceso)
        //Se habilitan los campos de
        // User =;
        // Password =;

        static string _cadenaConexion = @"Data Source = DESKTOP-KD76I3Q\SQLEXPRESS; Initial Catalog = PuntoDeVenta; Integrated Security = true;";

        //Encapsulamiento
        public static string CadenaConexion
        {
            get
            {
                return _cadenaConexion;
            }
        }
    }
}
