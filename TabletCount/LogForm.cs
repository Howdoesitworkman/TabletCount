using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TabletCount
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            try
            {
                string logContent = File.ReadAllText("DrugIncrementTest.log");
                richTextBoxLog.Text = logContent;
            }
            catch (Exception exp){ 
                Console.WriteLine(exp.Message);
            }
        }
    }
}
