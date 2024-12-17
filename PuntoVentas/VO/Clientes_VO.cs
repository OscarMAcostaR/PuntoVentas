using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Clientes_VO
    {
        private int _id_cliente;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _email;

        public int Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }


        public Clientes_VO()
        {
            _id_cliente = 0;
            _nombre = "";
            _direccion = "";
            _telefono = "";
            _email = "";
        }

        public Clientes_VO(DataRow dr)
        {
            _id_cliente = int.Parse(dr["id_cliente"].ToString());
            _nombre = dr["nombre"].ToString();
            _direccion = dr["direccion"].ToString();
            _telefono = dr["telefono"].ToString();
            _email = dr["email"].ToString();
        }
    }
}
