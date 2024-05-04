namespace TabletCount
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // to implement Object-Oriented Porgramming, I make the drugs private
        private Drug drug1 = new Drug("Acetaminophen");
        private Drug drug2 = new Drug("Oxycotin");
        private Drug drug3 = new Drug("Ibuprofen");
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
            drug1.increment();
            drugOneCount.Text = "count: " + drug1.getCount().ToString();
        }

        private void drugTwoIncre_Click(object sender, EventArgs e)
        {
            drug2.increment();
            drugTwoCount.Text = "count: " + drug2.getCount().ToString();
        }

        private void drugThreeIncre_Click(object sender, EventArgs e)
        {
            drug3.increment();
            drugThreeCount.Text = "count: " + drug3.getCount().ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            drug1.reset();
            drug2.reset();
            drug3.reset();
            drugOneCount.Text = "count: " + drug1.getCount().ToString();
            drugTwoCount.Text = "count: " + drug2.getCount().ToString();
            drugThreeCount.Text = "count: " + drug3.getCount().ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
