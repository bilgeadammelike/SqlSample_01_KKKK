using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    public class ShipperDAL
    {
        List<ShipperDAO> shipperlist = null;
        public List<ShipperDAO> ShiperSelect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Shippers", conn);

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if(rdr.HasRows)
                {
                    shipperlist = new List<ShipperDAO>();
                    while (rdr.Read())
                    {
                        shipperlist.Add(new ShipperDAO()
                        {
                            CompanyName = rdr["CompanyName"].ToString(),
                            ID = rdr["ShipperID"].ToString(),
                            Phone = rdr["Phone"].ToString()
                        });
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            
            return shipperlist;
        }

        public int SihipperAdd(ShipperDAO added)
        {
            if (added == null)
            {
                throw new ArgumentNullException(nameof(added));
            }
            //Validate
            SqlTransaction tran;

            SqlConnection conn = new SqlConnection();            

            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            
            conn.Open();
            if(conn.State != System.Data.ConnectionState.Open)
            {
                conn.Close();
                return 0;
            }
            int donenDeger = 0;
            tran = conn.BeginTransaction();
            try
            {

                string strCommand = string.Format("insert into Shippers(CompanyName, Phone) values('{0}',{1})",
                  added.CompanyName, added.Phone);
               SqlCommand cmd = new SqlCommand(strCommand, conn);
                cmd.Transaction = tran;

                //SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                
            //mySqlCommand.CommandText = "INSERT INTO enroll(id,testString) VALUES( @id,@testString)";
                
            //mySqlCommand.Parameters.Add("@id", SqlDbType.NChar, 10);
            //    10
            //mySqlCommand.Parameters.Add("@testString", SqlDbType.VarChar, 50);
            //    11
            //mySqlCommand.Parameters["@id"].Value = 1;
            //    12
            //mySqlCommand.Parameters["@testString"].Value = "J4 Company";
            //    13
            //mySqlCommand.ExecuteNonQuery();



                donenDeger = cmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            conn.Close();

            return donenDeger;
        }

    }
}
