﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletCount
{
    internal class Drug
    {
        private string drugName;    // to implement Object-Oriented Porgramming, I make the properties private
        private int drugCount;

        public Drug(string name)
        {
            this.drugName = name;
            this.drugCount = 0;
        }

        public void increment()
        {
            this.drugCount++;
        }

        public void reset()
        {
            this.drugCount = 0;
        }

        public string getName()
        {
            return this.drugName;
        }

        public int getCount()
        {
            return this.drugCount;
        }
    }
}