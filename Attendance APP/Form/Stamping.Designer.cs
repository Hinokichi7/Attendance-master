namespace Attendance_APP
{
    partial class Stamping
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
            this.lb_employee = new System.Windows.Forms.Label();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_leaving = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_currentTime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbStampingType1 = new Attendance_APP.Contorol.CmbStampingType();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_stampingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_employee
            // 
            this.lb_employee.AutoSize = true;
            this.lb_employee.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_employee.Location = new System.Drawing.Point(12, 32);
            this.lb_employee.Name = "lb_employee";
            this.lb_employee.Size = new System.Drawing.Size(85, 24);
            this.lb_employee.TabIndex = 0;
            this.lb_employee.Text = "employee";
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_attendance.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_attendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_attendance.Location = new System.Drawing.Point(15, 157);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(100, 40);
            this.btn_attendance.TabIndex = 4;
            this.btn_attendance.Text = "出勤";
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_leaving
            // 
            this.btn_leaving.BackColor = System.Drawing.Color.LightCoral;
            this.btn_leaving.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_leaving.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_leaving.Location = new System.Drawing.Point(121, 157);
            this.btn_leaving.Name = "btn_leaving";
            this.btn_leaving.Size = new System.Drawing.Size(100, 40);
            this.btn_leaving.TabIndex = 5;
            this.btn_leaving.Text = "退勤";
            this.btn_leaving.UseVisualStyleBackColor = false;
            this.btn_leaving.Click += new System.EventHandler(this.btn_leaving_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_password.Location = new System.Drawing.Point(75, 102);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(177, 24);
            this.tb_password.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "勤務種別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "備考";
            // 
            // lb_currentTime
            // 
            this.lb_currentTime.AutoSize = true;
            this.lb_currentTime.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_currentTime.Location = new System.Drawing.Point(75, 129);
            this.lb_currentTime.Name = "lb_currentTime";
            this.lb_currentTime.Size = new System.Drawing.Size(104, 20);
            this.lb_currentTime.TabIndex = 9;
            this.lb_currentTime.Text = "currentTime";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_close.Location = new System.Drawing.Point(215, 227);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 22);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "終了";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // cmbStampingType1
            // 
            this.cmbStampingType1.Location = new System.Drawing.Point(74, 61);
            this.cmbStampingType1.Name = "cmbStampingType1";
            this.cmbStampingType1.Size = new System.Drawing.Size(104, 35);
            this.cmbStampingType1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "現在時刻";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "打刻時間";
            // 
            // lb_stampingTime
            // 
            this.lb_stampingTime.AutoSize = true;
            this.lb_stampingTime.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_stampingTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_stampingTime.Location = new System.Drawing.Point(75, 200);
            this.lb_stampingTime.Name = "lb_stampingTime";
            this.lb_stampingTime.Size = new System.Drawing.Size(0, 20);
            this.lb_stampingTime.TabIndex = 9;
            // 
            // Stamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_stampingTime);
            this.Controls.Add(this.lb_currentTime);
            this.Controls.Add(this.cmbStampingType1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_leaving);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.lb_employee);
            this.Name = "Stamping";
            this.Text = "StampingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_employee;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_leaving;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private Contorol.CmbStampingType cmbStampingType1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_currentTime;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_stampingTime;
    }
}