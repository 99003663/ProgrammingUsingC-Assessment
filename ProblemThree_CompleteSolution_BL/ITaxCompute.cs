using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    interface ITaxCompute
    {
        double TaxOnTotalBill();
    }
    class Tax:ITaxCompute
    {
        public double TotalBillValue { get; set; }
        public double TaxOnTotalBill()
        {
            TotalBillValue = TotalBillValue + (0.07);
            return TotalBillValue;
        }
    }
}
