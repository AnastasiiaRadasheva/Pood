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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Kat_box1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toode_pb
            // 
            this.toode_pb.Location = new System.Drawing.Point(22, 21);
            this.toode_pb.Name = "toode_pb";
            this.toode_pb.Size = new System.Drawing.Size(332, 188);
            this.toode_pb.TabIndex = 0;
            this.toode_pb.TabStop = false;
            // 
            // toode
            // 
            this.toode.AutoSize = true;
            this.toode.Location = new System.Drawing.Point(527, 37);
            this.toode.Name = "toode";
            this.toode.Size = new System.Drawing.Size(41, 13);
            this.toode.TabIndex = 1;
            this.toode.Text = "Toode:";
            this.toode.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hind:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 131);
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
            this.dataGridView1.Size = new System.Drawing.Size(545, 194);
            this.dataGridView1.TabIndex = 5;
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(590, 37);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(212, 20);
            this.Toode_txt.TabIndex = 6;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(589, 70);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(211, 20);
            this.Kogus_txt.TabIndex = 7;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(589, 101);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(211, 20);
            this.Hind_txt.TabIndex = 8;
            // 
            // lisaKATbtn
            // 
            this.lisaKATbtn.Location = new System.Drawing.Point(589, 189);
            this.lisaKATbtn.Name = "lisaKATbtn";
            this.lisaKATbtn.Size = new System.Drawing.Size(99, 34);
            this.lisaKATbtn.TabIndex = 10;
            this.lisaKATbtn.Text = "Lisa kategooriat";
            this.lisaKATbtn.UseVisualStyleBackColor = true;
            this.lisaKATbtn.Click += new System.EventHandler(this.lisaKATbtn_Click);
            // 
            // kustutaKATbtn
            // 
            this.kustutaKATbtn.Location = new System.Drawing.Point(704, 188);
            this.kustutaKATbtn.Name = "kustutaKATbtn";
            this.kustutaKATbtn.Size = new System.Drawing.Size(95, 34);
            this.kustutaKATbtn.TabIndex = 11;
            this.kustutaKATbtn.Text = "Kustuta kategooriat";
            this.kustutaKATbtn.UseVisualStyleBackColor = true;
            this.kustutaKATbtn.Click += new System.EventHandler(this.kustutaKATbtn_Click);
            // 
            // lisabtn
            // 
            this.lisabtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lisabtn.Location = new System.Drawing.Point(589, 244);
            this.lisabtn.Name = "lisabtn";
            this.lisabtn.Size = new System.Drawing.Size(75, 23);
            this.lisabtn.TabIndex = 12;
            this.lisabtn.Text = "Lisa";
            this.lisabtn.UseVisualStyleBackColor = true;
            // 
            // uuendabtn
            // 
            this.uuendabtn.Location = new System.Drawing.Point(590, 273);
            this.uuendabtn.Name = "uuendabtn";
            this.uuendabtn.Size = new System.Drawing.Size(75, 23);
            this.uuendabtn.TabIndex = 13;
            this.uuendabtn.Text = "Uuenda";
            this.uuendabtn.UseVisualStyleBackColor = true;
            // 
            // kustutabtn
            // 
            this.kustutabtn.Location = new System.Drawing.Point(590, 302);
            this.kustutabtn.Name = "kustutabtn";
            this.kustutabtn.Size = new System.Drawing.Size(75, 27);
            this.kustutabtn.TabIndex = 14;
            this.kustutabtn.Text = "Kustuta";
            this.kustutabtn.UseVisualStyleBackColor = true;
            // 
            // puhustaBTN
            // 
            this.puhustaBTN.Location = new System.Drawing.Point(724, 159);
            this.puhustaBTN.Name = "puhustaBTN";
            this.puhustaBTN.Size = new System.Drawing.Size(75, 23);
            this.puhustaBTN.TabIndex = 15;
            this.puhustaBTN.Text = "Puhusta";
            this.puhustaBTN.UseVisualStyleBackColor = true;
            this.puhustaBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // otsifailBTN
            // 
            this.otsifailBTN.Location = new System.Drawing.Point(22, 215);
            this.otsifailBTN.Name = "otsifailBTN";
            this.otsifailBTN.Size = new System.Drawing.Size(75, 23);
            this.otsifailBTN.TabIndex = 16;
            this.otsifailBTN.Text = "Otsi fail";
            this.otsifailBTN.UseVisualStyleBackColor = true;
            this.otsifailBTN.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(114, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Pood";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(195, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 18;
            // 
            // Kat_box1
            // 
            this.Kat_box1.FormattingEnabled = true;
            this.Kat_box1.Location = new System.Drawing.Point(589, 132);
            this.Kat_box1.Name = "Kat_box1";
            this.Kat_box1.Size = new System.Drawing.Size(209, 21);
            this.Kat_box1.TabIndex = 19;
            this.Kat_box1.SelectedIndexChanged += new System.EventHandler(this.Kat_box1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.Kat_box1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button8);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox Kat_box1;
    }
}

