namespace LAB2
{
    partial class Bai03
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
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Location = new System.Drawing.Point(534, 90);
            this.textBoxKQ.Multiline = true;
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(254, 183);
            this.textBoxKQ.TabIndex = 2;
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(29, 90);
            this.textBoxDoc.Multiline = true;
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(254, 183);
            this.textBoxDoc.TabIndex = 3;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(611, 328);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(133, 40);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDoc
            // 
            this.buttonDoc.Location = new System.Drawing.Point(344, 131);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(133, 40);
            this.buttonDoc.TabIndex = 5;
            this.buttonDoc.Text = "Đọc";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonTinh
            // 
            this.buttonTinh.Location = new System.Drawing.Point(344, 205);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(133, 40);
            this.buttonTinh.TabIndex = 6;
            this.buttonTinh.Text = "Tính";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.buttonDoc);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.textBoxKQ);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonTinh;
    }
}