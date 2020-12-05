
namespace Attendance_APP
{
    partial class CmbEmployee2
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.cmb_employee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_department
            // 
            this.cmb_department.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(41, 3);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(121, 26);
            this.cmb_department.TabIndex = 0;
            this.cmb_department.SelectionChangeCommitted += new System.EventHandler(this.cmb_department_SelectionChangeCommitted);
            // 
            // cmb_employee
            // 
            this.cmb_employee.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_employee.FormattingEnabled = true;
            this.cmb_employee.Location = new System.Drawing.Point(41, 35);
            this.cmb_employee.Name = "cmb_employee";
            this.cmb_employee.Size = new System.Drawing.Size(121, 26);
            this.cmb_employee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "部署";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // CmbEmployee2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_employee);
            this.Controls.Add(this.cmb_department);
            this.Name = "CmbEmployee2";
            this.Size = new System.Drawing.Size(168, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.ComboBox cmb_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
