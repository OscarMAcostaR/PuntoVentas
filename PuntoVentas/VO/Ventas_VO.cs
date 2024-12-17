using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Ventas_VO
    {
        private int _id_venta;
        private int _id_cliente;
        private int _id_empleado;
        private string _fecha_venta;
        private double _total;

        public int Id_venta { get => _id_venta; set => _id_venta = value; }
        public int Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public int Id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public string Fecha_venta { get => _fecha_venta; set => _fecha_venta = value; }
        public double Total { get => _total; set => _total = value; }

        public Ventas_VO()
        {
            _id_venta = 0;
            _id_cliente = 0;
            _id_empleado = 0;
            _fecha_venta = "";
            _total = 0;
        }

        public Ventas_VO(DataRow dr)
        {
            _id_venta = int.Parse(dr["id_venta"].ToString());
            _id_cliente = int.Parse(dr["id_cliente"].ToString());
            _id_empleado = int.Parse(dr["id_empleado"].ToString());
            _fecha_venta = DateTime.Parse(dr["fecha_venta"].ToString()).ToShortDateString();
            _total = double.Parse(dr["total"].ToString());
        }
    }
}