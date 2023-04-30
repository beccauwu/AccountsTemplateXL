namespace AccountsTemplate.Views
{
    partial class CreateSheetDialog
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
            this.ButtonYes = new System.Windows.Forms.Button();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.SheetNameLabel = new System.Windows.Forms.Label();
            this.SheetNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonYes.FlatAppearance.BorderSize = 0;
            this.ButtonYes.Location = new System.Drawing.Point(190, 91);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(92, 43);
            this.ButtonYes.TabIndex = 1;
            this.ButtonYes.Text = "OK";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonNo.FlatAppearance.BorderSize = 0;
            this.ButtonNo.Location = new System.Drawing.Point(12, 91);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonNo.Size = new System.Drawing.Size(92, 43);
            this.ButtonNo.TabIndex = 2;
            this.ButtonNo.Text = "Avbryt";
            this.ButtonNo.UseVisualStyleBackColor = false;
            // 
            // SheetNameLabel
            // 
            this.SheetNameLabel.AutoSize = true;
            this.SheetNameLabel.Location = new System.Drawing.Point(75, 24);
            this.SheetNameLabel.Name = "SheetNameLabel";
            this.SheetNameLabel.Size = new System.Drawing.Size(129, 21);
            this.SheetNameLabel.TabIndex = 4;
            this.SheetNameLabel.Text = "Namn för boken";
            // 
            // SheetNameInput
            // 
            this.SheetNameInput.Location = new System.Drawing.Point(66, 57);
            this.SheetNameInput.Name = "SheetNameInput";
            this.SheetNameInput.Size = new System.Drawing.Size(150, 28);
            this.SheetNameInput.TabIndex = 5;
            // 
            // CreateSheetDialog
            // 
            this.AcceptButton = this.ButtonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.ButtonNo;
            this.ClientSize = new System.Drawing.Size(294, 153);
            this.ControlBox = false;
            this.Controls.Add(this.SheetNameInput);
            this.Controls.Add(this.SheetNameLabel);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Font = new System.Drawing.Font("Product Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateSheetDialog";
            this.Text = "Ny bok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Label SheetNameLabel;
        private System.Windows.Forms.TextBox SheetNameInput;
    }
}