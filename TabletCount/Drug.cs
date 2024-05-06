using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletCount
{
    internal class Drug
    {
        private string drugName;    // to implement Object-Oriented Porgramming, I make the fields private
        private int drugCount;

        public Drug(string name)
        {
            this.drugName = name;
            this.drugCount = 0;
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

        public int GetCount()
        {
            return this.drugCount;
        }
    }
}
