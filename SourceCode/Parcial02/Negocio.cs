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

        public Negocio(int n_idBusiness, string n_name, string n_descripcion)
        {
            idBusiness = n_idBusiness;
            name = n_name;
            descripcion = n_descripcion;
            
        }
    }
}