using System;
using System.IO;

namespace TabletCount
{
    public partial class MainForm : Form
    {
        // to implement Object-Oriented Porgramming, I make the drugs private
        private StreamWriter writer;
        private Drug drug1;
        private Drug drug2;
        private Drug drug3;

        public MainForm()
        {
            InitializeComponent();
            writer = new StreamWriter("DrugIncrementTest.log", false);
            drug1 = new Drug("Acetaminophen");
            drug2 = new Drug("Oxycotin");
            drug3 = new Drug("Ibuprofen");
            this.initLog();
        }

        //initialize a new log file
        private void initLog()
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
            this.writer.WriteLine(" START");
            this.writer.Flush();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //connect data to labels
            drugOneLabel.Text = drug1.getName();
            drugTwoLabel.Text = drug2.getName();
            drugThreeLabel.Text = drug3.getName();

            drugOneCount.Text = "count: " + drug1.getCount().ToString();
            drugTwoCount.Text = "count: " + drug2.getCount().ToString();
            drugThreeCount.Text = "count: " + drug3.getCount().ToString();
        }

        private void drugOneIncre_Click(object sender, EventArgs e)
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug1.getName() + " " + drug1.getCount().ToString() + " ");
            drug1.increment();
            this.writer.WriteLine(drug1.getCount().ToString());
            drugOneCount.Text = "count: " + drug1.getCount().ToString();
            this.writer.Flush();
        }

        private void drugTwoIncre_Click(object sender, EventArgs e)
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug2.getName() + " " + drug2.getCount().ToString() + " ");
            drug2.increment();
            this.writer.WriteLine(drug2.getCount().ToString());
            drugTwoCount.Text = "count: " + drug2.getCount().ToString();
            this.writer.Flush();
        }

        private void drugThreeIncre_Click(object sender, EventArgs e)
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug3.getName() + " " + drug3.getCount().ToString() + " ");
            drug3.increment();
            this.writer.WriteLine(drug3.getCount().ToString());
            drugThreeCount.Text = "count: " + drug3.getCount().ToString();
            this.writer.Flush();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} RESET ");
            this.writer.Write(drug1.getName() + " " + drug1.getCount().ToString() + " 0 ");
            this.writer.Write(drug2.getName() + " " + drug2.getCount().ToString() + " 0 ");
            this.writer.WriteLine(drug3.getName() + " " + drug3.getCount().ToString() + " 0");
            drug1.reset();
            drug2.reset();
            drug3.reset();
            drugOneCount.Text = "count: " + drug1.getCount().ToString();
            drugTwoCount.Text = "count: " + drug2.getCount().ToString();
            drugThreeCount.Text = "count: " + drug3.getCount().ToString();
            this.writer.Flush();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            this.writer.Close();
            LogForm myLogForm = new LogForm();
            myLogForm.ShowDialog();
            this.Close();
        }
    }
}
