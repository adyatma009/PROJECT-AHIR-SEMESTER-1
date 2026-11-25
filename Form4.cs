using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_AHIR__SEMESTER_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Statistik statistik = new Statistik();
            statistik.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kehadiran kehadiran = new Kehadiran();
            kehadiran.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Guru guru = new Guru();
            guru.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string tanggal = textBox1.Text;
            string jamMulai = textBox2.Text;
            string jamSelesai = textBox3.Text;
            string judul = textBox4.Text;
            string deskripsi = textBox5.Text;

            if (string.IsNullOrWhiteSpace(tanggal) || string.IsNullOrWhiteSpace(jamMulai) ||
                string.IsNullOrWhiteSpace(jamSelesai) || string.IsNullOrWhiteSpace(judul) ||
                string.IsNullOrWhiteSpace(deskripsi))
            {
                MessageBox.Show("Pastikan Tidak Ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
           

            // Memasukkan data baru ke tabel global Kehadiran
            Kehadiran.dataJurnalKehadiran.Rows.Add(tanggal, jamMulai, jamSelesai, judul, deskripsi);

            MessageBox.Show("Jurnal harian berhasil disimpan!\n\n" + "Tanggal: " + tanggal + "\n" +
                           "Jam: " + jamMulai + " - " + jamSelesai + "\n" +
                           "Kegiatan: " + judul,
                           "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BersihkanForm();
        }
        private void BersihkanForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        
    }
}
