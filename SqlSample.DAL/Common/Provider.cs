using SqlSample.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    class Provider
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public object Value { get; set; }

        public Provider (string cmdText, CmdTypeEnum eCmd, string context = "server=.;Database=NORTHWND;uid=sa;pwd=123")
        {
            conn = new SqlConnection();
            conn.ConnectionString = context;

            cmd = new SqlCommand(cmdText, conn);

            if(false == CheckConnection())
            {
                Value = false;
                return;
            }

            switch (eCmd)
            {
                case CmdTypeEnum.E_INSERT:

                    Value = cmd.ExecuteNonQuery();

                    break;
                case CmdTypeEnum.E_UPDATE:

                    Value = cmd.ExecuteNonQuery();

                    break;
                case CmdTypeEnum.E_DELETE:

                    Value = cmd.ExecuteNonQuery();

                    break;
                case CmdTypeEnum.E_SELECT:

                    Value = cmd.ExecuteScalar();

                    break;
                case CmdTypeEnum.E_SELECT_OBJECT:

                    Value = cmd.ExecuteScalar();

                    break;
            }
        }

        private bool CheckConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }

            return (conn.State == System.Data.ConnectionState.Open);
        }
    }
}

