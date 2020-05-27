namespace Parcial02
{
    public class Usuario
    {
        public int idUser { get; set; }
        public string nombreCompleto { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public bool admin { get; set; }
        
        public Usuario()
        {
            idUser = 0;
            nombreCompleto = "";
            usuario = "";
            contrasena = "";
            admin = false;
        }
    }
}