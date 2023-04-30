using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

using Excel = Microsoft.Office.Interop.Excel;

namespace AccountsTemplate.Views
{
    public partial class TransactionDialog : Form
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public TransactionDialog(DataGetResult data, Excel.Worksheet ws)
        {
            try
            {
                InitializeComponent();
                Logger.Info("Initialising window...");
                Worksheet = ws;
                DatalistOptions = data;
                Data = new TransactionData();
                purchaseBindingSource.DataSource = Data.Purchases;
                this.FormClosing += new FormClosingEventHandler(TransactionDialog_FormClosing);
                this.KeyPress += new KeyPressEventHandler(TransactionDialog_KeyPress);

                if (DatalistOptions.Companies.Count > 0)
                {
                    CompanyInput.Items.AddRange(DatalistOptions.Companies.ToArray());
                    CompanyInput.Text = DatalistOptions.Companies[0];
                    SetAccountInputValues();
                    this.ActiveControl = DatePicker;
                }
                else
                {
                    ShowNotification(Notification.Info("Inga existerande rader"));
                    ShowNewCompanyForm();
                    this.ActiveControl = NewCompanyNameInput;
                }
            }
            catch (Exception ex)
            {
                Form error = new ErrorDialog(ex);
                if (error.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void TransactionDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Focus();
                e.Handled = true;
            }
        }

        private DataGetResult DatalistOptions
        {
            get; set;
        }

        private Excel.Worksheet Worksheet
        {
            get; set;
        }

        internal TransactionData Data
        {
            get; set;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void AddAnotherButton_Click(object sender, EventArgs e)
        {
            Logger.Info("Adding purchase details to list");
            var created = new Purchase()
            {
                VAT = int.Parse(CheckedRadioButton(VatGroup).Text),
                CostFraction = int.Parse(CheckedRadioButton(PercentageGroup).Text.Replace("%", string.Empty)),
                Total = int.Parse(AmountInput.Value.ToString().Replace(".", string.Empty)),
                Date = DatePicker.Value,
                Name = CompanyInput.Text.Trim(),
                BASAccountNumber = int.Parse(AccountSelect.Text.Trim()),
            };
            Data.AddPurchase(created);
            ShowNotification(Notification.Success("Kvittot har lagts till"));
            DatePicker.Value = DateTime.Parse("01/01/2022");
            AmountInput.Value = 0;
            CompanyInput.Text = DatalistOptions.Companies.First();
            foreach (Control control in VatGroup.Controls)
            {
                if (control is RadioButton button)
                {
                    button.Checked = false;
                }
            }
            foreach (Control control in PercentageGroup.Controls)
            {
                if (control is RadioButton button)
                {
                    button.Checked = false;
                }
            }
            Vat25Radio.Checked = true;
            PercentageRadio100.Checked = true;
        }

        private RadioButton CheckedRadioButton(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(c => c.Checked);
        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            ShowNewCompanyForm();
        }

        private void ShowNewCompanyForm()
        {
            NewCompanyPanel.Enabled = true;
            NewCompanyPanel.Visible = true;
        }

        private void NewCompanySubmit_Click(object sender, EventArgs e)
        {
            Logger.Info("Adding new company to list");
            var newC = NewCompanyNameInput.Text.Trim();
            var newCAcct = int.Parse(NewCompanyAcctInput.Text.Trim());
            var accounts = new List<int>
            {
                newCAcct
            };
            DatalistOptions.Companies.Add(newC);
            DatalistOptions.CompanyData.Add(new Company() { Name = newC, Accounts = accounts });
            CompanyInput.Items.Add(newC);
            CompanyInput.Text = newC;
            NewCompanyPanel.Visible = false;
            NewCompanyPanel.Enabled = false;
            ShowNotification(Notification.Success("Företaget har lagts till"));
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            WriteData();
            this.Close();
        }

        private void WriteData()
        {
            Logger.Info("Writing data to sheet.");
            if (Data.Purchases.Count < 1)
            {
                return;
            }
            var rows = Data.Sort().GenerateArray(DatalistOptions, CountTotalCheck.Checked);
            Utilities.WriteArray(Worksheet, Utilities.GetLastRow(Worksheet).Row + 1, 1, rows);
            Data.ClearPurchases();
        }

        private void TransactionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogManager.Shutdown();
            WriteData();
        }

        private async void ShowNotification(Notification notification)
        {
            NotificationContainer.Panel2.BackColor = notification.Color;
            NotificationIcon.Image = notification.Image;
            NotificationText.Text = notification.Message;
            NotificationContainer.Visible = true;
            await Task.Delay(2000);
            NotificationContainer.Visible = false;
        }

        private void AddedRowsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CompanyInput_TextChanged(object sender, EventArgs e)
        {
            if (DatalistOptions.Companies.Contains(CompanyInput.Text.Trim()))
            {
                SetAccountInputValues();
                this.ActiveControl = AccountSelect;
            }
        }

        private void SetAccountInputValues()
        {
            AccountSelect.Items.Clear();
            Company company = DatalistOptions.CompanyData.Single(c => c.Name == CompanyInput.Text);
            string[] accounts = company.Accounts.ConvertAll(a => a.ToString()).ToArray();
            AccountSelect.Items.AddRange(accounts);
            AccountSelect.Text = accounts[0];
        }

        private void AccountSelect_Leave(object sender, EventArgs e)
        {
            var enteredValue = int.Parse(AccountSelect.Text.Trim());
            var company = DatalistOptions.CompanyData.FirstOrDefault(c => c.Name == CompanyInput.Text);
            if (company != null)
            {
                company.Accounts.Add(enteredValue);
                company.Accounts = company.Accounts.Distinct().ToList();
            }
        }

        private void AccountSelect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.GetNextControl(AccountSelect, true).Focus();
                e.IsInputKey = true;
            }
        }
    }
}