using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public static class NegociosConsulta
    {
        public static List<Negocio> getLista()
        {
            string sql = "select * from business";
           
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Negocio> lista = new List<Negocio>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Negocio business = new Negocio();
                business.idBusiness = Convert.ToInt32(fila[0].ToString());
                business.name = fila[1].ToString();
                business.descripcion = fila[2].ToString();
                
                lista.Add(business);
            }
            return lista;
        }
        public static void agregarNegocio(string name, string description)
        {
            string sql = String.Format(
                "insert into business(name, description) " +
                "values('{0}', '{1}');",
                name, description);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void eliminarNegocio(string name)
        {
            string sql = String.Format(
                "delete from business where name = '{0}';",
                name);
                    
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static List<Negocio> getLista2()
        {
            string sql = String.Format("SELECT b.name AS 'Negocio', sum(cp.cant) AS 'Total pedidos' " +
            " FROM BUSINESS b, (SELECT p.idBusiness, p.name, count(ap.idProduct) AS 'cant' " +
            " FROM PRODUCT p, APPORDER ap WHERE p.idProduct = ap.idProduct GROUP BY p.idProduct " +
            " ORDER BY p.name ASC) AS cpp WHERE b.idBusiness = cp.idBusinesss GROUP BY b.idBusiness;");
            
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Negocio> lista = new List<Negocio>();
            foreach (DataRow fila in dt.Rows)
            {
                Negocio business = new Negocio();
                business.name = fila[0].ToString();
                business.idBusiness = Convert.ToInt32(fila[1].ToString());
                
                
                lista.Add(business);
            }
            return lista;
        }
    }
}