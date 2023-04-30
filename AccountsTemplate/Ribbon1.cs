using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel.Controls;
using System.Windows.Forms;

using Forms = System.Windows.Forms;

using System.Drawing;
using AccountsTemplate.Views;

namespace AccountsTemplate
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        public DialogResult OpenTxDialog()
        {
            try
            {
                DataGetResult data = Utilities.ParseSheetData();
                Forms.Form form = new TransactionDialog(data, (Excel.Worksheet)Globals.ThisWorkbook.Application.ActiveSheet);

                DialogResult dialogResult = form.ShowDialog();
                return dialogResult;
            }
            catch (Exception ex)
            {
                Form error = new ErrorDialog(ex);
                DialogResult dialogResult = error.ShowDialog();
                return dialogResult;
            }
        }

        public DialogResult OpenCreateDialog()
        {
            Forms.Form form = new CreateSheetDialog();

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private void OpenDialogButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (OpenTxDialog() == DialogResult.OK)
            {
            }
        }

        private void NewSheetButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (OpenCreateDialog() == DialogResult.OK)
            {
            }
        }
    }
}