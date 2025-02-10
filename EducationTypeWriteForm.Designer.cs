namespace Military
{
    partial class EducationTypeWriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationTypeWriteForm));
            this.CommitBtn = new System.Windows.Forms.Button();
            this.EducationType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommitBtn
            // 
            this.CommitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.CommitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.CommitBtn.FlatAppearance.BorderSize = 2;
            this.CommitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitBtn.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommitBtn.ForeColor = System.Drawing.Color.White;
            this.CommitBtn.Location = new System.Drawing.Point(26, 61);
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(293, 54);
            this.CommitBtn.TabIndex = 33;
            this.CommitBtn.Text = "Создать запись";
            this.CommitBtn.UseVisualStyleBackColor = false;
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // EducationType
            // 
            this.EducationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.EducationType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationType.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationType.ForeColor = System.Drawing.Color.White;
            this.EducationType.Location = new System.Drawing.Point(181, 14);
            this.EducationType.MaxLength = 50;
            this.EducationType.Name = "EducationType";
            this.EducationType.Size = new System.Drawing.Size(150, 27);
            this.EducationType.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Вид образования";
            // 
            // EducationTypeWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(354, 128);
            this.Controls.Add(this.CommitBtn);
            this.Controls.Add(this.EducationType);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EducationTypeWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление вида образования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommitBtn;
        private System.Windows.Forms.TextBox EducationType;
        private System.Windows.Forms.Label label2;
    }
}