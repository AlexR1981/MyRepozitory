using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TestTask
{
    public static class Message
    {
        /// <summary>
        /// Отображение сообщения об исключении
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="exception">Исключение</param>
        static public void ShowExceptionMessage(string text, Exception exception)
        {
            MessageBox.Show(text + ": " + Environment.NewLine + exception.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
