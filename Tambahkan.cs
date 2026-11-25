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
            string text2 = textBox2.Text.Trim();


            if (text == "" || text2 == "")
            {
                MessageBox.Show("Pastikan semua sufdah di isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            MessageBox.Show(" Berhasil menyimpan jurnal!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BersihkanForm()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
