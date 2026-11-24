namespace PROJECT_AHIR__SEMESTER_1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            panel2 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(972, 101);
            panel1.Margin = new Padding(6, 8, 6, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 906);
            panel1.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Hanken Grotesk", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(125, 357);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 38);
            label7.TabIndex = 18;
            label7.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 403);
            textBox1.Margin = new Padding(6, 8, 6, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(608, 48);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(456, 1038);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 25);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 543);
            textBox2.Margin = new Padding(6, 8, 6, 8);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(608, 49);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Hanken Grotesk", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 497);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 38);
            label2.TabIndex = 11;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(121, 605);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Hanken Grotesk", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, -174);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 14;
            label4.Text = "Username";
            // 
            // button1
            // 
            button1.Font = new Font("Hanken Grotesk", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(327, 659);
            button1.Margin = new Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new Size(190, 59);
            button1.TabIndex = 15;
            button1.Text = "Login ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Hanken Grotesk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, -375);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 23);
            label3.TabIndex = 7;
            label3.Text = "Enter Your Account Details";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(261, 790);
            panel2.Margin = new Padding(6, 8, 6, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Location = new Point(467, 938);
            flowLayoutPanel4.Margin = new Padding(6, 8, 6, 8);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(0, 0);
            flowLayoutPanel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(267, 505);
            panel3.Margin = new Padding(6, 8, 6, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Hanken Grotesk", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(362, 173);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 73);
            label5.TabIndex = 9;
            label5.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 100);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(962, 1010);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(966, 1640);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(1139, 170);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hanken Grotesk Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(974, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(554, 53);
            label1.TabIndex = 4;
            label1.Text = "It's Good to Have You Here.";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(5, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(887, 1034);
            panel4.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.WhatsApp_Image_2026_11_18_at_10_58_53;
            pictureBox4.Location = new Point(26, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(837, 929);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.logo_pkl;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(403, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label7;
    }
}
