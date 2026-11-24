using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Statistik : Form
    {
        public static string NamaLengkap = "Nama Lengkap";
        public static string AsalSekolah = "";
        public static string Email = "";

        public static string Nisn = "Isilah NISN di Data Siswa";
        public static string KelasJurusan = "";
        public static string NoWhatsapp = "";
        public static string TempatMagang = "PT Nusantara Digital Solusi";
        public static string AlamatMagang = "";
        public static string PeriodeMagang = "";
        public static string Pembimbing = "";
        public static string JamKerja = "";

        public Statistik()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }
        private void Statistik_Load(object sender, EventArgs e)
        {
            TampilkanDataProfil();
        }

        public void TampilkanDataProfil()
        {
            label17.Text = NamaLengkap;
            label32.Text = Nisn;


            textBox1.Text = NamaLengkap;
            textBox2.Text = AsalSekolah;
            textBox3.Text = Email;
            textBox4.Text = Nisn;
            textBox5.Text = KelasJurusan;
            textBox6.Text = NoWhatsapp;
            textBox7.Text = AlamatMagang;
            textBox8.Text = Pembimbing;
            textBox9.Text = PeriodeMagang;
            textBox10.Text = JamKerja;

            
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Statistik statistik = new Statistik();
            statistik.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //txtnama.Text = "Ahmad Rizky Putra";
            //txtasalsekolah.Text = "SMK Negeri 1 Kandeman";
            //txtemail.Text = "ahmadrp@gmail.com";
            //txtnisn.Text = "234566";
            //txtkelasjurusan.Text = "XI RPL";
            //txtwa.Text = "0987998877";


           
        }
    }
}
