using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Proveedor_VO
    {
        private int _id_proveedor;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _email;

        public int Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }

        public Proveedor_VO()
        {
            _id_proveedor = 0;
            _nombre = "";
            _direccion = "";
            _telefono = "";
            _email = "";
        }

        public Proveedor_VO(DataRow dr)
        {
            _id_proveedor = int.Parse(dr["id_proveedor"].ToString());
            _nombre = dr["nombre"].ToString();
            _direccion = dr["direccion "].ToString();
            _telefono = dr["telefono"].ToString();
            _email = dr["email"].ToString();
        }
    }
}
