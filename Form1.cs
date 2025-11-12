using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Pood
{
    public partial class Form1 : Form
    {
       string extension = null;

        SqlConnection connect = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        SaveFileDialog save;
        OpenFileDialog open;

        private void button7_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\source\repos\nastjRadasheva\Pood\images";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            FileInfo open_info = new FileInfo(@"C:\Users\opilane\source\repos\nastjRadasheva\Pood\images" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\images");
                
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName);
                save.Filter = "Image Files|" + "*" + Path.GetExtension(open.FileName) + "|All files|*.*";


                if (save.ShowDialog() == DialogResult.OK && Toode_txt.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    toode_pb.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud Cancel");
            }
        }

        private void Kat_box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Form popupForm;
        private void Loopilt(Image image, int r)
        {
            popupForm = new Form();
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Size = new Size(200, 200);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            popupForm.Controls.Add(pictureBox);

            System.Drawing.Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(4, r, true);
            System.Drawing.Point popupLocation = dataGridView1.PointToScreen(cellRectangle.Location);

            popupForm.Location = new System.Drawing.Point(popupLocation.X + cellRectangle.Width, popupLocation.Y);
            popupForm.Show();

        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * from KategooriaTabel", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.DataPropertyName = "Kategooria_nimetus";
            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if(!keys.Contains(kat_n))
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);

                }
            }
            dataGridView1.Columns.Add(combo_kat);
            toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\images"), "rimi.jpg"));
            connect.Close();

        }
        private void lisaKATbtn_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_box1.Items)
            {
                if (item.ToString() == Kat_box1.Text)
                {
                    on = true;
                }
            }

            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatabel (Kategooria_nimetus) VALUES (@kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@kat", Kat_box1.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_box1.Items.Clear();
                Naitakategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooria on juba olemas");
            }
        }

        private void kustutaKATbtn_Click(object sender, EventArgs e)
        {
            if (Kat_box1.SelectedItem != null)
            {
                connect.Open();
                string kat_val = Kat_box1.SelectedItem.ToString();
                command = new SqlCommand("delete from Kategooriatabel where Kategooria_nimetus=@kat ", connect);
                command.Parameters.AddWithValue("@kat", kat_val);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_box1.Items.Clear();
                Naitakategooriad();
            }
        }

        private void toode_pb_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {

        }
        byte[] imageData;
        //private void dataGridView1_MouseEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == 4)
        //    {
        //        imageData = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value as byte[];
        //        if (imageData != null)
        //        {
        //            using (MemoryStream ms = new MemoryStream(imageData))
        //            {
        //                Image image = Image.FromStream(ms);
        //                Loopilt(image, e.RowIndex);
        //            }
        //        }
        //    }

        //}

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                imageData = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        Loopilt(image, e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (popupForm != null && !popupForm.IsDisposed)
            {
                popupForm.Close();
            }
        }

        private void lisabtn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty &&
        Kogus_txt.Text.Trim() != string.Empty &&
        Hind_txt.Text.Trim() != string.Empty &&
        Kat_box1.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", Kat_box1.Text);
                    command.ExecuteNonQuery();
                    int Id = Convert.ToInt32(command.ExecuteScalar());

                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, BPilt, Kategooriaid) " +
                                             "VALUES (@toode, @kogus, @hind, @pilt, @bpilt, @kat)", connect);

                    command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", Hind_txt.Text);

                    string extension = Path.GetExtension(open.FileName); // .jpg .png jne
                    command.Parameters.AddWithValue("@pilt", Toode_txt.Text + extension);

                    byte[] imageData = File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@bpilt", imageData);

                    command.Parameters.AddWithValue("@kat", Id);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }

        public void Naitakategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("Select Id,Kategooria_nimetus FROM Kategooriatabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                if (!Kat_box1.Items.Contains(item["Kategooria_nimetus"]))
                {
                    Kat_box1.Items.Add(item["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("Delete from Kategooriatabel where Id=@id", connect);
                    command.Parameters.AddWithValue("@id", item["Id"]);
                    command.ExecuteNonQuery();
                }
            }
            connect.Close();
        }
        
    }
}
