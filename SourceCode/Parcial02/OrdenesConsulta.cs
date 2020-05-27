using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public static class OrdenesConsulta
    {
        public static List<Orden> getLista()
        {
            string sql = "SELECT * FROM apporder";
           
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Orden> lista = new List<Orden>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Orden ord = new Orden();
                ord.idOrden = Convert.ToInt32(fila[0].ToString());
                ord.createDate = DateTime.Parse(fila[1].ToString());
                ord.idProduct = Convert.ToInt32(fila[2].ToString());
                ord.idAddress = Convert.ToInt32(fila[3].ToString());
                
                lista.Add(ord);
            }
            return lista;
        }
        
        public static DataTable adminVerPedidos()
        {
           DataTable dt = null;
            try
            {
                dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                               "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                                               "AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser;");
                
            }
            catch (Exception)
            {
                return null;
            }

            return dt;
        }
    }
}