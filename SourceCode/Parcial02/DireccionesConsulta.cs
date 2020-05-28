using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public static class DireccionesConsulta
    {
        public static List<Direccion> getLista()
        {
            string sql = "select * from address";
           
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Direccion> lista = new List<Direccion>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Direccion address = new Direccion();
                address.idAddress = Convert.ToInt32(fila[0].ToString());
                address.idUser = Convert.ToInt32(fila[1].ToString());
                address.address = fila[2].ToString();
                
                lista.Add(address);
            }
            return lista;
        }
        
        public static DataTable userVerDirecciones(Usuario u)
        {
            DataTable dt = null;
            try
            {
                dt = ConnectionDB.ExecuteQuery(string.Format("SELECT ad.idAddress, ad.idUser, ad.address FROM ADDRESS ad, APPUSER us " + 
                "WHERE us.username = '{0}' and ad.idUser = us.idUser ", u.username));

            }
            catch (Exception)
            {
                return null;
            }

            return dt;
        }
        
        public static void agregarDireccion(string address, string name)
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS(idUser, address) select us.idUser, '{0}'" +
                "from appuser us where us.username = '{1}';",
                address, name);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void eliminarDireccion(string address)
        {
            string sql = String.Format(
                "delete from address where address = '{0}';",
                address);
                    
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void ActualizarDireccion(string old, string newD)
        {
            string sql = String.Format(
                "update address set address = '{0}' WHERE address = '{1}';",
                newD, old);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}