using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Presupuesto_G
{
    class bd
    {
       public static DataSet consultar(String query)
        {
            SqlConnection connection = new SqlConnection("server=192.168.1.181; database=Presupuesto ; user id=duban_adm; password=3ps1-sqlbd.*");
            DataSet ds = new DataSet();
            try
            {              
                connection.Open();
                SqlDataAdapter dp = new SqlDataAdapter(query, connection);
                dp.Fill(ds);
                connection.Close();
                return ds;
            }
            catch (Exception)
            {
                return ds;
            }
        }
    }
}
