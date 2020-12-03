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
            this.EditRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewMaster = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditRecord
            // 
            this.EditRecord.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditRecord.Location = new System.Drawing.Point(75, 77);
            this.EditRecord.Margin = new System.Windows.Forms.Padding(4);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(130, 40);
            this.EditRecord.TabIndex = 1;
            this.EditRecord.Text = "レコード編集";
            this.EditRecord.UseVisualStyleBackColor = true;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 3;
            // 
            // NewMaster
            // 
            this.NewMaster.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewMaster.Location = new System.Drawing.Point(75, 125);
            this.NewMaster.Margin = new System.Windows.Forms.Padding(4);
            this.NewMaster.Name = "NewMaster";
            this.NewMaster.Size = new System.Drawing.Size(130, 40);
            this.NewMaster.TabIndex = 2;
            this.NewMaster.Text = "マスタ編集";
            this.NewMaster.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Output.Location = new System.Drawing.Point(75, 173);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(130, 40);
            this.Output.TabIndex = 4;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewMaster);
            this.Controls.Add(this.EditRecord);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenu";
            this.Text = "AnminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewMaster;
        private System.Windows.Forms.Button Output;
    }
}