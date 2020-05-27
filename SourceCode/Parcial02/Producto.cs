namespace Parcial02
{
    public class Producto
    {
        public int idProduct { get; set; }
        public int idBusiness { get; set; }
        public string name { get; set; }
       

        public Producto() {}

        public Producto(int p_idProduct, int p_idBusiness, string p_name)
        {
            idProduct = p_idProduct;
            idBusiness = p_idBusiness;
            name = p_name;
            
        }
    }
}