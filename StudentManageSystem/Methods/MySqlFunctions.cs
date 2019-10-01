using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace StudentManageSystem.Methods
{
    public class MySqlFunctions
    {
        private MySqlConnection sqlConnection = null;
        private MySqlCommand sqlCmd=null;
        public bool isconnected = false;


        public MySqlFunctions(HttpResponse response)
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            try
            {
                sqlConnection = new MySqlConnection(str);
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                response.Write("<script>alert('数据库链接失败')</script>");
                return;
            }
            isconnected = true;
        }
        public bool SqlClose() {
            if (isconnected) {
                sqlConnection.Close();
                isconnected = false;
                return true;
            }
            return false;
        }
        private MySqlDataReader sqlRead(string sql_str) {
            MySqlDataReader dataReader=null;
            sqlCmd= new MySqlCommand(sql_str,sqlConnection);
            try
            {
                dataReader=sqlCmd.ExecuteReader();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return dataReader;
        }
        private static string DataReaderToJson(MySqlDataReader dataReader)
        {
            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("[");
            while (dataReader.Read())
            {
                jsonString.Append("{");
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Type type = dataReader.GetFieldType(i);
                    string strKey = dataReader.GetName(i);
                    string strValue = dataReader[i].ToString();
                    jsonString.Append("\"" + strKey + "\":");
                    strValue = String.Format(strValue, type);
                    //datetime不能出现为空的情况,所以将其转换成字符串来进行处理。
                    //需要加""的
                    if (type == typeof(string) || type == typeof(DateTime))
                    {
                        if (i <= dataReader.FieldCount - 1)
                        {

                            jsonString.Append("\"" + strValue + "\",");
                        }
                        else
                        {
                            jsonString.Append(strValue);
                        }
                    }
                    //不需要加""的
                    else
                    {
                        if (i <= dataReader.FieldCount - 1)
                        {
                            jsonString.Append("" + strValue + ",");
                        }
                        else
                        {
                            jsonString.Append(strValue);
                        }
                    }
                }

                jsonString.Append("},");
            }
            dataReader.Close();
            jsonString.Remove(jsonString.Length - 3, 3);
            jsonString.Append("}");
            jsonString.Append("]");
            return jsonString.ToString();
        }
        public string sqlReadTeacherData() {
            string sql_str = "select * from 教师";
            MySqlDataReader dataReader = sqlRead(sql_str);
            if (dataReader != null) return DataReaderToJson(dataReader);
            else return "sql查询出错";
        }
        public string ExecSql(string sql_string) {
            MySqlDataReader dataReader = sqlRead(sql_string);
            if(dataReader!=null) return DataReaderToJson(dataReader);
            else return "sql查询出错";
        }
        public static JArray string_to_array(string str) {
            JArray jArray=null;
            try
            {
                jArray=JArray.Parse(str);
            }
            catch (Exception e) {
                return null;
            }
            return jArray;
        }
        public static JObject string_to_jobj(string str) {
            JObject jObject = null;
            try
            {
                jObject = (JObject)JsonConvert.DeserializeObject(str);
            }
            catch (Exception e) {
                return null;
            }
            return jObject;
        }

    }

}