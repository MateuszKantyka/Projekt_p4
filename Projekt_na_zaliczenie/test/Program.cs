using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=sklep.db");
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Users";
            SQLiteDataReader sdr = command.ExecuteReader();
        
            conn.Close();
        }
    }
}
