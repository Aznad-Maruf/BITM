using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        public double MaximumWeight { private set; get; }
        public double CurrentWeight { private set; get; }

        public Refrigerator(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
            this.CurrentWeight = 0;
        }

        public bool EnterNewItem(int noOfItems, double weightPerUnit)
        {
            if (this.CurrentWeight+noOfItems*weightPerUnit>this.MaximumWeight)
            {
                return false;
            }

            CurrentWeight += (noOfItems * weightPerUnit);
            return true;
        }

    }
}
