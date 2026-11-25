namespace PROJECT_AHIR__SEMESTER_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            string nisn = textBox3.Text.Trim();

            if (email == "" || pass == "" || nisn == "")
            {
                MessageBox.Show("Email, Password, dan NISN tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           if (email == "ahmad.rizky@student.Smkn1.sch.id" && pass == "12345" && nisn == "0912538910")
            {
                MessageBox.Show("Login Berhasil !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 formUtama = new Form2();
            formUtama.Show();
            this.Hide();
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
