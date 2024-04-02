namespace LAB2
{
    partial class Bai05
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
            this.buttonXuat = new System.Windows.Forms.Button();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.textBoxGhi = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoc
            // 
            this.buttonDoc.Location = new System.Drawing.Point(43, 35);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(124, 40);
            this.buttonDoc.TabIndex = 0;
            this.buttonDoc.Text = "Đọc dữ liệu";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(444, 35);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(124, 40);
            this.buttonXuat.TabIndex = 1;
            this.buttonXuat.Text = "Ghi dữ liệu";
            this.buttonXuat.UseVisualStyleBackColor = true;
            this.buttonXuat.Click += new System.EventHandler(this.buttonXuat_Click);
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(43, 103);
            this.textBoxDoc.Multiline = true;
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(304, 258);
            this.textBoxDoc.TabIndex = 2;
            // 
            // textBoxGhi
            // 
            this.textBoxGhi.Location = new System.Drawing.Point(444, 103);
            this.textBoxGhi.Multiline = true;
            this.textBoxGhi.Name = "textBoxGhi";
            this.textBoxGhi.Size = new System.Drawing.Size(304, 258);
            this.textBoxGhi.TabIndex = 3;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(621, 397);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(106, 41);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxGhi);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.buttonDoc);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonXuat;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.TextBox textBoxGhi;
        private System.Windows.Forms.Button buttonThoat;
    }
}