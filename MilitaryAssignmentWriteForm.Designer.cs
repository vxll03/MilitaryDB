namespace Military
{
    partial class MilitaryAssignmentWriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilitaryAssignmentWriteForm));
            this.CommitBtn = new System.Windows.Forms.Button();
            this.ConscriptID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TroopTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.CommitBtn.Location = new System.Drawing.Point(34, 144);
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(293, 54);
            this.CommitBtn.TabIndex = 33;
            this.CommitBtn.Text = "Создать запись";
            this.CommitBtn.UseVisualStyleBackColor = false;
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // ConscriptID
            // 
            this.ConscriptID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ConscriptID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConscriptID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConscriptID.ForeColor = System.Drawing.Color.White;
            this.ConscriptID.Location = new System.Drawing.Point(202, 21);
            this.ConscriptID.MaxLength = 50;
            this.ConscriptID.Name = "ConscriptID";
            this.ConscriptID.Size = new System.Drawing.Size(150, 27);
            this.ConscriptID.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Призывник ID";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(202, 87);
            this.Date.MaxLength = 50;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(150, 27);
            this.Date.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата распределения";
            // 
            // TroopTypeID
            // 
            this.TroopTypeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.TroopTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TroopTypeID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TroopTypeID.ForeColor = System.Drawing.Color.White;
            this.TroopTypeID.Location = new System.Drawing.Point(202, 54);
            this.TroopTypeID.MaxLength = 50;
            this.TroopTypeID.Name = "TroopTypeID";
            this.TroopTypeID.Size = new System.Drawing.Size(150, 27);
            this.TroopTypeID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Вид войск ID";
            // 
            // MilitaryAssignmentWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(363, 210);
            this.Controls.Add(this.TroopTypeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommitBtn);
            this.Controls.Add(this.ConscriptID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MilitaryAssignmentWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание записи о распределении войск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommitBtn;
        private System.Windows.Forms.TextBox ConscriptID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TroopTypeID;
        private System.Windows.Forms.Label label3;
    }
}