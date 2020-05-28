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

        public Orden()
        {
            idOrden = 0;
            createDate = new DateTime();
            idProduct = 0;
            idAddress = 0;   
        }

    }
}