using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DetalleVenta_VO
    {
        private int _id_detalle;
        private int _id_venta;
        private int _id_producto;
        private int _cantidad;
        private double _subtotal;

        public int Id_detalle { get => _id_detalle; set => _id_detalle = value; }
        public int Id_venta { get => _id_venta; set => _id_venta = value; }
        public int Id_producto { get => _id_producto; set => _id_producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Subtotal { get => _subtotal; set => _subtotal = value; }

        public DetalleVenta_VO()
        {
            _id_detalle = 0;
            _id_venta = 0;
            _id_producto = 0;
            _cantidad = 0;
            _subtotal = 0;
        }
        public DetalleVenta_VO(DataRow dr)
        {
            _id_detalle = int.Parse(dr["id_detalle"].ToString());
            _id_venta = int.Parse(dr["id_venta"].ToString());
            _id_producto = int.Parse(dr["id_producto"].ToString());
            _cantidad = int.Parse(dr["cantidad"].ToString());
            _subtotal = double.Parse(dr["subtotal"].ToString());
        }
    }
}
