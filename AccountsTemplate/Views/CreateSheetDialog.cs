using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using NLog;

namespace AccountsTemplate.Views
{
    public partial class CreateSheetDialog : Form
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public CreateSheetDialog()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ActiveControl = SheetNameInput;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            var template = (Excel.Worksheet)Globals.ThisWorkbook.Sheets[1];
            var count = Globals.ThisWorkbook.Sheets.Count;
            var last = (Excel.Worksheet)Globals.ThisWorkbook.Sheets[count];
            var templateRange = template.Range["A1:K2"].Copy();
            var ws = (Excel.Worksheet)Globals.ThisWorkbook.Worksheets.Add(After: last);
            var sheetName = SheetNameInput.Text;
            ws.PasteSpecial(templateRange);
            ws.Range["A1:K2"].Columns.AutoFit();
            ws.Name = sheetName;
            Clipboard.Clear();
            Logger.Info("Created new worksheet: {0}", sheetName);
            this.Close();
        }
    }
}