using System;
using System.Globalization;

namespace Parcial02
{
    public class Orden
    {
        public int idOrden { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }
        

        public Orden() {}

        public Orden(int o_idOrden, string o_createDate, int o_idProduct, int o_idAddress)
        {
            idOrden = o_idOrden;
            createDate = DateTime.ParseExact(o_createDate, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            idProduct = o_idProduct;
            idAddress = o_idAddress;
            
        }
    }
}