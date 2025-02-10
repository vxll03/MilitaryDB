namespace Military
{
    partial class MedicalExaminationWriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalExaminationWriteForm));
            this.InspectorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConscriptID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FitnessCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DifermentDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExaminationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CommitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // InspectorID
            // 
            this.InspectorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.InspectorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InspectorID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InspectorID.ForeColor = System.Drawing.Color.White;
            this.InspectorID.Location = new System.Drawing.Point(217, 84);
            this.InspectorID.MaxLength = 3;
            this.InspectorID.Name = "InspectorID";
            this.InspectorID.Size = new System.Drawing.Size(150, 27);
            this.InspectorID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Проверяющего";
            // 
            // ConscriptID
            // 
            this.ConscriptID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ConscriptID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConscriptID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConscriptID.ForeColor = System.Drawing.Color.White;
            this.ConscriptID.Location = new System.Drawing.Point(382, 84);
            this.ConscriptID.MaxLength = 3;
            this.ConscriptID.Name = "ConscriptID";
            this.ConscriptID.Size = new System.Drawing.Size(150, 27);
            this.ConscriptID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(538, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Призывника";
            // 
            // FitnessCategory
            // 
            this.FitnessCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.FitnessCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FitnessCategory.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FitnessCategory.ForeColor = System.Drawing.Color.White;
            this.FitnessCategory.Location = new System.Drawing.Point(217, 117);
            this.FitnessCategory.MaxLength = 1;
            this.FitnessCategory.Name = "FitnessCategory";
            this.FitnessCategory.Size = new System.Drawing.Size(150, 27);
            this.FitnessCategory.TabIndex = 7;
            this.toolTip1.SetToolTip(this.FitnessCategory, "0 - Не явился\r\n1 - Годен к военной службе\r\n2 - Годен с незначительными ограничени" +
        "ями\r\n3 - Ограниченно годен к военной службе\r\n4 - Не годен к военной службе\r\n5 - " +
        "Временно негоден");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория годности";
            // 
            // DifermentDate
            // 
            this.DifermentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.DifermentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DifermentDate.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifermentDate.ForeColor = System.Drawing.Color.White;
            this.DifermentDate.Location = new System.Drawing.Point(382, 117);
            this.DifermentDate.MaxLength = 10;
            this.DifermentDate.Name = "DifermentDate";
            this.DifermentDate.Size = new System.Drawing.Size(150, 27);
            this.DifermentDate.TabIndex = 9;
            this.toolTip1.SetToolTip(this.DifermentDate, "Пример 20.03.2006");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(538, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата отсрочки";
            // 
            // ExaminationDate
            // 
            this.ExaminationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ExaminationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExaminationDate.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExaminationDate.ForeColor = System.Drawing.Color.White;
            this.ExaminationDate.Location = new System.Drawing.Point(300, 39);
            this.ExaminationDate.MaxLength = 10;
            this.ExaminationDate.Name = "ExaminationDate";
            this.ExaminationDate.Size = new System.Drawing.Size(150, 27);
            this.ExaminationDate.TabIndex = 11;
            this.toolTip1.SetToolTip(this.ExaminationDate, "Пример 20.03.2006");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(245, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата прохождения комиссии";
            // 
            // CommitBtn
            // 
            this.CommitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.CommitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.CommitBtn.FlatAppearance.BorderSize = 2;
            this.CommitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitBtn.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommitBtn.ForeColor = System.Drawing.Color.White;
            this.CommitBtn.Location = new System.Drawing.Point(229, 172);
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(293, 54);
            this.CommitBtn.TabIndex = 23;
            this.CommitBtn.Text = "Создать запись";
            this.CommitBtn.UseVisualStyleBackColor = false;
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // MedicalExaminationWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(743, 262);
            this.Controls.Add(this.CommitBtn);
            this.Controls.Add(this.ExaminationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DifermentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FitnessCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConscriptID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InspectorID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicalExaminationWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalExaminationWriteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InspectorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConscriptID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FitnessCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DifermentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExaminationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CommitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}