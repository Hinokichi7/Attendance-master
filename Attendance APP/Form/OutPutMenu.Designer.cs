namespace Attendance_APP
{
    partial class OutPutMenu
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
            this.outputCsv = new System.Windows.Forms.Button();
            this.cmbDate1 = new Attendance_APP.CmbDate();
            this.cmbDate2 = new Attendance_APP.CmbDate();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEmployee21 = new Attendance_APP.CmbEmployees();
            this.searchRecord = new System.Windows.Forms.Button();
            this.serchMaster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputCsv
            // 
            this.outputCsv.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputCsv.Location = new System.Drawing.Point(637, 426);
            this.outputCsv.Name = "outputCsv";
            this.outputCsv.Size = new System.Drawing.Size(75, 23);
            this.outputCsv.TabIndex = 0;
            this.outputCsv.Text = "出力";
            this.outputCsv.UseVisualStyleBackColor = true;
            this.outputCsv.Click += new System.EventHandler(this.outputCsv_Click);
            // 
            // cmbDate1
            // 
            this.cmbDate1.Location = new System.Drawing.Point(63, 104);
            this.cmbDate1.Name = "cmbDate1";
            this.cmbDate1.Size = new System.Drawing.Size(281, 38);
            this.cmbDate1.TabIndex = 10;
            // 
            // cmbDate2
            // 
            this.cmbDate2.Location = new System.Drawing.Point(350, 104);
            this.cmbDate2.Name = "cmbDate2";
            this.cmbDate2.Size = new System.Drawing.Size(281, 38);
            this.cmbDate2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(325, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "ー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(13, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "年月日";
            // 
            // cmbEmployee21
            // 
            this.cmbEmployee21.Location = new System.Drawing.Point(12, 12);
            this.cmbEmployee21.Name = "cmbEmployee21";
            this.cmbEmployee21.SelectedEmployees = null;
            this.cmbEmployee21.Size = new System.Drawing.Size(168, 67);
            this.cmbEmployee21.TabIndex = 24;
            // 
            // searchRecord
            // 
            this.searchRecord.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchRecord.Location = new System.Drawing.Point(594, 148);
            this.searchRecord.Name = "searchRecord";
            this.searchRecord.Size = new System.Drawing.Size(118, 23);
            this.searchRecord.TabIndex = 25;
            this.searchRecord.Text = "レコード検索";
            this.searchRecord.UseVisualStyleBackColor = true;
            this.searchRecord.Click += new System.EventHandler(this.searchRecord_Click);
            // 
            // serchMaster
            // 
            this.serchMaster.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serchMaster.Location = new System.Drawing.Point(594, 56);
            this.serchMaster.Name = "serchMaster";
            this.serchMaster.Size = new System.Drawing.Size(118, 23);
            this.serchMaster.TabIndex = 25;
            this.serchMaster.Text = "マスター検索";
            this.serchMaster.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(5, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(707, 243);
            this.dataGridView1.TabIndex = 26;
            // 
            // OutPutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.serchMaster);
            this.Controls.Add(this.searchRecord);
            this.Controls.Add(this.cmbEmployee21);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDate2);
            this.Controls.Add(this.cmbDate1);
            this.Controls.Add(this.outputCsv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OutPutMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button outputCsv;
        private CmbDate cmbDate1;
        private CmbDate cmbDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private CmbEmployees cmbEmployee21;
        private System.Windows.Forms.Button searchRecord;
        private System.Windows.Forms.Button serchMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}