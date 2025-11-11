using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        SqlConnection connect = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Kat_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kat_box1_SelectedIndexChanged(object sender, EventArgs e)
        {

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