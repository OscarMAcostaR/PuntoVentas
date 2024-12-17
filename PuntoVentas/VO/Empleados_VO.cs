using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Empleados_VO
    {
        private int _id_empleado;
        private string _nombre;
        private string _puesto;
        private string _telefono;

        public int id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string puesto { get => _puesto; set => _puesto = value; }
        public string telefono { get => _telefono; set => _telefono = value; }

        public Empleados_VO()
        {
            _id_empleado = 0;
            _nombre = "";
            _puesto = "";
            _telefono = "";
        }

        public Empleados_VO(DataRow dr)
        {
            _id_empleado = int.Parse(dr["id_empleado"].ToString());
            _nombre = dr["nombre"].ToString();
            _puesto = dr["puesto"].ToString();
            _telefono = dr["telefono"].ToString();

        }
    }
}
