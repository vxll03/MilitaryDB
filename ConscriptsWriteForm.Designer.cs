namespace Military
{
    partial class ConscriptsWriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConscriptsWriteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CommissariatID = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SummonNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EducationID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Building = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CriminalRecord = new System.Windows.Forms.CheckBox();
            this.CommitBtn = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageLoad = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Коммиссариата";
            // 
            // CommissariatID
            // 
            this.CommissariatID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.CommissariatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommissariatID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommissariatID.ForeColor = System.Drawing.Color.White;
            this.CommissariatID.Location = new System.Drawing.Point(182, 24);
            this.CommissariatID.MaxLength = 3;
            this.CommissariatID.Name = "CommissariatID";
            this.CommissariatID.Size = new System.Drawing.Size(150, 27);
            this.CommissariatID.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Location = new System.Drawing.Point(182, 70);
            this.LastName.MaxLength = 50;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 27);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // MiddleName
            // 
            this.MiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleName.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.ForeColor = System.Drawing.Color.White;
            this.MiddleName.Location = new System.Drawing.Point(182, 138);
            this.MiddleName.MaxLength = 50;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(150, 27);
            this.MiddleName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.ForeColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(182, 105);
            this.FirstName.MaxLength = 50;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 27);
            this.FirstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя";
            // 
            // Street
            // 
            this.Street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.Street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Street.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Street.ForeColor = System.Drawing.Color.White;
            this.Street.Location = new System.Drawing.Point(338, 70);
            this.Street.MaxLength = 50;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(159, 27);
            this.Street.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Улица";
            // 
            // BirthDate
            // 
            this.BirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.BirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthDate.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDate.ForeColor = System.Drawing.Color.White;
            this.BirthDate.Location = new System.Drawing.Point(182, 171);
            this.BirthDate.MaxLength = 10;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(150, 27);
            this.BirthDate.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BirthDate, "Пример 20.03.2006");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата рождения";
            // 
            // SummonNumber
            // 
            this.SummonNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.SummonNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummonNumber.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummonNumber.ForeColor = System.Drawing.Color.White;
            this.SummonNumber.Location = new System.Drawing.Point(338, 24);
            this.SummonNumber.MaxLength = 5;
            this.SummonNumber.Name = "SummonNumber";
            this.SummonNumber.Size = new System.Drawing.Size(159, 27);
            this.SummonNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(503, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Номер повестки";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.PhoneNumber.Location = new System.Drawing.Point(182, 204);
            this.PhoneNumber.MaxLength = 16;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(150, 27);
            this.PhoneNumber.TabIndex = 9;
            this.toolTip1.SetToolTip(this.PhoneNumber, "Пример +7-999-999-99-99");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Номер телефона";
            // 
            // EducationID
            // 
            this.EducationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.EducationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationID.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationID.ForeColor = System.Drawing.Color.White;
            this.EducationID.Location = new System.Drawing.Point(182, 237);
            this.EducationID.MaxLength = 1;
            this.EducationID.Name = "EducationID";
            this.EducationID.Size = new System.Drawing.Size(150, 27);
            this.EducationID.TabIndex = 19;
            this.toolTip1.SetToolTip(this.EducationID, "1 - Среднее\r\n2 - Профессиональное\r\n3 - Высшее\r\n4 - Неоконченное высшее");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID образования";
            // 
            // Building
            // 
            this.Building.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.Building.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Building.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Building.ForeColor = System.Drawing.Color.White;
            this.Building.Location = new System.Drawing.Point(338, 105);
            this.Building.MaxLength = 3;
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(159, 27);
            this.Building.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(503, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Дом";
            // 
            // CriminalRecord
            // 
            this.CriminalRecord.AutoSize = true;
            this.CriminalRecord.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CriminalRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CriminalRecord.Location = new System.Drawing.Point(361, 201);
            this.CriminalRecord.Name = "CriminalRecord";
            this.CriminalRecord.Size = new System.Drawing.Size(275, 33);
            this.CriminalRecord.TabIndex = 21;
            this.CriminalRecord.Text = "Записи о судимости";
            this.CriminalRecord.UseVisualStyleBackColor = true;
            // 
            // CommitBtn
            // 
            this.CommitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.CommitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.CommitBtn.FlatAppearance.BorderSize = 2;
            this.CommitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitBtn.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommitBtn.ForeColor = System.Drawing.Color.White;
            this.CommitBtn.Location = new System.Drawing.Point(343, 405);
            this.CommitBtn.Name = "CommitBtn";
            this.CommitBtn.Size = new System.Drawing.Size(293, 54);
            this.CommitBtn.TabIndex = 22;
            this.CommitBtn.Text = "Создать запись";
            this.CommitBtn.UseVisualStyleBackColor = false;
            this.CommitBtn.Click += new System.EventHandler(this.CommitBtn_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.PhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Location = new System.Drawing.Point(16, 310);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(279, 242);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 23;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ImageLoad
            // 
            this.ImageLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ImageLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.ImageLoad.FlatAppearance.BorderSize = 2;
            this.ImageLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageLoad.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold);
            this.ImageLoad.ForeColor = System.Drawing.Color.White;
            this.ImageLoad.Location = new System.Drawing.Point(16, 558);
            this.ImageLoad.Name = "ImageLoad";
            this.ImageLoad.Size = new System.Drawing.Size(279, 51);
            this.ImageLoad.TabIndex = 24;
            this.ImageLoad.Text = "Загрузить изображение";
            this.ImageLoad.UseVisualStyleBackColor = false;
            this.ImageLoad.Click += new System.EventHandler(this.ImageLoad_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Фото призывника";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // ConscriptsWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(666, 621);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImageLoad);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.CommitBtn);
            this.Controls.Add(this.CriminalRecord);
            this.Controls.Add(this.EducationID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Building);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SummonNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommissariatID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConscriptsWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание записи о призывнике";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommissariatID;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SummonNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EducationID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Building;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CriminalRecord;
        private System.Windows.Forms.Button CommitBtn;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button ImageLoad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}