using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLonNhom14
{
    internal class DataAccess
    {
        static string stringConnection = "Data Source=DOTHANHTUNG\\SQL;Initial Catalog=QLSV;Integrated Security=True";
        static SqlConnection connection = null;
        static public DataTable SqlExecute(string sqlQuery)
        {
            connection = new SqlConnection(stringConnection);
            if (sqlQuery.Split(' ')[0].ToUpper() == "SELECT")
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                return dataTable;
                datagrid
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return null;
            }
        }
        static public bool InsertIntoSV(TextBox maSV, TextBox hoTen, DateTimePicker ngaySinh, string gioiTinh, ComboBox queQuan, ComboBox Lop) 
        {
            try
            {
                DataAccess.SqlExecute("INSERT INTO SV VALUES('" + maSV.Text +"', N'" + hoTen.Text + "', N'" + gioiTinh + "', '" + ngaySinh.Value.Date.ToString() + "', N'" + queQuan.Text + "', '" + Lop.Text + "');");
                return true;
            }
            catch(Exception){
                return false;
            }
        }
    }
}
