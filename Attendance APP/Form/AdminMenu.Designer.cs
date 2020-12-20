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
            this.EditMaester = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditRecord
            // 
            this.EditRecord.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditRecord.Location = new System.Drawing.Point(71, 45);
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
            // EditMaester
            // 
            this.EditMaester.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditMaester.Location = new System.Drawing.Point(71, 93);
            this.EditMaester.Margin = new System.Windows.Forms.Padding(4);
            this.EditMaester.Name = "EditMaester";
            this.EditMaester.Size = new System.Drawing.Size(130, 40);
            this.EditMaester.TabIndex = 2;
            this.EditMaester.Text = "マスタ編集";
            this.EditMaester.UseVisualStyleBackColor = true;
            this.EditMaester.Click += new System.EventHandler(this.EditMaester_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Output.Location = new System.Drawing.Point(71, 141);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(130, 40);
            this.Output.TabIndex = 4;
            this.Output.Text = "ファイル出力";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Input.Location = new System.Drawing.Point(71, 189);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(130, 40);
            this.Input.TabIndex = 5;
            this.Input.Text = "ファイル読込";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditMaester);
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
        private System.Windows.Forms.Button EditMaester;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button Input;
    }
}