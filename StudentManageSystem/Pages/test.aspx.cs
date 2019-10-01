using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentManageSystem.Methods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManageSystem.Pages
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlFunctions mySql = new MySqlFunctions(Response);
            if (mySql.isconnected)
            {
                string str = mySql.ExecSql("select * from 专业");
                var array = MySqlFunctions.string_to_array(str);
                var jobj = MySqlFunctions.string_to_jobj(array[0].ToString());
                Label1.Text = jobj["专业名称"].ToString();
                mySql.SqlClose();

            }
        }
    }
}