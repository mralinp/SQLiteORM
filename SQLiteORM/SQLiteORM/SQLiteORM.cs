using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteORM
{
    public class DB
    {
        private static DB s_instance;

        private DB(string dbName) { 
            throw new NotImplementedException();
        }

        public static void Connect(string dbName)
        {
            throw new NotImplementedException();
        }

        public static void Disconnect()
        {
            throw new NotImplementedException();
        }

        public static SQLQuery ExecuteCMD(string cmd)
        {
            throw new NotImplementedException();
        }
    }
}
