using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSample.DAO;

namespace SqlSample.DAL
{
    class ProductsDAL : IService<ProductsDAO>
    {
        public int Delete(object ID, bool isHardDelete)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductsDAO inserted)
        {
            throw new NotImplementedException();
        }

        public List<ProductsDAO> Select()
        {
            List<ProductsDAO> productList = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Products order by ProductID asc", conn);

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    productList = new List<ProductsDAO>();
                    while (rdr.Read())
                    {
                        productList.Add(new ProductsDAO()
                        {
                            ID = rdr["ProductID"],
                            CategoryID = (int)rdr["CategoryID"],
                            Discontinued = (bool)rdr["Discontinued"],
                            ProductName = (string)rdr["ProductName"],
                            QuantityPerUnit = (string)rdr["QuantityPerUnit"],
                            ReorderLevel = (Int16)rdr["ReorderLevel"],
                            SupplierID = (int)rdr["SupplierID"],
                            UnitPrice = (decimal)rdr["UnitPrice"],
                            UnitsInStock = (Int16)rdr["UnitsInStock"],
                            UnitsOnOrder = (Int16)rdr["UnitsOnOrder"]
                        });
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return productList;
        }

        public ProductsDAO SelectByID(object ID)
        {
            throw new NotImplementedException();
        }

        public ProductsDAO SelectByName(string ID)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductsDAO updated)
        {
            throw new NotImplementedException();
        }
    }
}
