﻿namespace Attendance_APP
{
    partial class NewRecord
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
            this.cmb_startHour = new System.Windows.Forms.ComboBox();
            this.cmb_startMinut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_endHour = new System.Windows.Forms.ComboBox();
            this.cmb_endMinut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddNewRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.TextBox();
            this.cmbStampingType1 = new Attendance_APP.Contorol.CmbStampingType();
            this.cmbEmployee1 = new Attendance_APP.CmbEmployee();
            this.cmbDate1 = new Attendance_APP.CmbDate();
            this.SuspendLayout();
            // 
            // cmb_startHour
            // 
            this.cmb_startHour.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_startHour.FormattingEnabled = true;
            this.cmb_startHour.Location = new System.Drawing.Point(102, 189);
            this.cmb_startHour.Name = "cmb_startHour";
            this.cmb_startHour.Size = new System.Drawing.Size(45, 25);
            this.cmb_startHour.TabIndex = 0;
            // 
            // cmb_startMinut
            // 
            this.cmb_startMinut.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_startMinut.FormattingEnabled = true;
            this.cmb_startMinut.Location = new System.Drawing.Point(169, 190);
            this.cmb_startMinut.Name = "cmb_startMinut";
            this.cmb_startMinut.Size = new System.Drawing.Size(45, 25);
            this.cmb_startMinut.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(147, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(220, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "～";
            // 
            // cmb_endHour
            // 
            this.cmb_endHour.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_endHour.FormattingEnabled = true;
            this.cmb_endHour.Location = new System.Drawing.Point(253, 189);
            this.cmb_endHour.Name = "cmb_endHour";
            this.cmb_endHour.Size = new System.Drawing.Size(45, 25);
            this.cmb_endHour.TabIndex = 0;
            // 
            // cmb_endMinut
            // 
            this.cmb_endMinut.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_endMinut.FormattingEnabled = true;
            this.cmb_endMinut.Location = new System.Drawing.Point(326, 189);
            this.cmb_endMinut.Name = "cmb_endMinut";
            this.cmb_endMinut.Size = new System.Drawing.Size(45, 25);
            this.cmb_endMinut.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(304, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = ":";
            // 
            // AddNewRecord
            // 
            this.AddNewRecord.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddNewRecord.Location = new System.Drawing.Point(151, 279);
            this.AddNewRecord.Name = "AddNewRecord";
            this.AddNewRecord.Size = new System.Drawing.Size(123, 32);
            this.AddNewRecord.TabIndex = 2;
            this.AddNewRecord.Text = "新規打刻";
            this.AddNewRecord.UseVisualStyleBackColor = true;
            this.AddNewRecord.Click += new System.EventHandler(this.AddNewRecord_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "氏名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(24, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "部署名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(24, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "年月日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(24, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "勤務種別";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(24, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "時間";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(24, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "備考";
            // 
            // remark
            // 
            this.remark.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.remark.Location = new System.Drawing.Point(101, 236);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(276, 25);
            this.remark.TabIndex = 4;
            // 
            // cmbStampingType1
            // 
            this.cmbStampingType1.Location = new System.Drawing.Point(101, 142);
            this.cmbStampingType1.Name = "cmbStampingType1";
            this.cmbStampingType1.Size = new System.Drawing.Size(104, 35);
            this.cmbStampingType1.TabIndex = 7;
            // 
            // cmbEmployee1
            // 
            this.cmbEmployee1.Location = new System.Drawing.Point(102, 16);
            this.cmbEmployee1.Name = "cmbEmployee1";
            this.cmbEmployee1.Size = new System.Drawing.Size(147, 79);
            this.cmbEmployee1.TabIndex = 6;
            // 
            // cmbDate1
            // 
            this.cmbDate1.Location = new System.Drawing.Point(101, 98);
            this.cmbDate1.Name = "cmbDate1";
            this.cmbDate1.Size = new System.Drawing.Size(281, 38);
            this.cmbDate1.TabIndex = 5;
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 345);
            this.Controls.Add(this.cmbStampingType1);
            this.Controls.Add(this.cmbEmployee1);
            this.Controls.Add(this.cmbDate1);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.AddNewRecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_endMinut);
            this.Controls.Add(this.cmb_endHour);
            this.Controls.Add(this.cmb_startMinut);
            this.Controls.Add(this.cmb_startHour);
            this.Name = "NewRecord";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_startHour;
        private System.Windows.Forms.ComboBox cmb_startMinut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_endHour;
        private System.Windows.Forms.ComboBox cmb_endMinut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddNewRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox remark;
        private CmbDate cmbDate1;
        private CmbEmployee cmbEmployee1;
        private Contorol.CmbStampingType cmbStampingType1;
    }
}