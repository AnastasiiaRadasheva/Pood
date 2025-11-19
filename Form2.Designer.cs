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
            this.button1 = new System.Windows.Forms.Button();
            this.naitabtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.otsToode = new System.Windows.Forms.TextBox();
            this.maksab = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 156);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // otsKategooria
            // 
            this.otsKategooria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsKategooria.Location = new System.Drawing.Point(133, 39);
            this.otsKategooria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otsKategooria.Name = "otsKategooria";
            this.otsKategooria.Size = new System.Drawing.Size(209, 22);
            this.otsKategooria.TabIndex = 27;
            // 
            // otsKategooriaBTN
            // 
            this.otsKategooriaBTN.Location = new System.Drawing.Point(4, 39);
            this.otsKategooriaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otsKategooriaBTN.Name = "otsKategooriaBTN";
            this.otsKategooriaBTN.Size = new System.Drawing.Size(121, 28);
            this.otsKategooriaBTN.TabIndex = 26;
            this.otsKategooriaBTN.Text = "Otsi Kategooria";
            this.otsKategooriaBTN.UseVisualStyleBackColor = true;
            this.otsKategooriaBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "(näita kategooriad ja tooted poodis)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Saada arve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // naitabtn
            // 
            this.naitabtn.Location = new System.Drawing.Point(4, 75);
            this.naitabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naitabtn.Name = "naitabtn";
            this.naitabtn.Size = new System.Drawing.Size(121, 27);
            this.naitabtn.TabIndex = 20;
            this.naitabtn.Text = "Näita Kõik";
            this.naitabtn.UseVisualStyleBackColor = true;
            this.naitabtn.Click += new System.EventHandler(this.naitabtn_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 28);
            this.button8.TabIndex = 17;
            this.button8.Text = "Otsi tood";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // otsToode
            // 
            this.otsToode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsToode.Location = new System.Drawing.Point(133, 4);
            this.otsToode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otsToode.Name = "otsToode";
            this.otsToode.Size = new System.Drawing.Size(209, 22);
            this.otsToode.TabIndex = 18;
            this.otsToode.TextChanged += new System.EventHandler(this.otsToode_TextChanged);
            // 
            // maksab
            // 
            this.maksab.Location = new System.Drawing.Point(237, 257);
            this.maksab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maksab.Name = "maksab";
            this.maksab.Size = new System.Drawing.Size(121, 30);
            this.maksab.TabIndex = 21;
            this.maksab.Text = "Maksab toode";
            this.maksab.UseVisualStyleBackColor = true;
            this.maksab.Click += new System.EventHandler(this.maksab_Click);
            // 
            // ostja
            // 
            this.ostja.AutoSize = true;
            this.ostja.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ostja.Location = new System.Drawing.Point(99, 12);
            this.ostja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ostja.Name = "ostja";
            this.ostja.Size = new System.Drawing.Size(177, 27);
            this.ostja.TabIndex = 23;
            this.ostja.Text = "Tere ostja!";
            this.ostja.Click += new System.EventHandler(this.ostja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ladu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(599, 497);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pood";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 294);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(343, 245);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Kustuta
            // 
            this.Kustuta.Location = new System.Drawing.Point(20, 257);
            this.Kustuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kustuta.Name = "Kustuta";
            this.Kustuta.Size = new System.Drawing.Size(121, 30);
            this.Kustuta.TabIndex = 28;
            this.Kustuta.Text = "Kustuta Toode";
            this.Kustuta.UseVisualStyleBackColor = true;
            this.Kustuta.Click += new System.EventHandler(this.Kustuta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 554);
            this.Controls.Add(this.Kustuta);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ostja);
            this.Controls.Add(this.maksab);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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