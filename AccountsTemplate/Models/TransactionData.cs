using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTemplate
{
    internal class TransactionData
    {
        public TransactionData()
        {
            PurchasesBacking = new List<Purchase>();
            Purchases = new BindingList<Purchase>(PurchasesBacking);
            Purchases.ListChanged += (sender, e) =>
            {
                if (e.ListChangedType == ListChangedType.ItemChanged)
                {
                    var index = e.NewIndex;
                    Purchase purchase = Purchases[index];
                    PurchasesBacking.RemoveAt(index);
                    PurchasesBacking.Insert(index, purchase);
                }
                else if (e.ListChangedType == ListChangedType.ItemDeleted)
                {
                    var index = e.NewIndex;
                    PurchasesBacking.RemoveAt(index);
                }
                else if (e.ListChangedType == ListChangedType.ItemMoved)
                {
                    Purchase item = Purchases[e.NewIndex];
                    PurchasesBacking.RemoveAt(e.OldIndex);
                    PurchasesBacking.Insert(e.NewIndex, item);
                }
            };
        }

        public BindingList<Purchase> Purchases;
        private readonly List<Purchase> PurchasesBacking;

        public void AddPurchase(Purchase purchase)
        {
            PurchasesBacking.Add(purchase);
            Sort();
        }

        public void ClearPurchases()
        {
            PurchasesBacking.Clear();
            Purchases.ResetBindings();
        }

        public TransactionData Sort()
        {
            PurchasesBacking.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            Purchases.ResetBindings();
            return this;
        }

        public dynamic[,] GenerateArray(DataGetResult data, bool calculateTotal = false)
        {
            dynamic[][] purchases = new dynamic[Purchases.Count()][];
            int rowNumber = data.RowCount;
            decimal addedTotal = 0;
            decimal addedVAT = 0;
            for (int i = 0; i < Purchases.Count(); i++)
            {
                Purchase purchase = Purchases[i];
                purchases[i] = Utilities.PurchaseArray(purchase, rowNumber);
                addedTotal += purchase.Cost;
                addedVAT += purchase.AmountVAT;
                rowNumber++;
            }
            int lX = purchases.Length;
            int lY = purchases[0].Length;
            if (calculateTotal)
            {
                lX += 1;
            }
            dynamic[,] res = new dynamic[lX, lY];
            for (int i = 0; i < purchases.Length; i++)
            {
                for (int j = 0; j < purchases[i].Length; j++)
                {
                    res[i, j] = purchases[i][j];
                }
            }
            if (calculateTotal)
            {
                res[lX - 1, 0] = "TOTAL";
                res[lX - 1, 1] = "";
                res[lX - 1, 2] = "";
                res[lX - 1, 3] = "";
                res[lX - 1, 4] = "";
                res[lX - 1, 5] = "";
                res[lX - 1, 6] = "";
                res[lX - 1, 7] = addedTotal;
                res[lX - 1, 8] = "";
                res[lX - 1, 9] = addedVAT;
            }
            return res;
        }
    }
}