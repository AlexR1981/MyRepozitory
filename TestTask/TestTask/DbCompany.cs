using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TestTask
{
    public static class DbCompany
    {        
        /// <summary>
        /// Получение данных в виде DataTable 
        /// </summary>        
        /// <returns></returns>
        public static DataTable GetDataDB(string SqlText)
        {
            DataTable result = new DataTable();

            using (SQLiteCommand comm = DbConnection.GetNewCommandTestTask(SqlText))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(comm);                
                try
                {
                    da.Fill(result);
                }
                catch (Exception ex)
                {
                   Message.ShowExceptionMessage("Ошибка при получении данных!", ex);
                }
            }

            return result;
        }
    }
}
