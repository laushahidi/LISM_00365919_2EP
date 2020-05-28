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
                dt = ConnectionDB.ExecuteQuery(string.Format("SELECT ad.idAddress, ad.address FROM ADDRESS ad, APPUSER us WHERE us.username = '{0}' ", u.username));

            }
            catch (Exception)
            {
                return null;
            }

            return dt;
        }
    }
}