namespace Attendance_APP.Admin
{
    partial class RecordMenu
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
            this.search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.cmbEmployee21 = new Attendance_APP.CmbEmployees();
            this.cmbDate2 = new Attendance_APP.CmbDate();
            this.cmbDate1 = new Attendance_APP.CmbDate();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.search.Location = new System.Drawing.Point(631, 91);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "検索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.serch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(332, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ー";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(707, 243);
            this.dataGridView1.TabIndex = 15;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(550, 378);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 16;
            this.edit.Text = "編集";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click_1);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(631, 378);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "削除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.Location = new System.Drawing.Point(469, 378);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(75, 23);
            this.NewRecord.TabIndex = 18;
            this.NewRecord.Text = "新規";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // cmbEmployee21
            // 
            this.cmbEmployee21.Location = new System.Drawing.Point(11, 12);
            this.cmbEmployee21.Name = "cmbEmployee21";
            this.cmbEmployee21.SelectedEmployees = null;
            this.cmbEmployee21.Size = new System.Drawing.Size(168, 67);
            this.cmbEmployee21.TabIndex = 23;
            // 
            // cmbDate2
            // 
            this.cmbDate2.Location = new System.Drawing.Point(356, 85);
            this.cmbDate2.Name = "cmbDate2";
            this.cmbDate2.Size = new System.Drawing.Size(269, 38);
            this.cmbDate2.TabIndex = 22;
            // 
            // cmbDate1
            // 
            this.cmbDate1.Location = new System.Drawing.Point(62, 85);
            this.cmbDate1.Name = "cmbDate1";
            this.cmbDate1.Size = new System.Drawing.Size(264, 38);
            this.cmbDate1.TabIndex = 21;
            // 
            // RecordMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 413);
            this.Controls.Add(this.cmbEmployee21);
            this.Controls.Add(this.cmbDate2);
            this.Controls.Add(this.cmbDate1);
            this.Controls.Add(this.NewRecord);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Name = "RecordMenu";
            this.Text = "EditRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button NewRecord;
        private CmbDate cmbDate1;
        private CmbDate cmbDate2;
        private CmbEmployees cmbEmployee21;
    }
}