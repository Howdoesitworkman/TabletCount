using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletCount
{
    public class Drug
    {
        private string drugName;    // to implement Object-Oriented Porgramming, I make the fields private
        private int drugCount;
        private Button increDrugButton;
        private Label drugCountLabel;
        private Label drugNameLabel;

        public Drug(string name)
        {
            this.drugName = name;
            this.drugCount = 0;
            this.increDrugButton = new Button();
            this.drugCountLabel = new Label();
            this.drugNameLabel = new Label();
        }

        public void Increment()
        {
            this.drugCount++;
        }

        public void Reset()
        {
            this.drugCount = 0;
        }

        public string GetName()
        {
            return this.drugName;
        }
        public int GetDrugCount()
        {
            return this.drugCount;
        }

        public Button GetIncreButton()
        {
            return increDrugButton;
        }

        public Label GetDrugNameLabel()
        {
            return drugNameLabel;
        }

        public Label GetDrugCountLabel()
        {
            return drugCountLabel;
        }

    }
}
