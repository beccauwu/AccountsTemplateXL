using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTemplate
{
    public class Company
    {
        public string Name;
        public List<int> Accounts;
    }

    public class DataGetResult
    {
        public List<string> Companies;
        public List<Company> CompanyData;
        public int RowCount;
    }

    internal class Transaction : ITransaction
    {
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
            get; set;
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
                return Total * (CostFraction / 100);
            }
        }

        public decimal AmountVAT
        {
            get
            {
                return 2;
            }
        }

        public DateTime Date
        {
            get; set;
        }
    }
}