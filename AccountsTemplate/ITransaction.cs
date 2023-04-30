using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTemplate
{
    internal enum TransactionType
    {
        Sale,
        Purchase
    }

    internal interface ITransaction
    {
        TransactionType Type
        {
            get;
            set;
        }

        string Name
        {
            get; set;
        }

        int BASAccountNumber
        {
            get; set;
        }

        int Total
        {
            get; set;
        }

        int VAT
        {
            get;
            set;
        }

        int CostFraction
        {
            get; set;
        }

        decimal Cost
        {
            get;
        }

        decimal AmountVAT
        {
            get;
        }

        DateTime Date
        {
            get; set;
        }
    }
}