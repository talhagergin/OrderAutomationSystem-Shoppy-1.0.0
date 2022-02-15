using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace OrderAutomationSystem
{
    public class Crud
    {
        static DataTable dt;
        /// <summary>
        /// Returns DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataTable</returns>
        public static DataTable List(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connect.con);
            da.Fill(dt);
            return dt;
        }
        //adding,removing and updating 
        public static bool ARU(string sql)
        {
            int verify = 0;
            
            SQLiteCommand cmd = new SQLiteCommand(sql, Connect.con);
                Connect.con.Open();

                verify = cmd.ExecuteNonQuery();
                Connect.con.Close();
                if (verify == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            
        }
        public static int Quantity(string sql)
        {
            int quantity = -1;
            
                SQLiteCommand cmd = new SQLiteCommand(sql, Connect.con);
                Connect.con.Open();
                int verify = cmd.ExecuteNonQuery();
                Connect.con.Close();

            
            return quantity;
            
        }
    }
}
