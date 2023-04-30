namespace AccountsTemplate.Views
{
    partial class TransactionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.AddedRowsGrid = new System.Windows.Forms.DataGridView();
            this.Formtab = new System.Windows.Forms.TabPage();
            this.CountTotalCheck = new System.Windows.Forms.CheckBox();
            this.AccountSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NotificationContainer = new System.Windows.Forms.SplitContainer();
            this.NotificationIcon = new System.Windows.Forms.PictureBox();
            this.NotificationText = new System.Windows.Forms.Label();
            this.NewCompanyPanel = new System.Windows.Forms.Panel();
            this.NewCompanyTitle = new System.Windows.Forms.Label();
            this.NewCompanyAcctInput = new System.Windows.Forms.NumericUpDown();
            this.NewCompanyAccountLabel = new System.Windows.Forms.Label();
            this.NewCompanySubmit = new System.Windows.Forms.Button();
            this.NewCompanyNameLabel = new System.Windows.Forms.Label();
            this.NewCompanyNameInput = new System.Windows.Forms.TextBox();
            this.AmountInput = new System.Windows.Forms.NumericUpDown();
            this.PercentageGroup = new System.Windows.Forms.GroupBox();
            this.PercentageRadio20 = new System.Windows.Forms.RadioButton();
            this.PercentageRadio100 = new System.Windows.Forms.RadioButton();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.VatGroup = new System.Windows.Forms.GroupBox();
            this.Vat0Radio = new System.Windows.Forms.RadioButton();
            this.Vat25Radio = new System.Windows.Forms.RadioButton();
            this.Vat12Radio = new System.Windows.Forms.RadioButton();
            this.Vat6Radio = new System.Windows.Forms.RadioButton();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CompanyInput = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAnotherButton = new System.Windows.Forms.Button();
            this.NavTabControl = new System.Windows.Forms.TabControl();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASAccountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costFractionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddedRowsGrid)).BeginInit();
            this.Formtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationContainer)).BeginInit();
            this.NotificationContainer.Panel1.SuspendLayout();
            this.NotificationContainer.Panel2.SuspendLayout();
            this.NotificationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationIcon)).BeginInit();
            this.NewCompanyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyAcctInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).BeginInit();
            this.PercentageGroup.SuspendLayout();
            this.VatGroup.SuspendLayout();
            this.NavTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubmitButton.Location = new System.Drawing.Point(791, 566);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(107, 52);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Klar";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(13, 566);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 52);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Gå tillbaka";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.AddedRowsGrid);
            this.DataTab.Location = new System.Drawing.Point(4, 30);
            this.DataTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataTab.Size = new System.Drawing.Size(897, 493);
            this.DataTab.TabIndex = 1;
            this.DataTab.Text = "Tillagda kvitton";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // AddedRowsGrid
            // 
            this.AddedRowsGrid.AllowUserToAddRows = false;
            this.AddedRowsGrid.AutoGenerateColumns = false;
            this.AddedRowsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedRowsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bASAccountNumberDataGridViewTextBoxColumn,
            this.amountVATDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.costFractionDataGridViewTextBoxColumn});
            this.AddedRowsGrid.DataSource = this.purchaseBindingSource;
            this.AddedRowsGrid.Location = new System.Drawing.Point(90, 25);
            this.AddedRowsGrid.Name = "AddedRowsGrid";
            this.AddedRowsGrid.RowHeadersWidth = 51;
            this.AddedRowsGrid.RowTemplate.Height = 24;
            this.AddedRowsGrid.Size = new System.Drawing.Size(680, 421);
            this.AddedRowsGrid.TabIndex = 20;
            this.AddedRowsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddedRowsGrid_CellContentClick);
            // 
            // Formtab
            // 
            this.Formtab.Controls.Add(this.CountTotalCheck);
            this.Formtab.Controls.Add(this.AccountSelect);
            this.Formtab.Controls.Add(this.label2);
            this.Formtab.Controls.Add(this.label1);
            this.Formtab.Controls.Add(this.NotificationContainer);
            this.Formtab.Controls.Add(this.NewCompanyPanel);
            this.Formtab.Controls.Add(this.AmountInput);
            this.Formtab.Controls.Add(this.PercentageGroup);
            this.Formtab.Controls.Add(this.AddCompanyButton);
            this.Formtab.Controls.Add(this.VatGroup);
            this.Formtab.Controls.Add(this.CurrencyLabel);
            this.Formtab.Controls.Add(this.CompanyLabel);
            this.Formtab.Controls.Add(this.CompanyInput);
            this.Formtab.Controls.Add(this.AmountLabel);
            this.Formtab.Controls.Add(this.DateLabel);
            this.Formtab.Controls.Add(this.DatePicker);
            this.Formtab.Controls.Add(this.AddAnotherButton);
            this.Formtab.Location = new System.Drawing.Point(4, 30);
            this.Formtab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Formtab.Name = "Formtab";
            this.Formtab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Formtab.Size = new System.Drawing.Size(897, 493);
            this.Formtab.TabIndex = 0;
            this.Formtab.Text = "Ny";
            this.Formtab.UseVisualStyleBackColor = true;
            this.Formtab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CountTotalCheck
            // 
            this.CountTotalCheck.AutoSize = true;
            this.CountTotalCheck.Checked = true;
            this.CountTotalCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CountTotalCheck.Location = new System.Drawing.Point(755, 402);
            this.CountTotalCheck.Name = "CountTotalCheck";
            this.CountTotalCheck.Size = new System.Drawing.Size(135, 25);
            this.CountTotalCheck.TabIndex = 24;
            this.CountTotalCheck.Text = "Räkna totalet?";
            this.CountTotalCheck.UseVisualStyleBackColor = true;
            // 
            // AccountSelect
            // 
            this.AccountSelect.FormattingEnabled = true;
            this.AccountSelect.Location = new System.Drawing.Point(97, 188);
            this.AccountSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AccountSelect.Name = "AccountSelect";
            this.AccountSelect.Size = new System.Drawing.Size(136, 29);
            this.AccountSelect.TabIndex = 23;
            this.AccountSelect.Leave += new System.EventHandler(this.AccountSelect_Leave);
            this.AccountSelect.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.AccountSelect_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kontonr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kontonr";
            // 
            // NotificationContainer
            // 
            this.NotificationContainer.Location = new System.Drawing.Point(599, 6);
            this.NotificationContainer.Name = "NotificationContainer";
            // 
            // NotificationContainer.Panel1
            // 
            this.NotificationContainer.Panel1.Controls.Add(this.NotificationIcon);
            // 
            // NotificationContainer.Panel2
            // 
            this.NotificationContainer.Panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NotificationContainer.Panel2.Controls.Add(this.NotificationText);
            this.NotificationContainer.Size = new System.Drawing.Size(291, 50);
            this.NotificationContainer.SplitterDistance = 35;
            this.NotificationContainer.TabIndex = 21;
            this.NotificationContainer.Visible = false;
            // 
            // NotificationIcon
            // 
            this.NotificationIcon.Image = global::AccountsTemplate.Properties.Resources.info_64;
            this.NotificationIcon.Location = new System.Drawing.Point(3, 0);
            this.NotificationIcon.Name = "NotificationIcon";
            this.NotificationIcon.Size = new System.Drawing.Size(30, 30);
            this.NotificationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotificationIcon.TabIndex = 19;
            this.NotificationIcon.TabStop = false;
            // 
            // NotificationText
            // 
            this.NotificationText.AutoSize = true;
            this.NotificationText.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationText.Location = new System.Drawing.Point(3, 10);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.Size = new System.Drawing.Size(241, 29);
            this.NotificationText.TabIndex = 20;
            this.NotificationText.Text = "Kvittot har lagts till";
            // 
            // NewCompanyPanel
            // 
            this.NewCompanyPanel.Controls.Add(this.NewCompanyTitle);
            this.NewCompanyPanel.Controls.Add(this.NewCompanyAcctInput);
            this.NewCompanyPanel.Controls.Add(this.NewCompanyAccountLabel);
            this.NewCompanyPanel.Controls.Add(this.NewCompanySubmit);
            this.NewCompanyPanel.Controls.Add(this.NewCompanyNameLabel);
            this.NewCompanyPanel.Controls.Add(this.NewCompanyNameInput);
            this.NewCompanyPanel.Enabled = false;
            this.NewCompanyPanel.Location = new System.Drawing.Point(271, 119);
            this.NewCompanyPanel.Name = "NewCompanyPanel";
            this.NewCompanyPanel.Size = new System.Drawing.Size(258, 131);
            this.NewCompanyPanel.TabIndex = 18;
            this.NewCompanyPanel.Visible = false;
            // 
            // NewCompanyTitle
            // 
            this.NewCompanyTitle.AutoSize = true;
            this.NewCompanyTitle.Font = new System.Drawing.Font("Glacial Indifference", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCompanyTitle.Location = new System.Drawing.Point(32, 4);
            this.NewCompanyTitle.Name = "NewCompanyTitle";
            this.NewCompanyTitle.Size = new System.Drawing.Size(193, 21);
            this.NewCompanyTitle.TabIndex = 24;
            this.NewCompanyTitle.Text = "Registrera nytt företag";
            // 
            // NewCompanyAcctInput
            // 
            this.NewCompanyAcctInput.Location = new System.Drawing.Point(84, 76);
            this.NewCompanyAcctInput.Name = "NewCompanyAcctInput";
            this.NewCompanyAcctInput.Size = new System.Drawing.Size(128, 29);
            this.NewCompanyAcctInput.TabIndex = 21;
            // 
            // NewCompanyAccountLabel
            // 
            this.NewCompanyAccountLabel.AutoSize = true;
            this.NewCompanyAccountLabel.Location = new System.Drawing.Point(14, 78);
            this.NewCompanyAccountLabel.Name = "NewCompanyAccountLabel";
            this.NewCompanyAccountLabel.Size = new System.Drawing.Size(64, 21);
            this.NewCompanyAccountLabel.TabIndex = 20;
            this.NewCompanyAccountLabel.Text = "Kontonr";
            // 
            // NewCompanySubmit
            // 
            this.NewCompanySubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewCompanySubmit.Image = global::AccountsTemplate.Properties.Resources.check_16;
            this.NewCompanySubmit.Location = new System.Drawing.Point(231, 3);
            this.NewCompanySubmit.Name = "NewCompanySubmit";
            this.NewCompanySubmit.Size = new System.Drawing.Size(24, 24);
            this.NewCompanySubmit.TabIndex = 19;
            this.NewCompanySubmit.UseVisualStyleBackColor = true;
            this.NewCompanySubmit.Click += new System.EventHandler(this.NewCompanySubmit_Click);
            // 
            // NewCompanyNameLabel
            // 
            this.NewCompanyNameLabel.AutoSize = true;
            this.NewCompanyNameLabel.Location = new System.Drawing.Point(14, 33);
            this.NewCompanyNameLabel.Name = "NewCompanyNameLabel";
            this.NewCompanyNameLabel.Size = new System.Drawing.Size(53, 21);
            this.NewCompanyNameLabel.TabIndex = 18;
            this.NewCompanyNameLabel.Text = "Namn";
            // 
            // NewCompanyNameInput
            // 
            this.NewCompanyNameInput.Location = new System.Drawing.Point(84, 28);
            this.NewCompanyNameInput.Name = "NewCompanyNameInput";
            this.NewCompanyNameInput.Size = new System.Drawing.Size(128, 29);
            this.NewCompanyNameInput.TabIndex = 17;
            // 
            // AmountInput
            // 
            this.AmountInput.DecimalPlaces = 2;
            this.AmountInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AmountInput.Location = new System.Drawing.Point(97, 96);
            this.AmountInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(135, 29);
            this.AmountInput.TabIndex = 2;
            this.AmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PercentageGroup
            // 
            this.PercentageGroup.Controls.Add(this.PercentageRadio20);
            this.PercentageGroup.Controls.Add(this.PercentageRadio100);
            this.PercentageGroup.Controls.Add(this.PercentageLabel);
            this.PercentageGroup.Location = new System.Drawing.Point(32, 340);
            this.PercentageGroup.Name = "PercentageGroup";
            this.PercentageGroup.Size = new System.Drawing.Size(200, 136);
            this.PercentageGroup.TabIndex = 8;
            this.PercentageGroup.TabStop = false;
            this.PercentageGroup.Text = "Andel";
            // 
            // PercentageRadio20
            // 
            this.PercentageRadio20.AutoSize = true;
            this.PercentageRadio20.Location = new System.Drawing.Point(64, 90);
            this.PercentageRadio20.Name = "PercentageRadio20";
            this.PercentageRadio20.Size = new System.Drawing.Size(63, 25);
            this.PercentageRadio20.TabIndex = 10;
            this.PercentageRadio20.TabStop = true;
            this.PercentageRadio20.Text = "20%";
            this.PercentageRadio20.UseVisualStyleBackColor = true;
            // 
            // PercentageRadio100
            // 
            this.PercentageRadio100.AutoSize = true;
            this.PercentageRadio100.Checked = true;
            this.PercentageRadio100.Location = new System.Drawing.Point(64, 59);
            this.PercentageRadio100.Name = "PercentageRadio100";
            this.PercentageRadio100.Size = new System.Drawing.Size(73, 25);
            this.PercentageRadio100.TabIndex = 9;
            this.PercentageRadio100.TabStop = true;
            this.PercentageRadio100.Text = "100%";
            this.PercentageRadio100.UseVisualStyleBackColor = true;
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(34, 35);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(148, 21);
            this.PercentageLabel.TabIndex = 0;
            this.PercentageLabel.Text = "Andel på företaget";
            this.PercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCompanyButton.Image = global::AccountsTemplate.Properties.Resources.plus_16;
            this.AddCompanyButton.Location = new System.Drawing.Point(232, 145);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(24, 24);
            this.AddCompanyButton.TabIndex = 14;
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
            // 
            // VatGroup
            // 
            this.VatGroup.Controls.Add(this.Vat0Radio);
            this.VatGroup.Controls.Add(this.Vat25Radio);
            this.VatGroup.Controls.Add(this.Vat12Radio);
            this.VatGroup.Controls.Add(this.Vat6Radio);
            this.VatGroup.Location = new System.Drawing.Point(32, 226);
            this.VatGroup.Name = "VatGroup";
            this.VatGroup.Size = new System.Drawing.Size(224, 108);
            this.VatGroup.TabIndex = 4;
            this.VatGroup.TabStop = false;
            this.VatGroup.Text = "moms %";
            // 
            // Vat0Radio
            // 
            this.Vat0Radio.AutoSize = true;
            this.Vat0Radio.Location = new System.Drawing.Point(38, 28);
            this.Vat0Radio.Name = "Vat0Radio";
            this.Vat0Radio.Size = new System.Drawing.Size(41, 25);
            this.Vat0Radio.TabIndex = 8;
            this.Vat0Radio.TabStop = true;
            this.Vat0Radio.Text = "0";
            this.Vat0Radio.UseVisualStyleBackColor = true;
            // 
            // Vat25Radio
            // 
            this.Vat25Radio.AutoSize = true;
            this.Vat25Radio.Checked = true;
            this.Vat25Radio.Location = new System.Drawing.Point(131, 59);
            this.Vat25Radio.Name = "Vat25Radio";
            this.Vat25Radio.Size = new System.Drawing.Size(51, 25);
            this.Vat25Radio.TabIndex = 7;
            this.Vat25Radio.TabStop = true;
            this.Vat25Radio.Text = "25";
            this.Vat25Radio.UseVisualStyleBackColor = true;
            // 
            // Vat12Radio
            // 
            this.Vat12Radio.AutoSize = true;
            this.Vat12Radio.Location = new System.Drawing.Point(38, 59);
            this.Vat12Radio.Name = "Vat12Radio";
            this.Vat12Radio.Size = new System.Drawing.Size(51, 25);
            this.Vat12Radio.TabIndex = 6;
            this.Vat12Radio.TabStop = true;
            this.Vat12Radio.Text = "12";
            this.Vat12Radio.UseVisualStyleBackColor = true;
            // 
            // Vat6Radio
            // 
            this.Vat6Radio.AutoSize = true;
            this.Vat6Radio.Location = new System.Drawing.Point(131, 28);
            this.Vat6Radio.Name = "Vat6Radio";
            this.Vat6Radio.Size = new System.Drawing.Size(41, 25);
            this.Vat6Radio.TabIndex = 5;
            this.Vat6Radio.TabStop = true;
            this.Vat6Radio.Text = "6";
            this.Vat6Radio.UseVisualStyleBackColor = true;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(234, 104);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(22, 21);
            this.CurrencyLabel.TabIndex = 11;
            this.CurrencyLabel.Text = "kr";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(28, 147);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(67, 21);
            this.CompanyLabel.TabIndex = 10;
            this.CompanyLabel.Text = "Företag";
            // 
            // CompanyInput
            // 
            this.CompanyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyInput.FormattingEnabled = true;
            this.CompanyInput.Location = new System.Drawing.Point(96, 144);
            this.CompanyInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyInput.Name = "CompanyInput";
            this.CompanyInput.Size = new System.Drawing.Size(136, 29);
            this.CompanyInput.TabIndex = 3;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(28, 99);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(62, 21);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Belopp";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(28, 50);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(58, 21);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Datum";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyMMdd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(96, 44);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DatePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(136, 29);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // AddAnotherButton
            // 
            this.AddAnotherButton.Location = new System.Drawing.Point(783, 433);
            this.AddAnotherButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddAnotherButton.Name = "AddAnotherButton";
            this.AddAnotherButton.Size = new System.Drawing.Size(107, 52);
            this.AddAnotherButton.TabIndex = 11;
            this.AddAnotherButton.Text = "Lägg till";
            this.AddAnotherButton.UseVisualStyleBackColor = true;
            this.AddAnotherButton.Click += new System.EventHandler(this.AddAnotherButton_Click);
            // 
            // NavTabControl
            // 
            this.NavTabControl.Controls.Add(this.Formtab);
            this.NavTabControl.Controls.Add(this.DataTab);
            this.NavTabControl.Location = new System.Drawing.Point(4, 3);
            this.NavTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NavTabControl.Name = "NavTabControl";
            this.NavTabControl.SelectedIndex = 0;
            this.NavTabControl.Size = new System.Drawing.Size(905, 527);
            this.NavTabControl.TabIndex = 100;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Företag";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bASAccountNumberDataGridViewTextBoxColumn
            // 
            this.bASAccountNumberDataGridViewTextBoxColumn.DataPropertyName = "BASAccountNumber";
            this.bASAccountNumberDataGridViewTextBoxColumn.HeaderText = "Kontonr";
            this.bASAccountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bASAccountNumberDataGridViewTextBoxColumn.Name = "bASAccountNumberDataGridViewTextBoxColumn";
            this.bASAccountNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountVATDataGridViewTextBoxColumn
            // 
            this.amountVATDataGridViewTextBoxColumn.DataPropertyName = "AmountVAT";
            this.amountVATDataGridViewTextBoxColumn.HeaderText = "moms";
            this.amountVATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountVATDataGridViewTextBoxColumn.Name = "amountVATDataGridViewTextBoxColumn";
            this.amountVATDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountVATDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Kostnad";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Totalt";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Visible = false;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            this.vATDataGridViewTextBoxColumn.Visible = false;
            this.vATDataGridViewTextBoxColumn.Width = 125;
            // 
            // costFractionDataGridViewTextBoxColumn
            // 
            this.costFractionDataGridViewTextBoxColumn.DataPropertyName = "CostFraction";
            this.costFractionDataGridViewTextBoxColumn.HeaderText = "CostFraction";
            this.costFractionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costFractionDataGridViewTextBoxColumn.Name = "costFractionDataGridViewTextBoxColumn";
            this.costFractionDataGridViewTextBoxColumn.Visible = false;
            this.costFractionDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(AccountsTemplate.Purchase);
            // 
            // TransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 630);
            this.ControlBox = false;
            this.Controls.Add(this.NavTabControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Font = new System.Drawing.Font("Glacial Indifference", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TransactionDialog";
            this.Text = "Bokföring";
            this.DataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddedRowsGrid)).EndInit();
            this.Formtab.ResumeLayout(false);
            this.Formtab.PerformLayout();
            this.NotificationContainer.Panel1.ResumeLayout(false);
            this.NotificationContainer.Panel2.ResumeLayout(false);
            this.NotificationContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationContainer)).EndInit();
            this.NotificationContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotificationIcon)).EndInit();
            this.NewCompanyPanel.ResumeLayout(false);
            this.NewCompanyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCompanyAcctInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).EndInit();
            this.PercentageGroup.ResumeLayout(false);
            this.PercentageGroup.PerformLayout();
            this.VatGroup.ResumeLayout(false);
            this.VatGroup.PerformLayout();
            this.NavTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage DataTab;
        private System.Windows.Forms.TabPage Formtab;
        private System.Windows.Forms.GroupBox PercentageGroup;
        private System.Windows.Forms.RadioButton PercentageRadio20;
        private System.Windows.Forms.RadioButton PercentageRadio100;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.GroupBox VatGroup;
        private System.Windows.Forms.RadioButton Vat25Radio;
        private System.Windows.Forms.RadioButton Vat12Radio;
        private System.Windows.Forms.RadioButton Vat6Radio;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.ComboBox CompanyInput;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button AddAnotherButton;
        private System.Windows.Forms.TabControl NavTabControl;
        private System.Windows.Forms.NumericUpDown AmountInput;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox NewCompanyNameInput;
        private System.Windows.Forms.Panel NewCompanyPanel;
        private System.Windows.Forms.Label NewCompanyNameLabel;
        private System.Windows.Forms.Button NewCompanySubmit;
        private System.Windows.Forms.NumericUpDown NewCompanyAcctInput;
        private System.Windows.Forms.Label NewCompanyAccountLabel;
        private System.Windows.Forms.DataGridView AddedRowsGrid;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASAccountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costFractionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NotificationText;
        private System.Windows.Forms.SplitContainer NotificationContainer;
        private System.Windows.Forms.PictureBox NotificationIcon;
        private System.Windows.Forms.RadioButton Vat0Radio;
        private System.Windows.Forms.ComboBox AccountSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewCompanyTitle;
        private System.Windows.Forms.CheckBox CountTotalCheck;
    }
}