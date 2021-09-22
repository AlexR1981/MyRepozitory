using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
            SqlText.FillListSelect();//Заполняем список запросов
            GetData(SqlText.ListSelect[0]);//Отображаем данные о сотрудниках
        }

        private void radioButtonTask1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTask1.Checked)
            {
                GetData(SqlText.ListSelect[0]);
            }
        }

        private void radioButtonTask2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTask2.Checked)
            {                
                GetData(SqlText.ListSelect[1]);
            }
        }

        private void radioButtonTask3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTask3.Checked)
            {                
                GetData(SqlText.ListSelect[2]);
            }
        }

        private void radioButtonTask4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTask4.Checked)
            {                
                GetData(SqlText.ListSelect[3]);
            }
        }

        private void radioButtonTask5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTask5.Checked)
            {                
                GetData(SqlText.ListSelect[4]);
            }
        }
        private void GetData(string TextSql) 
        {
            DataTable _dtCompany = DbCompany.GetDataDB(TextSql);            
            bsCompany.DataSource = _dtCompany;            
            dataGridViewCompany.DataSource = bsCompany; 
        }

        
    }
}
