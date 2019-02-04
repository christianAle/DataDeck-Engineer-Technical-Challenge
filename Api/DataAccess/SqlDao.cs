using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace DataAccess
{
    public class SqlDao
    {
       private const string CONNECTION_STRING = @"Data Source=C:\Users\Familia Rodriguez\Downloads\jrdd.db; 
           Version=3; FailIfMissing=True; Foreign Keys=True;";

        private static SqlDao instance;

        private SqlDao()
        {

        }

        public static SqlDao GetInstance()
        {
            if (instance == null)
                instance = new SqlDao();

            return instance;
        }


        public  List<Dictionary<string, object>> GetData(string sql)
        {
            
            var lstResult = new List<Dictionary<string, object>>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                   

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var dict = new Dictionary<string, object>();
                                    for (var lp = 0; lp < reader.FieldCount; lp++)
                                    {
                                        dict.Add(reader.GetName(lp), reader.GetValue(lp));
                                    }
                                    
                                    lstResult.Add(dict);
                                }

                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
               
            }
            return lstResult;
        }



    }
}
