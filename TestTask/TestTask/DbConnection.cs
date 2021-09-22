using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace TestTask
{
    class DbConnection
    {        
        /// <summary>
        /// Получение экземпляра соединения с БД
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection GetNewConnectionMyTask()
        {
            SQLiteConnection conn = new SQLiteConnection(TestTask.Properties.Settings.Default.ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Message.ShowExceptionMessage("Ошибка при установлении соединения с БД!", ex);
            }
            return conn;
        }

        /// <summary>
        /// создание запроса к БД
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public static SQLiteCommand GetNewCommandTestTask(string commandText)
        {
            SQLiteConnection conn = DbConnection.GetNewConnectionMyTask();
            SQLiteCommand comm = new SQLiteCommand(commandText, conn);            
            return comm;
        }
    }
}
