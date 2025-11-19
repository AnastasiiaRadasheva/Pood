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
            this.otsKategooria = new System.Windows.Forms.TextBox();
            this.otsKategooriaBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ostukorv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.naitabtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.maksab = new System.Windows.Forms.Button();
            this.otsToode = new System.Windows.Forms.TextBox();
            this.ostja = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Kustuta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.otsKategooria);
            this.panel1.Controls.Add(this.otsKategooriaBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.naitabtn);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.otsToode);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 127);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // otsKategooria
            // 
            this.otsKategooria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsKategooria.Location = new System.Drawing.Point(100, 32);
            this.otsKategooria.Name = "otsKategooria";
            this.otsKategooria.Size = new System.Drawing.Size(157, 20);
            this.otsKategooria.TabIndex = 27;
            // 
            // otsKategooriaBTN
            // 
            this.otsKategooriaBTN.Location = new System.Drawing.Point(3, 32);
            this.otsKategooriaBTN.Name = "otsKategooriaBTN";
            this.otsKategooriaBTN.Size = new System.Drawing.Size(91, 23);
            this.otsKategooriaBTN.TabIndex = 26;
            this.otsKategooriaBTN.Text = "Otsi Kategooria";
            this.otsKategooriaBTN.UseVisualStyleBackColor = true;
            this.otsKategooriaBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "(näita kategooriad ja tooted poodis)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ostukorv
            // 
            this.ostukorv.Location = new System.Drawing.Point(239, 5);
            this.ostukorv.Name = "ostukorv";
            this.ostukorv.Size = new System.Drawing.Size(91, 23);
            this.ostukorv.TabIndex = 24;
            this.ostukorv.Text = "Ostukorv";
            this.ostukorv.UseVisualStyleBackColor = true;
            this.ostukorv.Click += new System.EventHandler(this.ostukorv_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Saada arve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // naitabtn
            // 
            this.naitabtn.Location = new System.Drawing.Point(3, 61);
            this.naitabtn.Name = "naitabtn";
            this.naitabtn.Size = new System.Drawing.Size(91, 22);
            this.naitabtn.TabIndex = 20;
            this.naitabtn.Text = "Näita Kõik";
            this.naitabtn.UseVisualStyleBackColor = true;
            this.naitabtn.Click += new System.EventHandler(this.naitabtn_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Otsi tood";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // maksab
            // 
            this.maksab.Location = new System.Drawing.Point(178, 209);
            this.maksab.Name = "maksab";
            this.maksab.Size = new System.Drawing.Size(91, 24);
            this.maksab.TabIndex = 21;
            this.maksab.Text = "Maksab toode";
            this.maksab.UseVisualStyleBackColor = true;
            this.maksab.Click += new System.EventHandler(this.maksab_Click);
            // 
            // otsToode
            // 
            this.otsToode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsToode.Location = new System.Drawing.Point(100, 3);
            this.otsToode.Name = "otsToode";
            this.otsToode.Size = new System.Drawing.Size(157, 20);
            this.otsToode.TabIndex = 18;
            this.otsToode.TextChanged += new System.EventHandler(this.otsToode_TextChanged);
            // 
            // ostja
            // 
            this.ostja.AutoSize = true;
            this.ostja.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ostja.Location = new System.Drawing.Point(74, 10);
            this.ostja.Name = "ostja";
            this.ostja.Size = new System.Drawing.Size(142, 21);
            this.ostja.TabIndex = 23;
            this.ostja.Text = "Tere ostja!";
            this.ostja.Click += new System.EventHandler(this.ostja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ladu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 404);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pood";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(257, 199);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Kustuta
            // 
            this.Kustuta.Location = new System.Drawing.Point(15, 209);
            this.Kustuta.Name = "Kustuta";
            this.Kustuta.Size = new System.Drawing.Size(91, 24);
            this.Kustuta.TabIndex = 28;
            this.Kustuta.Text = "Kustuta Toode";
            this.Kustuta.UseVisualStyleBackColor = true;
            this.Kustuta.Click += new System.EventHandler(this.Kustuta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.Kustuta);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ostukorv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ostja);
            this.Controls.Add(this.maksab);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button otsKategooriaBTN;
        private System.Windows.Forms.TextBox otsKategooria;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Kustuta;
    }
}