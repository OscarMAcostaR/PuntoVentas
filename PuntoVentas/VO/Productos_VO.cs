using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Productos_VO
    {

        private int _id_producto;
        private string _nombre;
        private double _precio;
        private int _stock;
        private int _id_proveedor;

        public int Id_producto { get => _id_producto; set => _id_producto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }


        public Productos_VO()
        {
            _id_producto = 0;
            _nombre = "";
            _precio = 0;
            _stock = 0;
            _id_proveedor = 0;
        }

        public Productos_VO(DataRow dr)
        {
            _id_producto = int.Parse(dr["id_producto"].ToString());
            _nombre = dr["nombre"].ToString();
            _precio = double.Parse(dr["precio"].ToString());
            _stock = int.Parse(dr["stock"].ToString());
            _id_proveedor = int.Parse(dr["id_proveedor"].ToString());
        }
    }
}
