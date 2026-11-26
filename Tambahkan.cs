using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_AHIR__SEMESTER_1
{
    public partial class FORM_TAMBAHKAN_JURNAL : Form
    {
        public static DataTable dataRingkasanKegiatan = new DataTable();
        public FORM_TAMBAHKAN_JURNAL()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();
            string text2 = textBox3.Text.Trim();


            if (text == "" || text2 == "")
            {
                MessageBox.Show("Pastikan semua sufdah di isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataRingkasanKegiatan.Rows.Add(text, text2 );



            MessageBox.Show(" Berhasil menyimpan jurnal!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void BersihkanForm()
        {
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
