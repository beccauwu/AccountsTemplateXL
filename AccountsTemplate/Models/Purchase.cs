using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTemplate
{
    internal class Purchase : ITransaction
    {
        public Purchase()
        {
            Type = TransactionType.Purchase;
        }

        public TransactionType Type
        {
            get;
            set;
        }

        public string Name
        {
            get; set;
        }

        public int BASAccountNumber
        {
            get; set;
        }

        public int Total
        {
            get;
            set;
        }

        public int VAT
        {
            get;
            set;
        }

        public int CostFraction
        {
            get; set;
        }

        public decimal Cost
        {
            get
            {
                var fraction = decimal.Divide(CostFraction, 100);
                return decimal.Divide(decimal.Multiply(Total, fraction), 100);
            }
        }

        public decimal AmountVAT
        {
            get
            {
                if (VAT == 0)
                {
                    return 0;
                }
                return decimal.Multiply(Cost, decimal.Divide(VAT, 100));
            }
        }

        public DateTime Date
        {
            get; set;
        }
    }
}