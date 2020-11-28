namespace Attendance_APP
{
    partial class AdminMenu
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
            this.NewRecord = new System.Windows.Forms.Button();
            this.EditRecord = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewRecord.Location = new System.Drawing.Point(92, 42);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(100, 40);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "新規";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // EditRecord
            // 
            this.EditRecord.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditRecord.Location = new System.Drawing.Point(92, 105);
            this.EditRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(100, 40);
            this.EditRecord.TabIndex = 1;
            this.EditRecord.Text = "編集";
            this.EditRecord.UseVisualStyleBackColor = true;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Output.Location = new System.Drawing.Point(92, 169);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 40);
            this.Output.TabIndex = 2;
            this.Output.Text = "出力";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.EditRecord);
            this.Controls.Add(this.NewRecord);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMenu";
            this.Text = "AnminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Button Output;
    }
}