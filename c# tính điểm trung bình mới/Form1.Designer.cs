namespace c__tính_điểm_trung_bình_mới
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.Button();
            this.txttoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttinh = new System.Windows.Forms.Button();
            this.txtthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(202, 96);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(75, 23);
            this.txtten.TabIndex = 1;
            this.txtten.UseVisualStyleBackColor = true;
            this.txtten.Click += new System.EventHandler(this.txtten_Click);
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(202, 142);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(75, 23);
            this.txttoan.TabIndex = 3;
            this.txttoan.UseVisualStyleBackColor = true;
            this.txttoan.Click += new System.EventHandler(this.txttoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "toán";
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(202, 187);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(75, 23);
            this.txtvan.TabIndex = 5;
            this.txtvan.UseVisualStyleBackColor = true;
            this.txtvan.Click += new System.EventHandler(this.txtvan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "văn";
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(202, 232);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(75, 23);
            this.txttb.TabIndex = 7;
            this.txttb.UseVisualStyleBackColor = true;
            this.txttb.Click += new System.EventHandler(this.txttb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "trung bình";
            // 
            // txtxl
            // 
            this.txtxl.Location = new System.Drawing.Point(202, 282);
            this.txtxl.Name = "txtxl";
            this.txtxl.Size = new System.Drawing.Size(75, 23);
            this.txtxl.TabIndex = 9;
            this.txtxl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "xếp loại ";
            // 
            // txttinh
            // 
            this.txttinh.Location = new System.Drawing.Point(230, 362);
            this.txttinh.Name = "txttinh";
            this.txttinh.Size = new System.Drawing.Size(75, 23);
            this.txttinh.TabIndex = 10;
            this.txttinh.Text = "tính";
            this.txttinh.UseVisualStyleBackColor = true;
            // 
            // txtthoat
            // 
            this.txtthoat.Location = new System.Drawing.Point(518, 362);
            this.txtthoat.Name = "txtthoat";
            this.txtthoat.Size = new System.Drawing.Size(75, 23);
            this.txtthoat.TabIndex = 11;
            this.txtthoat.Text = "thoát";
            this.txtthoat.UseVisualStyleBackColor = true;
            this.txtthoat.Click += new System.EventHandler(this.txtthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtthoat);
            this.Controls.Add(this.txttinh);
            this.Controls.Add(this.txtxl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "tính điểm trung bình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtten;
        private System.Windows.Forms.Button txttoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txttb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtxl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txttinh;
        private System.Windows.Forms.Button txtthoat;
    }
}

