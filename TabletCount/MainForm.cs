using System;
using System.IO;

namespace TabletCount
{
    public partial class MainForm : Form
    {
        // to implement Object-Oriented Porgramming, I make the fields private
        private StreamWriter writer;
        private List<Drug> drugsList;
        private Button exitButton;
        private Button checkLog;
        private Button resetButton;
        public MainForm(List<Drug> drugs)
        {
            InitializeComponent();
            writer = new StreamWriter("DrugIncrementTest.log", false);
            drugsList = new List<Drug>();
            exitButton = new Button();
            checkLog = new Button();
            resetButton = new Button();

            this.InitLog();     // initialize the log file (eg, write the time and "SRART")

            for (int i = 0; i < drugs.Count; i++)
            {
                drugsList.Add(drugs[i]);
            }

        }

        //this method is to initialize a new log file
        private void InitLog()
        {
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
            this.writer.WriteLine(" START");
            this.writer.Close();
        }

        //In this method, we update the log file and increment of the count of one drug from the drug list
        private void IncreButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                writer = new StreamWriter("DrugIncrementTest.log", true);
                this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ");
                this.writer.Write(drugsList[button.TabIndex].GetName() + " " + drugsList[button.TabIndex].GetDrugCount().ToString() + " ");
                drugsList[button.TabIndex].Increment();
                this.writer.WriteLine(drugsList[button.TabIndex].GetDrugCount().ToString());
                drugsList[button.TabIndex].GetDrugCountLabel().Text = "Count: " + drugsList[button.TabIndex].GetDrugCount().ToString();
                this.writer.Close();
            }
            
        }

        //In this method, we update the log file and reset the counts of all drugs to be 0
        private void resetButton_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter("DrugIncrementTest.log", true);
            this.writer.Write($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} RESET ");
            for (int i = 0; i < drugsList.Count; i++)
            {
                this.writer.Write(drugsList[i].GetName() + " " + drugsList[i].GetDrugCount().ToString() + " 0 ");
                drugsList[i].Reset();
                drugsList[i].GetDrugCountLabel().Text = "Count: " + drugsList[i].GetDrugCount().ToString();
            }
            this.writer.Write("\n");
            this.writer.Close();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when we click "Check Log" button, a modal and seperate form displaying log content is opened
        private void checkLog_Click(object sender, EventArgs e)
        {
            LogForm myLogForm = new LogForm();
            myLogForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(800, 500);
            this.Text = "Tablet";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            for (int i = 0; i < drugsList.Count; i++)
            {
                //this block is to determine the location, tabindex and event of increment buttons for each drug
                drugsList[i].GetIncreButton().Text = "Increment";
                drugsList[i].GetIncreButton().Size = new Size(100, 40);
                drugsList[i].GetIncreButton().BackColor = Color.LightGray;
                drugsList[i].GetIncreButton().TextAlign = ContentAlignment.MiddleCenter;
                drugsList[i].GetIncreButton().Location = new Point(600, 50+80*i);
                drugsList[i].GetIncreButton().TabIndex = i;       // TabIndex has the index of the button, which is also the index of the drug
                drugsList[i].GetIncreButton().Click += new EventHandler(IncreButtonClick);
                this.Controls.Add(drugsList[i].GetIncreButton());

                //this block is to determine the location of labels for each drug name
                drugsList[i].GetDrugNameLabel().Size = new Size(150, 40);
                drugsList[i].GetDrugNameLabel().Text = drugsList[i].GetName();
                drugsList[i].GetDrugNameLabel().Location = new Point(100, 60+80*i);
                this.Controls.Add(drugsList[i].GetDrugNameLabel());

                //this block is to determine the location of labels for each drug count
                drugsList[i].GetDrugCountLabel().Size = new Size(150, 40);
                drugsList[i].GetDrugCountLabel().Text = "Count: " + drugsList[i].GetDrugCount().ToString();
                drugsList[i].GetDrugCountLabel().Location = new Point(350, 60 + 80 * i);                
                this.Controls.Add(drugsList[i].GetDrugCountLabel());

            }
            //this block is to add the reset button
            resetButton.Text = "Reset";
            resetButton.Font = new Font("Arial", 12, FontStyle.Bold);
            resetButton.Location = new Point(310, 40 + 60 * (drugsList.Count + 1));
            resetButton.BackColor = Color.LightBlue;
            resetButton.TextAlign = ContentAlignment.MiddleCenter;
            resetButton.Size = new Size(150, 40);
            resetButton.Click += new EventHandler(resetButton_Click);
            this.Controls.Add(resetButton);

            //this block is to add the button to check the log file
            checkLog.Text = "Check Log";
            checkLog.Font = new Font("Arial", 12, FontStyle.Bold);
            checkLog.Location = new Point(310, 40 + 60 * (drugsList.Count + 2));
            checkLog.BackColor = Color.LightBlue;
            checkLog.TextAlign = ContentAlignment.MiddleCenter;
            checkLog.Size = new Size(150, 40);
            checkLog.Click += new EventHandler(checkLog_Click);
            this.Controls.Add(checkLog);

            //this block is to add the exit button
            exitButton.Text = "Exit";
            exitButton.Font = new Font("Arial", 12, FontStyle.Bold);
            exitButton.Location = new Point(310, 40 + 60 * (drugsList.Count + 3));
            exitButton.BackColor = Color.LightBlue;
            exitButton.TextAlign = ContentAlignment.MiddleCenter;
            exitButton.Size = new Size(150, 40);
            exitButton.Click += new EventHandler(exitButton_Click);
            this.Controls.Add(exitButton);
        }
    }
}
