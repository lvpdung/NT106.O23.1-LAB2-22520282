﻿namespace LAB2
{
    partial class Bai01
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
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoc
            // 
            this.buttonDoc.Location = new System.Drawing.Point(136, 75);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(100, 52);
            this.buttonDoc.TabIndex = 0;
            this.buttonDoc.Text = "Đọc file";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Location = new System.Drawing.Point(136, 200);
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.Size = new System.Drawing.Size(100, 52);
            this.buttonGhi.TabIndex = 1;
            this.buttonGhi.Text = "Ghi file";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Location = new System.Drawing.Point(331, 75);
            this.textBoxKQ.Multiline = true;
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(419, 177);
            this.textBoxKQ.TabIndex = 2;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(638, 329);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(86, 40);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxKQ);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonDoc);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonGhi;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Button buttonThoat;
    }
}