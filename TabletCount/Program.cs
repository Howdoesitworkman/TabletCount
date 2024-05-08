namespace TabletCount
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Here, we create a list of drugs where every drug we want resides
            List<Drug> myDrugList = new List<Drug>();

            myDrugList.Add(new Drug("Acetaminophen"));
            myDrugList.Add(new Drug("Oxycotin"));
            myDrugList.Add(new Drug("Ibuprofen"));

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(myDrugList));      // the list of drugs is passed in the constructor of MainForm
        }
    }
}