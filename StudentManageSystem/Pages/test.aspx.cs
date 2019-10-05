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
            Teacher teacher = new Teacher();
            teacher.teacher_id = "1";
            teacher.change_str = "set teacher_age='60',teacher_sex='女'";
            /*teacher.teacher_age = "27";
            teacher.teacher_sex = "男";
            teacher.teacher_name = "小强";
            teacher.technical_title = "无";
            teacher.telephone = "1234567891";
            teacher.email = "sad465465@ss.com";*/
            if (teacher.Change()) {
                Label1.Text = "修改成功";
            }
            else {
                Label1.Text = "修改失败";
            }
        }
    }
}