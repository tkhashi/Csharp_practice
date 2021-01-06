
namespace PasswordCreatorUI
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfLetters = new System.Windows.Forms.NumericUpDown();
            this.Password = new System.Windows.Forms.TextBox();
            this.IsNonMark = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Execute.Location = new System.Drawing.Point(182, 73);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(274, 21);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "パスワード生成";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "文字数";
            // 
            // NumOfLetters
            // 
            this.NumOfLetters.Location = new System.Drawing.Point(101, 73);
            this.NumOfLetters.Name = "NumOfLetters";
            this.NumOfLetters.Size = new System.Drawing.Size(75, 19);
            this.NumOfLetters.TabIndex = 2;
            this.NumOfLetters.ValueChanged += new System.EventHandler(this.NumOfLetters_ValueChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(477, 19);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IsNonMark
            // 
            this.IsNonMark.AutoSize = true;
            this.IsNonMark.Location = new System.Drawing.Point(12, 183);
            this.IsNonMark.Name = "IsNonMark";
            this.IsNonMark.Size = new System.Drawing.Size(75, 17);
            this.IsNonMark.TabIndex = 4;
            this.IsNonMark.Text = "記号なし";
            this.IsNonMark.UseVisualStyleBackColor = true;
            this.IsNonMark.CheckedChanged += new System.EventHandler(this.IsNonMark_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 212);
            this.Controls.Add(this.IsNonMark);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NumOfLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Execute);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumOfLetters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumOfLetters;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox IsNonMark;
    }
}

