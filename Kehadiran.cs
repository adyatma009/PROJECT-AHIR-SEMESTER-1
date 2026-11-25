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
    public partial class Kehadiran : Form
    {
        public static DataTable dataJurnalKehadiran = new DataTable();
        public Kehadiran()
        {
            InitializeComponent();
        }

        private void Kehadiran_Load(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonHadir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Hadir", "--", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("-", "Izin", "-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("-", "-", "Sakit");
        }
    }
}
