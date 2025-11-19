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
            NaitaAndmed();
        }
        SqlConnection connect = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode;
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

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter(
    "SELECT ToodeTabel.Id, ToodeTabel.Toodenimetus, ToodeTabel.Kogus, " +
    "ToodeTabel.Hind, ToodeTabel.Pilt, ToodeTabel.BPilt, " +
    "KategooriaTabel.Kategooria_nimetus AS Kategooria_nimetus " +
    "FROM ToodeTabel INNER JOIN KategooriaTabel ON ToodeTabel.Kategooriad = KategooriaTabel.Id",
    connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.DataPropertyName = "Kategooria_nimetus";
            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if (!keys.Contains(kat_n))
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);

                }
            }
            dataGridView1.Columns.Add(combo_kat);
            connect.Close();
        }
        private void naitabtn_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 500);

            // Создаем TabControl
            TabControl kategooriad = new TabControl();
            kategooriad.Name = "Kategooriad";
            kategooriad.Width = 450;
            kategooriad.Height = 450;
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
            kategooriad.Width = 250;
            kategooriad.Height = 200;
            kategooriad.Location = new System.Drawing.Point(12, 230);

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
            // ====== ВЫВОД КОРЗИНЫ ======

            DataGridView dgvKorv = new DataGridView();
            dgvKorv.Location = new Point(300, 230);
            dgvKorv.Size = new Size(500, 200);
            dgvKorv.DataSource = null;
            dgvKorv.DataSource = ostukorv; // ← показываем корзину!
            this.Controls.Add(dgvKorv);


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<KorvToode> ostukorv1 = new List<KorvToode>();

        private void maksab_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataRowView drv = row.DataBoundItem as DataRowView;

            if (drv == null)
            {
                MessageBox.Show("Ошибка: не удалось получить данные строки.");
                return;
            }

            DataRow r = drv.Row;

            KorvToode toode = new KorvToode()
            {
                Id = Convert.ToInt32(r["Id"]),
                Nimetus = r["Toodenimetus"].ToString(),
                Kogus = Convert.ToInt32(r["Kogus"]),
                Hind = Convert.ToDecimal(r["Hind"]),
                Kategooria = r["Kategooria_nimetus"].ToString()
            };

            ostukorv1.Add(toode);

            MessageBox.Show("Товар добавлен в корзину!");

            // Обновляем DataGridView корзины
            UpdateCartGrid();

        }



        public void button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.Show();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateCartGrid()
        {
            // Создаем DataTable для отображения в dataGridView2
            DataTable cartTable = new DataTable();
            cartTable.Columns.Add("Id", typeof(int));
            cartTable.Columns.Add("Toodenimetus", typeof(string));
            cartTable.Columns.Add("Kogus", typeof(int));
            cartTable.Columns.Add("Hind", typeof(decimal));
            cartTable.Columns.Add("Kategooria", typeof(string));

            // Заполняем таблицу данными из ostukorv1
            foreach (var item in ostukorv1)
            {
                cartTable.Rows.Add(item.Id, item.Nimetus, item.Kogus, item.Hind, item.Kategooria);
            }

            dataGridView2.DataSource = cartTable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
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
                    "SELECT ToodeTabel.Id, ToodeTabel.Toodenimetus, ToodeTabel.Kogus, " +
                    "ToodeTabel.Hind, ToodeTabel.Pilt, ToodeTabel.BPilt, " +
                    "KategooriaTabel.Kategooria_nimetus AS Kategooria_nimetus " +
                    "FROM ToodeTabel " +
                    "INNER JOIN KategooriaTabel ON ToodeTabel.Kategooriad = KategooriaTabel.Id " +
                    "WHERE ToodeTabel.Toodenimetus LIKE @name",
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

                // выводим найденные данные в основной dataGridView
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                // комбобокс категорий — как в твоем NaitaAndmed()
                DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
                combo_kat.DataPropertyName = "Kategooria_nimetus";

                HashSet<string> keys = new HashSet<string>();
                foreach (DataRow item in dt.Rows)
                {
                    string kat_n = item["Kategooria_nimetus"].ToString();
                    if (!keys.Contains(kat_n))
                    {
                        keys.Add(kat_n);
                        combo_kat.Items.Add(kat_n);
                    }
                }

                dataGridView1.Columns.Add(combo_kat);
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void ostja_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void otsToode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(otsKategooria.Text))
            {
                MessageBox.Show("Введите название категории!");
                return;
            }

            try
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT ToodeTabel.Id, ToodeTabel.Toodenimetus, ToodeTabel.Kogus, " +
                    "ToodeTabel.Hind, ToodeTabel.Pilt, ToodeTabel.BPilt, " +
                    "KategooriaTabel.Kategooria_nimetus AS Kategooria_nimetus " +
                    "FROM ToodeTabel " +
                    "INNER JOIN KategooriaTabel ON ToodeTabel.Kategooriad = KategooriaTabel.Id " +
                    "WHERE KategooriaTabel.Kategooria_nimetus LIKE @kat",
                    connect);

                // используем текст поля категории!
                cmd.Parameters.AddWithValue("@kat", "%" + otsKategooria.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                connect.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено!");
                    return;
                }

                // выводим найденные данные в основной dataGridView
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                // комбобокс категорий — как в твоем NaitaAndmed()
                DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
                combo_kat.DataPropertyName = "Kategooria_nimetus";

                HashSet<string> keys = new HashSet<string>();
                foreach (DataRow item in dt.Rows)
                {
                    string kat_n = item["Kategooria_nimetus"].ToString();
                    if (!keys.Contains(kat_n))
                    {
                        keys.Add(kat_n);
                        combo_kat.Items.Add(kat_n);
                    }
                }

                dataGridView1.Columns.Add(combo_kat);
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public class KorvToode
        {
            public int Id { get; set; }
            public string Nimetus { get; set; }
            public int Kogus { get; set; }
            public decimal Hind { get; set; }
            public string Kategooria { get; set; }
        }


        private void otsKategooria_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kustuta_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления!");
                return;
            }

            int idToRemove = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);

            // Удаляем из ostukorv1
            var item = ostukorv1.FirstOrDefault(x => x.Id == idToRemove);
            if (item != null)
            {
                ostukorv1.Remove(item);
            }

            // Обновляем DataGridView корзины
            UpdateCartGrid();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
    
