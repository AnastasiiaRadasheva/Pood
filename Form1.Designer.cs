namespace Pood
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
            this.components = new System.ComponentModel.Container();
            this.toode_pb = new System.Windows.Forms.PictureBox();
            this.toode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.lisaKATbtn = new System.Windows.Forms.Button();
            this.kustutaKATbtn = new System.Windows.Forms.Button();
            this.lisabtn = new System.Windows.Forms.Button();
            this.uuendabtn = new System.Windows.Forms.Button();
            this.kustutabtn = new System.Windows.Forms.Button();
            this.puhustaBTN = new System.Windows.Forms.Button();
            this.otsifailBTN = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.otsToode = new System.Windows.Forms.TextBox();
            this.Kat_box1 = new System.Windows.Forms.ComboBox();
            this.naitabtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toode_pb
            // 
            this.toode_pb.Location = new System.Drawing.Point(22, 37);
            this.toode_pb.Name = "toode_pb";
            this.toode_pb.Size = new System.Drawing.Size(584, 172);
            this.toode_pb.TabIndex = 0;
            this.toode_pb.TabStop = false;
            this.toode_pb.Click += new System.EventHandler(this.toode_pb_Click);
            // 
            // toode
            // 
            this.toode.AutoSize = true;
            this.toode.Location = new System.Drawing.Point(706, 21);
            this.toode.Name = "toode";
            this.toode.Size = new System.Drawing.Size(41, 13);
            this.toode.TabIndex = 1;
            this.toode.Text = "Toode:";
            this.toode.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hind:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategooriad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 194);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(707, 37);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(178, 20);
            this.Toode_txt.TabIndex = 6;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(707, 81);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(177, 20);
            this.Kogus_txt.TabIndex = 7;
            this.Kogus_txt.TextChanged += new System.EventHandler(this.Kogus_txt_TextChanged);
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(707, 120);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(178, 20);
            this.Hind_txt.TabIndex = 8;
            this.Hind_txt.TextChanged += new System.EventHandler(this.Hind_txt_TextChanged);
            // 
            // lisaKATbtn
            // 
            this.lisaKATbtn.Location = new System.Drawing.Point(612, 127);
            this.lisaKATbtn.Name = "lisaKATbtn";
            this.lisaKATbtn.Size = new System.Drawing.Size(81, 37);
            this.lisaKATbtn.TabIndex = 10;
            this.lisaKATbtn.Text = "Lisa kategooriat";
            this.lisaKATbtn.UseVisualStyleBackColor = true;
            this.lisaKATbtn.Click += new System.EventHandler(this.lisaKATbtn_Click);
            // 
            // kustutaKATbtn
            // 
            this.kustutaKATbtn.Location = new System.Drawing.Point(612, 170);
            this.kustutaKATbtn.Name = "kustutaKATbtn";
            this.kustutaKATbtn.Size = new System.Drawing.Size(81, 39);
            this.kustutaKATbtn.TabIndex = 11;
            this.kustutaKATbtn.Text = "Kustuta kategooriat";
            this.kustutaKATbtn.UseVisualStyleBackColor = true;
            this.kustutaKATbtn.Click += new System.EventHandler(this.kustutaKATbtn_Click);
            // 
            // lisabtn
            // 
            this.lisabtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lisabtn.Location = new System.Drawing.Point(707, 186);
            this.lisabtn.Name = "lisabtn";
            this.lisabtn.Size = new System.Drawing.Size(78, 29);
            this.lisabtn.TabIndex = 12;
            this.lisabtn.Text = "Lisa";
            this.lisabtn.UseVisualStyleBackColor = true;
            this.lisabtn.Click += new System.EventHandler(this.lisabtn_Click);
            // 
            // uuendabtn
            // 
            this.uuendabtn.Location = new System.Drawing.Point(612, 37);
            this.uuendabtn.Name = "uuendabtn";
            this.uuendabtn.Size = new System.Drawing.Size(80, 28);
            this.uuendabtn.TabIndex = 13;
            this.uuendabtn.Text = "Uuenda";
            this.uuendabtn.UseVisualStyleBackColor = true;
            this.uuendabtn.Click += new System.EventHandler(this.uuendabtn_Click);
            // 
            // kustutabtn
            // 
            this.kustutabtn.Location = new System.Drawing.Point(611, 73);
            this.kustutabtn.Name = "kustutabtn";
            this.kustutabtn.Size = new System.Drawing.Size(82, 28);
            this.kustutabtn.TabIndex = 14;
            this.kustutabtn.Text = "Kustuta";
            this.kustutabtn.UseVisualStyleBackColor = true;
            this.kustutabtn.Click += new System.EventHandler(this.kustutabtn_Click);
            // 
            // puhustaBTN
            // 
            this.puhustaBTN.Location = new System.Drawing.Point(790, 186);
            this.puhustaBTN.Name = "puhustaBTN";
            this.puhustaBTN.Size = new System.Drawing.Size(93, 29);
            this.puhustaBTN.TabIndex = 15;
            this.puhustaBTN.Text = "Puhusta Kõik";
            this.puhustaBTN.UseVisualStyleBackColor = true;
            this.puhustaBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // otsifailBTN
            // 
            this.otsifailBTN.Location = new System.Drawing.Point(22, 212);
            this.otsifailBTN.Name = "otsifailBTN";
            this.otsifailBTN.Size = new System.Drawing.Size(75, 28);
            this.otsifailBTN.TabIndex = 16;
            this.otsifailBTN.Text = "Otsi fail";
            this.otsifailBTN.UseVisualStyleBackColor = true;
            this.otsifailBTN.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Otsi tood";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // otsToode
            // 
            this.otsToode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otsToode.Location = new System.Drawing.Point(88, 18);
            this.otsToode.Name = "otsToode";
            this.otsToode.Size = new System.Drawing.Size(66, 20);
            this.otsToode.TabIndex = 18;
            this.otsToode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Kat_box1
            // 
            this.Kat_box1.FormattingEnabled = true;
            this.Kat_box1.Location = new System.Drawing.Point(709, 159);
            this.Kat_box1.Name = "Kat_box1";
            this.Kat_box1.Size = new System.Drawing.Size(175, 21);
            this.Kat_box1.TabIndex = 19;
            this.Kat_box1.SelectedIndexChanged += new System.EventHandler(this.Kat_box1_SelectedIndexChanged);
            // 
            // naitabtn
            // 
            this.naitabtn.Location = new System.Drawing.Point(7, 47);
            this.naitabtn.Name = "naitabtn";
            this.naitabtn.Size = new System.Drawing.Size(75, 22);
            this.naitabtn.TabIndex = 20;
            this.naitabtn.Text = "Näita Kõik";
            this.naitabtn.UseVisualStyleBackColor = true;
            this.naitabtn.Click += new System.EventHandler(this.naitabtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.otsToode);
            this.panel1.Controls.Add(this.naitabtn);
            this.panel1.Location = new System.Drawing.Point(709, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 194);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "(näita kategooriad ja tooted)";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Pood";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ladu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Kat_box1);
            this.Controls.Add(this.otsifailBTN);
            this.Controls.Add(this.puhustaBTN);
            this.Controls.Add(this.kustutabtn);
            this.Controls.Add(this.uuendabtn);
            this.Controls.Add(this.lisabtn);
            this.Controls.Add(this.kustutaKATbtn);
            this.Controls.Add(this.lisaKATbtn);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toode);
            this.Controls.Add(this.toode_pb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toode_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toode_pb;
        private System.Windows.Forms.Label toode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Button lisaKATbtn;
        private System.Windows.Forms.Button kustutaKATbtn;
        private System.Windows.Forms.Button lisabtn;
        private System.Windows.Forms.Button uuendabtn;
        private System.Windows.Forms.Button kustutabtn;
        private System.Windows.Forms.Button puhustaBTN;
        private System.Windows.Forms.Button otsifailBTN;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox otsToode;
        private System.Windows.Forms.ComboBox Kat_box1;
        private System.Windows.Forms.Button naitabtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

