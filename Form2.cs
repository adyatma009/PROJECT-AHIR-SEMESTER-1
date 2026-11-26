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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.DoubleBuffered = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda Benar Ingin Kelura!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Login login = new Login();
            login.Show();
            this.Hide();



        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Guru guru = new Guru();
            guru.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistik statistik = new Statistik();
            statistik.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_TAMBAHKAN_JURNAL form_tambahkan_jurnal = new FORM_TAMBAHKAN_JURNAL();
            form_tambahkan_jurnal.Show();
        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kehadiran kehadiran = new Kehadiran();
            kehadiran.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Kehadiran kehadiran = new Kehadiran();
            kehadiran.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Guru guru = new Guru();
            guru.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Statistik statistik = new Statistik();
            statistik.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FORM_TAMBAHKAN_JURNAL.dataRingkasanKegiatan;
        }
    }
}
