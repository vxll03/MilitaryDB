using System;
using System.Drawing;
using System.Windows.Forms;

namespace Military
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConscriptsBtn = new System.Windows.Forms.Button();
            this.ComissariatBtn = new System.Windows.Forms.Button();
            this.MedInspectorsBtn = new System.Windows.Forms.Button();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.MedicalExaminationBtn = new System.Windows.Forms.Button();
            this.EducationTypeBtn = new System.Windows.Forms.Button();
            this.MilitaryAssignmentsBtn = new System.Windows.Forms.Button();
            this.TroopTypesBtn = new System.Windows.Forms.Button();
            this.FitnessCategoriesBtn = new System.Windows.Forms.Button();
            this.WriteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConscriptsBtn
            // 
            this.ConscriptsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConscriptsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConscriptsBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConscriptsBtn.ForeColor = System.Drawing.Color.White;
            this.ConscriptsBtn.Location = new System.Drawing.Point(12, 93);
            this.ConscriptsBtn.Name = "ConscriptsBtn";
            this.ConscriptsBtn.Size = new System.Drawing.Size(419, 43);
            this.ConscriptsBtn.TabIndex = 0;
            this.ConscriptsBtn.Text = "Список призывников";
            this.ConscriptsBtn.UseVisualStyleBackColor = true;
            this.ConscriptsBtn.Click += new System.EventHandler(this.ConscriptsBtn_Click);
            // 
            // ComissariatBtn
            // 
            this.ComissariatBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ComissariatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComissariatBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComissariatBtn.ForeColor = System.Drawing.Color.White;
            this.ComissariatBtn.Location = new System.Drawing.Point(13, 142);
            this.ComissariatBtn.Name = "ComissariatBtn";
            this.ComissariatBtn.Size = new System.Drawing.Size(419, 43);
            this.ComissariatBtn.TabIndex = 1;
            this.ComissariatBtn.Text = "Военный комиссариат";
            this.ComissariatBtn.UseVisualStyleBackColor = true;
            this.ComissariatBtn.Click += new System.EventHandler(this.ComissariatBtn_Click);
            // 
            // MedInspectorsBtn
            // 
            this.MedInspectorsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MedInspectorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedInspectorsBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MedInspectorsBtn.ForeColor = System.Drawing.Color.White;
            this.MedInspectorsBtn.Location = new System.Drawing.Point(13, 191);
            this.MedInspectorsBtn.Name = "MedInspectorsBtn";
            this.MedInspectorsBtn.Size = new System.Drawing.Size(419, 43);
            this.MedInspectorsBtn.TabIndex = 2;
            this.MedInspectorsBtn.Text = "Мед работники";
            this.MedInspectorsBtn.UseVisualStyleBackColor = true;
            this.MedInspectorsBtn.Click += new System.EventHandler(this.MedInspectorsBtn_Click);
            // 
            // TableGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TableGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.TableGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableGridView.EnableHeadersVisualStyles = false;
            this.TableGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.TableGridView.Location = new System.Drawing.Point(457, 12);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.RowHeadersVisible = false;
            this.TableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableGridView.Size = new System.Drawing.Size(1364, 751);
            this.TableGridView.TabIndex = 3;
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ReadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.ReadBtn.FlatAppearance.BorderSize = 2;
            this.ReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadBtn.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadBtn.ForeColor = System.Drawing.Color.White;
            this.ReadBtn.Location = new System.Drawing.Point(12, 25);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(130, 43);
            this.ReadBtn.TabIndex = 4;
            this.ReadBtn.Text = "Чтение";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ChangeActionBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(302, 25);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Удаление";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.ChangeActionBtn_Click);
            // 
            // MedicalExaminationBtn
            // 
            this.MedicalExaminationBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MedicalExaminationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicalExaminationBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MedicalExaminationBtn.ForeColor = System.Drawing.Color.White;
            this.MedicalExaminationBtn.Location = new System.Drawing.Point(13, 240);
            this.MedicalExaminationBtn.Name = "MedicalExaminationBtn";
            this.MedicalExaminationBtn.Size = new System.Drawing.Size(419, 43);
            this.MedicalExaminationBtn.TabIndex = 7;
            this.MedicalExaminationBtn.Text = "Мед. осмотр";
            this.MedicalExaminationBtn.UseVisualStyleBackColor = true;
            this.MedicalExaminationBtn.Click += new System.EventHandler(this.MedicalExaminationBtn_Click);
            // 
            // EducationTypeBtn
            // 
            this.EducationTypeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EducationTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EducationTypeBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationTypeBtn.ForeColor = System.Drawing.Color.White;
            this.EducationTypeBtn.Location = new System.Drawing.Point(11, 339);
            this.EducationTypeBtn.Name = "EducationTypeBtn";
            this.EducationTypeBtn.Size = new System.Drawing.Size(420, 43);
            this.EducationTypeBtn.TabIndex = 8;
            this.EducationTypeBtn.Text = "Виды образования";
            this.EducationTypeBtn.UseVisualStyleBackColor = true;
            this.EducationTypeBtn.Click += new System.EventHandler(this.EducationTypeBtn_Click);
            // 
            // MilitaryAssignmentsBtn
            // 
            this.MilitaryAssignmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MilitaryAssignmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MilitaryAssignmentsBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MilitaryAssignmentsBtn.ForeColor = System.Drawing.Color.White;
            this.MilitaryAssignmentsBtn.Location = new System.Drawing.Point(10, 388);
            this.MilitaryAssignmentsBtn.Name = "MilitaryAssignmentsBtn";
            this.MilitaryAssignmentsBtn.Size = new System.Drawing.Size(420, 43);
            this.MilitaryAssignmentsBtn.TabIndex = 9;
            this.MilitaryAssignmentsBtn.Text = "Воинские распределения";
            this.MilitaryAssignmentsBtn.UseVisualStyleBackColor = true;
            this.MilitaryAssignmentsBtn.Click += new System.EventHandler(this.MilitaryAssignmentsBtn_Click);
            // 
            // TroopTypesBtn
            // 
            this.TroopTypesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TroopTypesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TroopTypesBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TroopTypesBtn.ForeColor = System.Drawing.Color.White;
            this.TroopTypesBtn.Location = new System.Drawing.Point(10, 486);
            this.TroopTypesBtn.Name = "TroopTypesBtn";
            this.TroopTypesBtn.Size = new System.Drawing.Size(420, 43);
            this.TroopTypesBtn.TabIndex = 11;
            this.TroopTypesBtn.Text = "Виды войск";
            this.TroopTypesBtn.UseVisualStyleBackColor = true;
            this.TroopTypesBtn.Click += new System.EventHandler(this.TroopTypesBtn_Click);
            // 
            // FitnessCategoriesBtn
            // 
            this.FitnessCategoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FitnessCategoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitnessCategoriesBtn.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FitnessCategoriesBtn.ForeColor = System.Drawing.Color.White;
            this.FitnessCategoriesBtn.Location = new System.Drawing.Point(10, 437);
            this.FitnessCategoriesBtn.Name = "FitnessCategoriesBtn";
            this.FitnessCategoriesBtn.Size = new System.Drawing.Size(420, 43);
            this.FitnessCategoriesBtn.TabIndex = 10;
            this.FitnessCategoriesBtn.Text = "Виды годностей";
            this.FitnessCategoriesBtn.UseVisualStyleBackColor = true;
            this.FitnessCategoriesBtn.Click += new System.EventHandler(this.FitnessCategoriesBtn_Click);
            // 
            // WriteBtn
            // 
            this.WriteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.WriteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.WriteBtn.FlatAppearance.BorderSize = 2;
            this.WriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteBtn.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteBtn.ForeColor = System.Drawing.Color.White;
            this.WriteBtn.Location = new System.Drawing.Point(157, 25);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(130, 43);
            this.WriteBtn.TabIndex = 12;
            this.WriteBtn.Text = "Запись";
            this.WriteBtn.UseVisualStyleBackColor = false;
            this.WriteBtn.Click += new System.EventHandler(this.ChangeActionBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1833, 775);
            this.Controls.Add(this.WriteBtn);
            this.Controls.Add(this.TroopTypesBtn);
            this.Controls.Add(this.FitnessCategoriesBtn);
            this.Controls.Add(this.MilitaryAssignmentsBtn);
            this.Controls.Add(this.EducationTypeBtn);
            this.Controls.Add(this.MedicalExaminationBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.TableGridView);
            this.Controls.Add(this.MedInspectorsBtn);
            this.Controls.Add(this.ComissariatBtn);
            this.Controls.Add(this.ConscriptsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void AdjustRowHeights()
        {
            if (this.TableGridView.Rows.Count > 0)
            {
                // Вычисляем доступную высоту для строк (без учёта заголовка)
                int availableHeight = this.TableGridView.ClientSize.Height - this.TableGridView.ColumnHeadersHeight;
                int newRowHeight = availableHeight / this.TableGridView.Rows.Count;
                foreach (DataGridViewRow row in this.TableGridView.Rows)
                {
                    row.Height = newRowHeight;
                }
            }
        }

        #endregion

        private System.Windows.Forms.Button ConscriptsBtn;
        private System.Windows.Forms.Button ComissariatBtn;
        private System.Windows.Forms.Button MedInspectorsBtn;
        private System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button MedicalExaminationBtn;
        private System.Windows.Forms.Button EducationTypeBtn;
        private System.Windows.Forms.Button MilitaryAssignmentsBtn;
        private System.Windows.Forms.Button TroopTypesBtn;
        private System.Windows.Forms.Button FitnessCategoriesBtn;
        private Button WriteBtn;
    }
}