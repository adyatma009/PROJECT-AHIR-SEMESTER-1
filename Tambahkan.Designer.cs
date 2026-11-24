namespace PROJECT_AHIR__SEMESTER_1
{
    partial class FORM_TAMBAHKAN_JURNAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(302, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(303, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Tanggal Kegiatan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 70);
            label2.Name = "label2";
            label2.Size = new Size(253, 28);
            label2.TabIndex = 2;
            label2.Text = "Judul  / Topik Keegiatan :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(664, 34);
            textBox1.TabIndex = 3;
            textBox1.Text = "Masukkan Judul ssingkat pekerjaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 122);
            label3.Name = "label3";
            label3.Size = new Size(346, 28);
            label3.TabIndex = 4;
            label3.Text = "Uraian / Deskripsi Detail Kegiatan :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(395, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(571, 146);
            textBox2.TabIndex = 5;
            textBox2.Text = "Tuliskan apa saja yang dikerjakan hari ini......";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Highlight;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 240);
            label4.Name = "label4";
            label4.Size = new Size(267, 28);
            label4.TabIndex = 6;
            label4.Text = "Dokumentasi / Bukti Foto :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(41, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 277);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(262, 578);
            button1.Name = "button1";
            button1.Size = new Size(190, 33);
            button1.TabIndex = 8;
            button1.Text = "Tambahkan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 578);
            button2.Name = "button2";
            button2.Size = new Size(190, 33);
            button2.TabIndex = 9;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(32, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 629);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // FORM_TAMBAHKAN_JURNAL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1062, 672);
            Controls.Add(panel1);
            Name = "FORM_TAMBAHKAN_JURNAL";
            Text = "FORM_TAMBAHKAN_JURNAL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}