﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public static class ProductosConsulta
    {
        public static List<Producto> getLista()
        {
            string sql = "SELECT * FROM product";
           
            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Producto> lista = new List<Producto>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Producto prod = new Producto();
                prod.idProduct = Convert.ToInt32(fila[0].ToString());
                prod.idBusiness = Convert.ToInt32(fila[1].ToString());
                prod.name = fila[2].ToString();
                
                lista.Add(prod);
            }
            return lista;
        }
        
        public static void AgregarProducto(Producto p, Negocio b)
        {
            string sql = String.Format(
                "insert into product(idbusiness, name) " +
                "select bus.idbusiness, '{0}' from business bus where bus.name = '{1}' ", p.name, b.name);
                
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void eliminarProducto(string name)
                {
                    string sql = String.Format(
                        "delete from product where name = '{0}';",
                        name);
                            
                    ConnectionDB.ExecuteNonQuery(sql);
                }
    }
}