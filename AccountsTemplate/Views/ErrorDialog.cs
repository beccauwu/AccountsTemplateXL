using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace AccountsTemplate.Views
{
    public partial class ErrorDialog : Form
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public ErrorDialog(Exception e, string message = "An error occurred in the application.")
        {
            InitializeComponent();
            Logger.Error(e, "{0}. Timestamp: {1}", message, DateTime.Now);
            Bitmap b = SystemIcons.Error.ToBitmap();
            ErrorDialogIcon.Image = b;
            ExceptionGrid.SelectedObject = e;
            SystemSounds.Exclamation.Play();
            foreach (PropertyInfo prop in e.GetType().GetProperties())
            {
                CategoryAttribute category = prop.GetCustomAttribute<CategoryAttribute>();
                if (category != null)
                {
                    ExceptionGrid.PropertySort = PropertySort.Categorized;
                    break;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}