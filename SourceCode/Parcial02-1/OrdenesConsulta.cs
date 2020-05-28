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
        
        public static void CrearOrden(string time, Producto pro, Direccion ad)
        {
            string sql = string.Format("INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                       " VALUES('{0}', {1}, {2});", time, pro.idProduct, ad.idAddress);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void eliminarOrden(int orden)
        {
            string sql = String.Format(
                "DELETE FROM APPORDER WHERE idOrder = {0};",
                orden);
                  
            ConnectionDB.ExecuteNonQuery(sql);
        }
        public static DataTable verMisOrdenes(Usuario us)
        {
            DataTable dt = null;
            try
            {
                dt = ConnectionDB.ExecuteQuery(string.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                             " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                                                             " AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {0};",
                    us.idUser));
                
            }
            catch (Exception)
            {
                return null;
            }

            return dt;
            
        }
    }
}