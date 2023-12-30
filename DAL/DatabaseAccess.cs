using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // tạo chuỗi kết nối CSDL
    public static SqlConnection Connect()
    {
        string strcon = @"Data Source=DUC;Initial Catalog=Formdangnhap_demo;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);// khởi tạo connect
        return con;
    }
    public class DatabaseAccess { 
 
    }
}
