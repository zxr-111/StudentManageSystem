using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManageSystem.Methods
{
    public abstract class DBoperation
    {
        public MySqlFunctions MySql;
        public DBoperation() {
            MySql = new MySqlFunctions();
        }
        public abstract bool Add();
        public abstract bool Delete();
        public abstract string Inquire();
        public abstract bool Change();
        ~DBoperation() {
            MySql.SqlClose();
        }
    }
}