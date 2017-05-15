using System.Data.SqlClient;

namespace VMRepo
{
    public static class Conn
    {
        
        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection("server=194.255.108.50;database=dbvidmedie;uid=vidmedie;pwd=eGBkOsZ3;MultipleActiveResultSets=True");
            return con;
        }

        public static SqlConnection CreateConnection()
        {
            var cn = GetCon();
            cn.Open();
            return cn;
        }
    }
}
