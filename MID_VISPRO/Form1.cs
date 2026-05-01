using System;

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MID_VISPRO
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection(
        "server=localhost;user id=root;password=;database=db_karyawan");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "SELECT foto FROM tbl_data_karyawan WHERE nik='" + txtNIK.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string foto = rd["foto"].ToString();
                pictureBox1.ImageLocation = "D:\\foto_karyawan\\" + foto;
            }
            else
            {
                MessageBox.Show("NIK tidak ditemukan");
            }

            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIK.Clear();
            pictureBox1.Image = null;
            txtNIK.Focus();
        }
    }
}
