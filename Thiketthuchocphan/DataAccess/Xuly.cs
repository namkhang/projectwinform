using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class Xuly
    {
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Winform\NGUYENDANGNAMKHANG_3216_CS414FIS_KETTHUCHOCPHAN\Thiketthuchocphan\GUI\quanlynhansu1.mdf;Integrated Security=True");
        }
        public DataTable Gettable(string sql)
        {
            SqlConnection connect = getconnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection connect = getconnect();
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connect.Close();
        }
    }
}
