using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public class Adapter:ITarget
    {
        // different databases
        MySQL mysql;
        SQLite sqlite;
        Firebase firebase;
        MSSQL mssql;

        public Adapter(MySQL mysql, SQLite sqlite, Firebase firebase, MSSQL mssql)
        {
            this.mysql = mysql;
            this.sqlite = sqlite;
            this.firebase = firebase;
            this.mssql = mssql;
        }

        public void TM1()
        {
            mysql.enterTM1();
        }

        public void TM2()
        {
            sqlite.enterTM2();
        }

        public void TM3()
        {
            firebase.enterTM3();
        }

        public void TM4()
        {
            mssql.enterTM4();
        }
    }
}
