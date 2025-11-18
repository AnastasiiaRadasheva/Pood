namespace Pood
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ostukorv = new System.Windows.Forms.Button();
            this.ostja = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.naitabtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.maksab = new System.Windows.Forms.Button();
            this.otsToode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ostukorv);
            this.panel1.Controls.Add(this.ostja);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.naitabtn);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.maksab);
            this.panel1.Controls.Add(this.otsToode);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 194);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "(näita kategooriad ja tooted)";
            // 
            // ostukorv
            // 
            this.ostukorv.Location = new System.Drawing.Point(4, 121);
            this.ostukorv.Name = "ostukorv";
            this.ostukorv.Size = new System.Drawing.Size(73, 23);
            this.ostukorv.TabIndex = 24;
            this.ostukorv.Text = "ostukorv";
            this.ostukorv.UseVisualStyleBackColor = true;
            this.ostukorv.Click += new System.EventHandler(this.ostukorv_Click_1);
            // 
            // ostja
            // 
            this.ostja.AutoSize = true;
            this.ostja.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ostja.Location = new System.Drawing.Point(36, 2);
            this.ostja.Name = "ostja";
            this.ostja.Size = new System.Drawing.Size(142, 21);
            this.ostja.TabIndex = 23;
            this.ostja.Text = "Tere ostja!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Saada arve";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // naitabtn
            // 
            this.naitabtn.Location = new System.Drawing.Point(3, 34);
            this.naitabtn.Name = "naitabtn";
            this.naitabtn.Size = new System.Drawing.Size(75, 22);
            this.naitabtn.TabIndex = 20;
            this.naitabtn.Text = "Näita Kõik";
            this.naitabtn.UseVisualStyleBackColor = true;
            this.naitabtn.Click += new System.EventHandler(this.naitabtn_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Otsi tood";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // maksab
            // 
            this.maksab.Location = new System.Drawing.Point(4, 91);
            this.maksab.Name = "maksab";
            this.maksab.Size = new System.Drawing.Size(73, 24);
            this.maksab.TabIndex = 21;
            this.maksab.Text = "maksab";
            this.maksab.UseVisualStyleBackColor = true;
            // 
            // otsToode
            // 
            this.otsToode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsToode.Location = new System.Drawing.Point(83, 62);
            this.otsToode.Name = "otsToode";
            this.otsToode.Size = new System.Drawing.Size(130, 20);
            this.otsToode.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ostukorv;
        private System.Windows.Forms.Label ostja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button naitabtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button maksab;
        private System.Windows.Forms.TextBox otsToode;
    }
}