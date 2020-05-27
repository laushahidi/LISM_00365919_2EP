using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public static class UsuariosConsulta
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from appuser";
           
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Usuario user = new Usuario();
                user.idUser = Convert.ToInt32(fila[0].ToString());
                user.fullname = fila[1].ToString();
                user.username = fila[2].ToString();
                user.password = fila[3].ToString();
                user.userType = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(user);
            }
            return lista;
        }
        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update appuser set password ='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
    }
}