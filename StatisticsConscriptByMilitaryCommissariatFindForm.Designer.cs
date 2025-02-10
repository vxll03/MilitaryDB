namespace Military
{
    partial class StatisticsConscriptByMilitaryCommissariatFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsConscriptByMilitaryCommissariatFindForm));
            this.ConscriptFindBtn = new System.Windows.Forms.Button();
            this.ConscriptFindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConscriptFindBtn
            // 
            this.ConscriptFindBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ConscriptFindBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.ConscriptFindBtn.FlatAppearance.BorderSize = 2;
            this.ConscriptFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConscriptFindBtn.Font = new System.Drawing.Font("Montserrat Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConscriptFindBtn.ForeColor = System.Drawing.Color.White;
            this.ConscriptFindBtn.Location = new System.Drawing.Point(99, 119);
            this.ConscriptFindBtn.Name = "ConscriptFindBtn";
            this.ConscriptFindBtn.Size = new System.Drawing.Size(143, 51);
            this.ConscriptFindBtn.TabIndex = 8;
            this.ConscriptFindBtn.Text = "Найти";
            this.ConscriptFindBtn.UseVisualStyleBackColor = false;
            this.ConscriptFindBtn.Click += new System.EventHandler(this.ConscriptFindBtn_Click);
            // 
            // ConscriptFindTextBox
            // 
            this.ConscriptFindTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ConscriptFindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConscriptFindTextBox.Font = new System.Drawing.Font("Montserrat Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConscriptFindTextBox.ForeColor = System.Drawing.Color.White;
            this.ConscriptFindTextBox.Location = new System.Drawing.Point(78, 64);
            this.ConscriptFindTextBox.Name = "ConscriptFindTextBox";
            this.ConscriptFindTextBox.Size = new System.Drawing.Size(184, 26);
            this.ConscriptFindTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите номер комиссариата";
            // 
            // StatisticsConscriptByMilitaryCommissariatFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(333, 191);
            this.Controls.Add(this.ConscriptFindBtn);
            this.Controls.Add(this.ConscriptFindTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticsConscriptByMilitaryCommissariatFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод комиссариата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConscriptFindBtn;
        private System.Windows.Forms.TextBox ConscriptFindTextBox;
        private System.Windows.Forms.Label label1;
    }
}