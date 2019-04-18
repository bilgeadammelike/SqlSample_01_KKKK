using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    public class CategoryDAL : IService<CategoryDAO>
    {
        public int Delete(object ID, bool isHardDelete)
        {
            throw new NotImplementedException();
        }

        public int Insert(CategoryDAO inserted)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDAO> Select()
        {
            List<CategoryDAO> shipperlist = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Categories", conn);

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    shipperlist = new List<CategoryDAO>();
                    while (rdr.Read())
                    {
                        shipperlist.Add(new CategoryDAO()
                        {
                            CategoryName = rdr["CategoryName"].ToString(),
                            Description = rdr["Description"].ToString(),
                            Picture = (byte[])rdr["Picture"]
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

            return null;
        }

        public CategoryDAO SelectByID(object ID)
        {
            throw new NotImplementedException();
        }

        public int Update(CategoryDAO updated)
        {
            throw new NotImplementedException();
        }
    }
}
