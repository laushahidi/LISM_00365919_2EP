using System;

namespace Parcial02
{
    public class Negocio
    {
        public int idBusiness { get; set; }
        public string name { get; set; }
        public string descripcion { get; set; }
        

        public Negocio() 
        {
            idBusiness = 0;
            name = "";
            descripcion = "";
        }

        
    }
}