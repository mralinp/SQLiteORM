using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteORMTest
{
    [TestFixture]
    public class DBTest
    {
        [Test]
        [TestCase("testdb.db")]
        [TestCase("./db/testdb.db")]
        public void ConnectionTest(string dbName) {
            SQLiteORM.DB.Connect(dbName);
        }

        [Test]
        [TestCase("testdb.db", "CREATE TABLE test(id PRIMARY_KEY, user_name TEXT, password TEXT, created_at DATE_TIME);")]
        public void ExecuteCMD(string dbName, string cmd) {
            SQLiteORM.DB.Connect(dbName);
            SQLiteORM.DB.ExecuteCMD(cmd);
        }

    }
}
