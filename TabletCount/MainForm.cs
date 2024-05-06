using System;
using System.IO;

namespace TabletCount
{
    public partial class MainForm : Form
    {
        // to implement Object-Oriented Porgramming, I make the fields private
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
            this.InitLog();     // initialize the log file (eg, write the time and "SRART") 
        }

        //this method is to initialize a new log file
        private void InitLog()
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
            this.writer.WriteLine(" START");
            this.writer.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //assign the info of each drug to its corresponding label
            drugOneLabel.Text = drug1.GetName();
            drugTwoLabel.Text = drug2.GetName();
            drugThreeLabel.Text = drug3.GetName();
            drugOneCount.Text = "count: " + drug1.GetCount().ToString();
            drugTwoCount.Text = "count: " + drug2.GetCount().ToString();
            drugThreeCount.Text = "count: " + drug3.GetCount().ToString();
        }

        //In this method, we update the log file and increment of the count of drug1
        private void drugOneIncre_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter("DrugIncrementTest.log", true);
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug1.GetName() + " " + drug1.GetCount().ToString() + " ");
            drug1.Increment();
            this.writer.WriteLine(drug1.GetCount().ToString());
            drugOneCount.Text = "count: " + drug1.GetCount().ToString();
            this.writer.Close();
        }

        //In this method, we update the log file and increment of the count of drug2
        private void drugTwoIncre_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter("DrugIncrementTest.log", true);
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug2.GetName() + " " + drug2.GetCount().ToString() + " ");
            drug2.Increment();
            this.writer.WriteLine(drug2.GetCount().ToString());
            drugTwoCount.Text = "count: " + drug2.GetCount().ToString();
            this.writer.Close();
        }

        //In this method, we update the log file and increment of the count of drug3
        private void drugThreeIncre_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter("DrugIncrementTest.log", true);
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
            this.writer.Write(drug3.GetName() + " " + drug3.GetCount().ToString() + " ");
            drug3.Increment();
            this.writer.WriteLine(drug3.GetCount().ToString());
            drugThreeCount.Text = "count: " + drug3.GetCount().ToString();
            this.writer.Close();
        }

        //In this method, we update the log file and reset the counts of all drugs to be 0
        private void resetButton_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter("DrugIncrementTest.log", true);
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} RESET ");
            this.writer.Write(drug1.GetName() + " " + drug1.GetCount().ToString() + " 0 ");
            this.writer.Write(drug2.GetName() + " " + drug2.GetCount().ToString() + " 0 ");
            this.writer.WriteLine(drug3.GetName() + " " + drug3.GetCount().ToString() + " 0");
            drug1.Reset();
            drug2.Reset();
            drug3.Reset();
            drugOneCount.Text = "count: " + drug1.GetCount().ToString();
            drugTwoCount.Text = "count: " + drug2.GetCount().ToString();
            drugThreeCount.Text = "count: " + drug3.GetCount().ToString();
            this.writer.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when we click "Check Log" button, a modal and seperate form displaying log content is opened
        private void logButton_Click(object sender, EventArgs e)
        {
            LogForm myLogForm = new LogForm();
            myLogForm.ShowDialog();
        }

       
    }
}
