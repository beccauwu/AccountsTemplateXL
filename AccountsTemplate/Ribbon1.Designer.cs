namespace AccountsTemplate
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.AccountingGroup = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.OpenDialogButton = this.Factory.CreateRibbonButton();
            this.NewSheetButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.AccountingGroup.SuspendLayout();
            this.box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.AccountingGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // AccountingGroup
            // 
            this.AccountingGroup.Items.Add(this.box1);
            this.AccountingGroup.Label = "Bokföring";
            this.AccountingGroup.Name = "AccountingGroup";
            // 
            // box1
            // 
            this.box1.Items.Add(this.OpenDialogButton);
            this.box1.Items.Add(this.NewSheetButton);
            this.box1.Name = "box1";
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenDialogButton.Image = global::AccountsTemplate.Properties.Resources.accounting_128;
            this.OpenDialogButton.Label = "Hantera köp";
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.ShowImage = true;
            this.OpenDialogButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenDialogButton_Click);
            // 
            // NewSheetButton
            // 
            this.NewSheetButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.NewSheetButton.Image = global::AccountsTemplate.Properties.Resources.excelsheet_128;
            this.NewSheetButton.Label = "Öppna ny bok";
            this.NewSheetButton.Name = "NewSheetButton";
            this.NewSheetButton.ShowImage = true;
            this.NewSheetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.NewSheetButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.AccountingGroup.ResumeLayout(false);
            this.AccountingGroup.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AccountingGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenDialogButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton NewSheetButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get
            {
                return this.GetRibbon<Ribbon1>();
            }
        }
    }
}
