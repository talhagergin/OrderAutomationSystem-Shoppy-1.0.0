using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace OrderAutomationSystem
{
    public class Connect
    {
        public static SQLiteConnection con = new SQLiteConnection(@"Data source=.\dataBase.db");
    }
}
