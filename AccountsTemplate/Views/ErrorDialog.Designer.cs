namespace AccountsTemplate.Views
{
    partial class ErrorDialog
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ExceptionGrid = new System.Windows.Forms.PropertyGrid();
            this.ErrorDialogIcon = new System.Windows.Forms.PictureBox();
            this.ErrorTabs = new System.Windows.Forms.TabControl();
            this.TabMain = new System.Windows.Forms.TabPage();
            this.TabDetail = new System.Windows.Forms.TabPage();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDialogIcon)).BeginInit();
            this.ErrorTabs.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(107, 56);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(353, 54);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "Något gick fel.\r\nDu kan se mer detaljer genom att klicka på \"detaljer\",\r\nannars k" +
    "licka på stäng för att stänga programmet.";
            // 
            // ExceptionGrid
            // 
            this.ExceptionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExceptionGrid.HelpVisible = false;
            this.ExceptionGrid.Location = new System.Drawing.Point(3, 3);
            this.ExceptionGrid.Name = "ExceptionGrid";
            this.ExceptionGrid.Size = new System.Drawing.Size(494, 129);
            this.ExceptionGrid.TabIndex = 2;
            this.ExceptionGrid.ToolbarVisible = false;
            // 
            // ErrorDialogIcon
            // 
            this.ErrorDialogIcon.Location = new System.Drawing.Point(18, 16);
            this.ErrorDialogIcon.Name = "ErrorDialogIcon";
            this.ErrorDialogIcon.Size = new System.Drawing.Size(64, 64);
            this.ErrorDialogIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorDialogIcon.TabIndex = 0;
            this.ErrorDialogIcon.TabStop = false;
            // 
            // ErrorTabs
            // 
            this.ErrorTabs.Controls.Add(this.TabMain);
            this.ErrorTabs.Controls.Add(this.TabDetail);
            this.ErrorTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorTabs.Location = new System.Drawing.Point(0, 0);
            this.ErrorTabs.Name = "ErrorTabs";
            this.ErrorTabs.SelectedIndex = 0;
            this.ErrorTabs.Size = new System.Drawing.Size(508, 164);
            this.ErrorTabs.TabIndex = 3;
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.ErrorDialogIcon);
            this.TabMain.Controls.Add(this.ErrorLabel);
            this.TabMain.Location = new System.Drawing.Point(4, 25);
            this.TabMain.Name = "TabMain";
            this.TabMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabMain.Size = new System.Drawing.Size(500, 135);
            this.TabMain.TabIndex = 0;
            this.TabMain.UseVisualStyleBackColor = true;
            // 
            // TabDetail
            // 
            this.TabDetail.Controls.Add(this.ExceptionGrid);
            this.TabDetail.Location = new System.Drawing.Point(4, 25);
            this.TabDetail.Name = "TabDetail";
            this.TabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TabDetail.Size = new System.Drawing.Size(500, 135);
            this.TabDetail.TabIndex = 1;
            this.TabDetail.Text = "Detaljer";
            this.TabDetail.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(408, 190);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(88, 36);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Stäng";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ErrorDialog
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 238);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ErrorTabs);
            this.Name = "ErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Något gick fel!";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDialogIcon)).EndInit();
            this.ErrorTabs.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.TabMain.PerformLayout();
            this.TabDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ErrorDialogIcon;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.PropertyGrid ExceptionGrid;
        private System.Windows.Forms.TabControl ErrorTabs;
        private System.Windows.Forms.TabPage TabMain;
        private System.Windows.Forms.TabPage TabDetail;
        private System.Windows.Forms.Button CloseButton;
    }
}