using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

using Excel = Microsoft.Office.Interop.Excel;

namespace AccountsTemplate
{
    internal class Utilities
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public static List<dynamic> ParseColumn(Excel.Worksheet ws, string col, int startRow)
        {
            Logger.Info("Parsing column {0} starting at row {1} in worksheet {2}", col, startRow, ws.Name);
            int i = startRow;
            List<dynamic> res = new List<dynamic>();
            while (true)
            {
                var range = string.Concat(new string[] { col, i.ToString() });
                var cell = ws.Range[range].Text;
                if (!string.IsNullOrEmpty(cell))
                {
                    res.Add(cell);
                    i++;
                    continue;
                }

                break;
            }
            return res;
        }

        public static DataGetResult ParseSheetData()
        {
            var worksheets = Globals.ThisWorkbook.Application.Worksheets;
            List<string> companies = new List<string>();
            List<int> accounts = new List<int>();
            List<Company> companyData = new List<Company>();
            int rowCount = 0;
            foreach (Excel.Worksheet worksheet in worksheets)
            {
                Logger.Info("Parsing worksheet {0}", worksheet.Name);
                var companyCol = ParseColumn(worksheet, "C", 3);
                var acctCol = ParseColumn(worksheet, "D", 3);
                companies.AddRange(companyCol.ConvertAll<string>(x => string.Format(x)));
                accounts.AddRange(acctCol.ConvertAll<int>(x => int.Parse(x)));
                if (worksheet == Globals.ThisWorkbook.Application.ActiveSheet)
                {
                    int rows = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row - 2;
                    if (rows > 0)
                    {
                        rowCount = rows;
                    }
                    else
                    {
                        rowCount = 0;
                    }
                }
            }
            if (companies.Count < 1)
            {
                Logger.Info("No rows with data found, returning empty result");
                return new DataGetResult
                {
                    Companies = companies,
                    CompanyData = companyData,
                    RowCount = 0
                };
            }
            if (companies.Count != accounts.Count)
            {
                throw new Exception("Companies and accounts lists have different sizes.");
            }
            for (int i = 0; i < companies.Count; i++)
            {
                companyData.Add(new Company()
                {
                    Name = companies[i],
                    Accounts = new List<int> { accounts[i] },
                });
            }
            List<string> distinctCompanies = companies.Distinct().ToList();
            distinctCompanies.Sort();
            List<Company> distinctCompanydata = companyData
                .GroupBy(c => c.Name)
                .Select(g => new Company
                {
                    Name = g.Key,
                    Accounts = g.SelectMany(c => c.Accounts).GroupBy(a => a)
                   .OrderByDescending(ag => ag.Count())
                   .ThenBy(ag => ag.Key)
                   .Select(ag => ag.Key).ToList()
                })
                .ToList();
            var res = new DataGetResult()
            {
                Companies = distinctCompanies,
                CompanyData = distinctCompanydata,
                RowCount = rowCount
            };
            return res;
        }

        public static Excel.Range GetLastRow(Excel.Worksheet ws)
        {
            return ws.Cells.Find("*", System.Reflection.Missing.Value,
System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
        }

        public static void WriteRow(Excel.Worksheet ws, string[] rowData)
        {
            //get the last row with data
            Excel.Range lastRow = GetLastRow(ws);
            Excel.Range range = ws.Cells[lastRow.Row + 1, 1];
            //            int rowNumber = last.Row + 1;
            //            char col = column;
            //            foreach (string cell in rowData)
            //            {
            //                //var range = string.Concat(new string[] { col.ToString(), rowNumber.ToString() });
            //                Excel.Range row = ws.get_Range("A1");
            //                row.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            //                Excel.Range newRow = ws.get_Range("A1");
            //                newRow.Value2 = cell;
            //                //col = (char)(col + 1);
            //            }
            range.get_Resize(1, rowData.Length).Value2 = rowData;
            return;
        }

        public static void WriteArray<T>(Excel.Worksheet sheet, int startRow, int startColumn, T[,] array)
        {
            Logger.Info("Writing rows to sheet {0} starting at ({1},{2})", sheet.Name, startRow, startColumn);
            var row = array.GetLength(0);
            var col = array.GetLength(1);
            Excel.Range c1 = (Excel.Range)sheet.Cells[startRow, startColumn];
            Excel.Range c2 = (Excel.Range)sheet.Cells[startRow + row - 1, startColumn + col - 1];
            Excel.Range range = sheet.Range[c1, c2];
            range.Value = array;
            sheet.Columns.AutoFit();
        }

        public static dynamic[] PurchaseArray(Purchase item, int order = 1)
        {
            var result = new dynamic[10]
            {
                order,
                item.Date.ToString("dd/MM/yyyy"),
                item.Name,
                item.BASAccountNumber,
                "",
                Math.Round(decimal.Divide(item.Total, 100), 2),
                item.CostFraction,
                Math.Round(item.Cost, 2),
                item.VAT,
                Math.Round(item.AmountVAT, 2),
            };
            return result;
        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = null;
                }

                if (control is ComboBox comboBox)
                {
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                if (control is ListBox listBox)
                {
                    listBox.ClearSelected();
                }
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
        }
    }
}