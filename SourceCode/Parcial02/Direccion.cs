namespace Parcial02
{
    public class Direccion
    {
        public int idAddress { get; set; }
        public int idUser { get; set; }
        public string address { get; set; }
       

        public Direccion() {}

        public Direccion(int d_idAddress, int d_idUser, string d_address)
        {
            idAddress = d_idAddress;
            idUser = d_idUser;
            address = d_address;
            
        }
    }
}