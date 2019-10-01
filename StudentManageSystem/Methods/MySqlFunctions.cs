using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace StudentManageSystem.Methods
{
    public class MySqlFunctions
    {
        private SqlConnection sqlConnection = null;
        public bool isconnected = false;
        public MySqlFunctions(HttpResponse response) {
            //string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            string connString = "data source=49.235.184.242,3306;initial catalog=mysql;user id=root;pwd=root";
            try {
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();
            }
            catch (Exception e) {
                response.Write("<script>alert('数据库链接失败')</script>");
                return;
            }
            isconnected = true;
            response.Write("<script>alert('数据库链接成功')</script>");
        }
    }
}