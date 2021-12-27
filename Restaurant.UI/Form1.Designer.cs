
namespace Restaurant.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dtpRezervasyonSaati = new System.Windows.Forms.DateTimePicker();
            this.btnRezervasyonOnay = new System.Windows.Forms.Button();
            this.cboBosMasalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masa No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezervayson Saati:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(13, 33);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(228, 29);
            this.txtAd.TabIndex = 3;
            // 
            // dtpRezervasyonSaati
            // 
            this.dtpRezervasyonSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRezervasyonSaati.Location = new System.Drawing.Point(13, 178);
            this.dtpRezervasyonSaati.Name = "dtpRezervasyonSaati";
            this.dtpRezervasyonSaati.Size = new System.Drawing.Size(228, 29);
            this.dtpRezervasyonSaati.TabIndex = 5;
            // 
            // btnRezervasyonOnay
            // 
            this.btnRezervasyonOnay.Location = new System.Drawing.Point(12, 227);
            this.btnRezervasyonOnay.Name = "btnRezervasyonOnay";
            this.btnRezervasyonOnay.Size = new System.Drawing.Size(229, 50);
            this.btnRezervasyonOnay.TabIndex = 6;
            this.btnRezervasyonOnay.Text = "Rezervaysonu Onayla";
            this.btnRezervasyonOnay.UseVisualStyleBackColor = true;
            this.btnRezervasyonOnay.Click += new System.EventHandler(this.btnRezervasyonOnay_Click);
            // 
            // cboBosMasalar
            // 
            this.cboBosMasalar.FormattingEnabled = true;
            this.cboBosMasalar.Location = new System.Drawing.Point(13, 100);
            this.cboBosMasalar.Name = "cboBosMasalar";
            this.cboBosMasalar.Size = new System.Drawing.Size(228, 29);
            this.cboBosMasalar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 294);
            this.Controls.Add(this.btnRezervasyonOnay);
            this.Controls.Add(this.dtpRezervasyonSaati);
            this.Controls.Add(this.cboBosMasalar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dtpRezervasyonSaati;
        private System.Windows.Forms.Button btnRezervasyonOnay;
        private System.Windows.Forms.ComboBox cboBosMasalar;
    }
}

