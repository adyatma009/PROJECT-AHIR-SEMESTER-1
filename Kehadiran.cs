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
        // Timer untuk membuat jam berjalan secara real-time
        private System.Windows.Forms.Timer timerJam = new System.Windows.Forms.Timer();
        private string pathFotoBukti = "";
        private DataTable dtRiwayat = new DataTable();

        public Kehadiran()
        {
            InitializeComponent();
            AturJamRealtime();
            SiapkanTabelRiwayat();
        }

        // 1. LOGIKA JAM & TANGGAL REAL-TIME
        private void AturJamRealtime()
        {
            timerJam.Interval = 1000; // Update setiap 1 detik
            timerJam.Tick += (s, e) =>
            {
                // Ganti 'lblJam' dan 'lblTanggal' sesuai nama Label jam & tanggal di desain Anda
                // lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
                // lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));
            };
            timerJam.Start();
        }

        // 2. MENYIAPKAN TABEL RIWAYAT KEHADIRAN (DataGridView)
        private void SiapkanTabelRiwayat()
        {
            dtRiwayat.Columns.Add("Tanggal");
            dtRiwayat.Columns.Add("Masuk");
            dtRiwayat.Columns.Add("Pulang");
            dtRiwayat.Columns.Add("Foto");
            dtRiwayat.Columns.Add("Validasi Guru");
            dtRiwayat.Columns.Add("Ket.");

            // Hubungkan ke DataGridView Anda (ganti 'dataGridView1' jika namanya berbeda)
            // dataGridView1.DataSource = dtRiwayat;
        }

        // 3. UNGGAH FOTO DOKUMENTASI / SELFIE LOKASI
        private void UnggahFoto()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File Gambar (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            open.Title = "Pilih Foto Dokumentasi / Selfie Lokasi";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pathFotoBukti = open.FileName;
                // Tampilkan ke PictureBox unggah foto Anda (misal: picFotoBukti)
                // picFotoBukti.Image = Image.FromFile(pathFotoBukti);
                // picFotoBukti.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show("Foto berhasil dipilih!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 4. AKSI TOMBOL ABSEN (Hadir, Izin, Sakit)
        private void ProsesAbsen(string status)
        {
            if (status == "Hadir" && string.IsNullOrEmpty(pathFotoBukti))
            {
                MessageBox.Show("Silakan unggah foto dokumentasi/selfie terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tanggalHariIni = DateTime.Now.ToString("dd/MM/yyyy");
            string jamSekarang = DateTime.Now.ToString("HH:mm");
            string statusFoto = string.IsNullOrEmpty(pathFotoBukti) ? "-" : "Terlampir";

            // Tambahkan ke tabel riwayat
            dtRiwayat.Rows.Add(tanggalHariIni, jamSekarang, "-", statusFoto, "Menunggu", status);

            MessageBox.Show($"Absensi '{status}' berhasil dicatat pada pukul {jamSekarang}.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. FILTER TAB RIWAYAT (Semua, Hadir, Izin, Sakit)
        private void FilterRiwayat(string kategori)
        {
            if (kategori == "Semua")
                dtRiwayat.DefaultView.RowFilter = "";
            else
                dtRiwayat.DefaultView.RowFilter = $"[Ket.] = '{kategori}'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
