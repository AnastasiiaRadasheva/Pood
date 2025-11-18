using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(otsToode.Text))
            {
                MessageBox.Show("Введите название товара!");
                return;
            }

            try
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Toodenimetus FROM ToodeTabel WHERE Toodenimetus LIKE @name",
                    connect);

                cmd.Parameters.AddWithValue("@name", "%" + otsToode.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                connect.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено!");
                    return;
                }

                // создаем всплывающую таблицу
                Form popup = new Form();
                popup.Text = "Результаты поиска";
                popup.Size = new Size(300, 300);

                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.DataSource = dt;
                popup.Controls.Add(dgv);

                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void naitabtn_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 500);

            // Создаем TabControl
            TabControl kategooriad = new TabControl();
            kategooriad.Name = "Kategooriad";
            kategooriad.Width = 450;
            kategooriad.Height = this.Height;
            kategooriad.Location = new System.Drawing.Point(750, 0);

            connect.Open();

            // Загружаем категории
            SqlDataAdapter adapter_kategooria = new SqlDataAdapter(
                "SELECT Id, Kategooria_nimetus FROM KategooriaTabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);

            // ImageList для вкладок
            ImageList iconsList = new ImageList();
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(25, 25);

            int i = 0;
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                // Добавляем вкладку
                kategooriad.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
                kategooriad.TabPages[i].ImageIndex = i;

                // Получаем Id категории
                int kat_Id = (int)nimetus["Id"];

                // Загружаем файлы прямо здесь
                SqlDataAdapter adapter_failid = new SqlDataAdapter(
                    "SELECT Pilt FROM ToodeTabel WHERE Kategooriad=@id", connect);
                adapter_failid.SelectCommand.Parameters.AddWithValue("@id", kat_Id);
                DataTable dt_failid = new DataTable();
                adapter_failid.Fill(dt_failid);

                int r = 0;
                int c = 0;

                foreach (DataRow fail in dt_failid.Rows)
                {
                    if (fail["Pilt"] != DBNull.Value)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail["Pilt"].ToString());
                        pictureBox.Width = pictureBox.Height = 100;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new System.Drawing.Point(c, r);

                        c += 100 + 2; // следующий элемент справа
                        kategooriad.TabPages[i].Controls.Add(pictureBox);
                    }
                }

                i++;
            }

            kategooriad.ImageList = iconsList;
            connect.Close();
            this.Controls.Add(kategooriad);

        }
        private TabControl ostukorvTabControl;
        private void ostukorv_Click_1(object sender, EventArgs e)
        {

            // Создаем TabControl
            TabControl kategooriad = new TabControl();
            kategooriad.Name = "Kategooriad";
            kategooriad.Width = 400;
            kategooriad.Height = 400;
            kategooriad.Location = new System.Drawing.Point(310, 0);

            connect.Open();

            // Загружаем категории
            SqlDataAdapter adapter_kategooria = new SqlDataAdapter(
                "SELECT Id, Kategooria_nimetus FROM KategooriaTabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);

            // ImageList для вкладок
            ImageList iconsList = new ImageList();
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(25, 25);

            kategooriad.TabPages.Add(("Kategooria_nimetus"));
            int i = 0;
            //foreach (DataRow nimetus in dt_kat.Rows)
            //{
            //    // Добавляем вкладку
            //    kategooriad.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
            //    kategooriad.TabPages[i].ImageIndex = i;

            //    // Получаем Id категории
            //    int kat_Id = (int)nimetus["Id"];

            //    // Загружаем файлы прямо здесь
            //    SqlDataAdapter adapter_failid = new SqlDataAdapter(
            //        "SELECT Pilt FROM ToodeTabel WHERE Kategooriad=@id", connect);
            //    adapter_failid.SelectCommand.Parameters.AddWithValue("@id", kat_Id);
            //    DataTable dt_failid = new DataTable();
            //    adapter_failid.Fill(dt_failid);

            //    int r = 0;
            //    int c = 0;

            //    foreach (DataRow fail in dt_failid.Rows)
            //    {
            //        if (fail["Pilt"] != DBNull.Value)
            //        {
            //            PictureBox pictureBox = new PictureBox();
            //            pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail["Pilt"].ToString());
            //            pictureBox.Width = pictureBox.Height = 100;
            //            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //            pictureBox.Location = new System.Drawing.Point(c, r);

            //            c += 100 + 2; // следующий элемент справа
            //            kategooriad.TabPages[i].Controls.Add(pictureBox);
            //        }
            //    }

            //    i++;
            //}

            kategooriad.ImageList = iconsList;
            connect.Close();
            this.Controls.Add(kategooriad);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void ostukorv_Click(object sender, EventArgs e)
        {
            // Создаем новый TabControl или очищаем существующий
            if (ostukorvTabControl != null)
            {
                this.Controls.Remove(ostukorvTabControl);
                ostukorvTabControl.Dispose();
            }
            ostukorvTabControl = new TabControl();
            ostukorvTabControl.Size = new Size(1300, 500);
            ostukorvTabControl.Location = new Point(900, 0); // или другое расположение
            this.Controls.Add(ostukorvTabControl);

            //// Добавляем выбранные товары в корзину
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (row.IsNewRow) continue;

            //    string name = row.Cells["Toodenimetus"].Value?.ToString();
            //    if (string.IsNullOrEmpty(name)) continue;

            //    TabPage tabPage = new TabPage(name);
            //    byte[] imgBytes = row.Cells["BPilt"].Value as byte[];
            //    if (imgBytes != null)
            //    {
            //        using (MemoryStream ms = new MemoryStream(imgBytes))
            //        {
            //            PictureBox pb = new PictureBox();
            //            pb.Image = Image.FromStream(ms);
            //            pb.Dock = DockStyle.Fill;
            //            tabPage.Controls.Add(pb);
            //        }
            //    }
            //    ostukorvTabControl.TabPages.Add(tabPage);
            //}
        }
    }

}
    
