﻿
namespace Sanpuru0823 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.Value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jou = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exec = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(32, 20);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(141, 47);
            this.Value.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "乗";
            // 
            // Jou
            // 
            this.Jou.Location = new System.Drawing.Point(235, 20);
            this.Jou.Multiline = true;
            this.Jou.Name = "Jou";
            this.Jou.Size = new System.Drawing.Size(141, 47);
            this.Jou.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(179, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "の";
            // 
            // Exec
            // 
            this.Exec.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exec.Location = new System.Drawing.Point(435, 12);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(123, 57);
            this.Exec.TabIndex = 2;
            this.Exec.Text = "結果";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(578, 20);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(182, 47);
            this.Result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Jou);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Jou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.TextBox Result;
    }
}

