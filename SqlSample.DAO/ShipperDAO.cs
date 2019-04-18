using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAO
{
    /// <summary>
    /// Mutlaka Birşeyler Yaz
    /// </summary>
    public class ShipperDAO : BaseEntity
    {
        public string  CompanyName { get; set; }

        public string Phone { get; set; }
        
        public override string ToString()
        {
            return CompanyName;
        }

    }
}
