namespace Clima
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.encrypt_login = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pass_login = new System.Windows.Forms.TextBox();
            this.user_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.encrypt_reg = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pass_reg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email_reg = new System.Windows.Forms.TextBox();
            this.user_reg = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.user_main = new System.Windows.Forms.Label();
            this.email_main = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.panel_add = new System.Windows.Forms.Panel();
            this.cities_combo = new System.Windows.Forms.ComboBox();
            this.addcity_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selected_city = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.day1_w = new System.Windows.Forms.TextBox();
            this.day2_w = new System.Windows.Forms.TextBox();
            this.day3_w = new System.Windows.Forms.TextBox();
            this.day4_w = new System.Windows.Forms.TextBox();
            this.day5_w = new System.Windows.Forms.TextBox();
            this.today_w = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_add.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.encrypt_login);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pass_login);
            this.panel1.Controls.Add(this.user_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 487);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Encryption";
            // 
            // encrypt_login
            // 
            this.encrypt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_login.FormattingEnabled = true;
            this.encrypt_login.Items.AddRange(new object[] {
            "SHA1",
            "SHA256"});
            this.encrypt_login.Location = new System.Drawing.Point(407, 329);
            this.encrypt_login.Name = "encrypt_login";
            this.encrypt_login.Size = new System.Drawing.Size(226, 33);
            this.encrypt_login.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(448, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(320, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 24);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pass_login
            // 
            this.pass_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_login.Location = new System.Drawing.Point(407, 279);
            this.pass_login.Name = "pass_login";
            this.pass_login.Size = new System.Drawing.Size(226, 31);
            this.pass_login.TabIndex = 2;
            this.pass_login.UseSystemPasswordChar = true;
            // 
            // user_login
            // 
            this.user_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_login.Location = new System.Drawing.Point(407, 222);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(226, 31);
            this.user_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(194, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weather App";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.encrypt_reg);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pass_reg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.email_reg);
            this.panel2.Controls.Add(this.user_reg);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 487);
            this.panel2.TabIndex = 1;
            // 
            // encrypt_reg
            // 
            this.encrypt_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_reg.FormattingEnabled = true;
            this.encrypt_reg.Items.AddRange(new object[] {
            "SHA1",
            "SHA256"});
            this.encrypt_reg.Location = new System.Drawing.Point(395, 304);
            this.encrypt_reg.Name = "encrypt_reg";
            this.encrypt_reg.Size = new System.Drawing.Size(226, 33);
            this.encrypt_reg.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(401, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // pass_reg
            // 
            this.pass_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_reg.Location = new System.Drawing.Point(395, 248);
            this.pass_reg.Name = "pass_reg";
            this.pass_reg.Size = new System.Drawing.Size(226, 31);
            this.pass_reg.TabIndex = 10;
            this.pass_reg.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // email_reg
            // 
            this.email_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_reg.Location = new System.Drawing.Point(395, 191);
            this.email_reg.Name = "email_reg";
            this.email_reg.Size = new System.Drawing.Size(226, 31);
            this.email_reg.TabIndex = 7;
            // 
            // user_reg
            // 
            this.user_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_reg.Location = new System.Drawing.Point(395, 134);
            this.user_reg.Name = "user_reg";
            this.user_reg.Size = new System.Drawing.Size(226, 31);
            this.user_reg.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel_menu);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 487);
            this.panel3.TabIndex = 2;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.panel_menu.Controls.Add(this.label11);
            this.panel_menu.Controls.Add(this.add_button);
            this.panel_menu.Controls.Add(this.home_button);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.email_main);
            this.panel_menu.Controls.Add(this.user_main);
            this.panel_menu.Controls.Add(this.button2);
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(226, 487);
            this.panel_menu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_main
            // 
            this.user_main.AutoSize = true;
            this.user_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_main.Location = new System.Drawing.Point(8, 25);
            this.user_main.Name = "user_main";
            this.user_main.Size = new System.Drawing.Size(83, 20);
            this.user_main.TabIndex = 1;
            this.user_main.Text = "user_main";
            this.user_main.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // email_main
            // 
            this.email_main.AutoSize = true;
            this.email_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_main.Location = new System.Drawing.Point(9, 49);
            this.email_main.Name = "email_main";
            this.email_main.Size = new System.Drawing.Size(77, 16);
            this.email_main.TabIndex = 2;
            this.email_main.Text = "email_main";
            this.email_main.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(147, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Location = new System.Drawing.Point(0, 120);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(226, 34);
            this.home_button.TabIndex = 4;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // add_button
            // 
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(0, 160);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(226, 34);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add city";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // panel_add
            // 
            this.panel_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.panel_add.Controls.Add(this.label8);
            this.panel_add.Controls.Add(this.label10);
            this.panel_add.Controls.Add(this.addcity_button);
            this.panel_add.Controls.Add(this.cities_combo);
            this.panel_add.Location = new System.Drawing.Point(0, 0);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(609, 487);
            this.panel_add.TabIndex = 2;
            // 
            // cities_combo
            // 
            this.cities_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cities_combo.FormattingEnabled = true;
            this.cities_combo.Location = new System.Drawing.Point(22, 76);
            this.cities_combo.Name = "cities_combo";
            this.cities_combo.Size = new System.Drawing.Size(562, 28);
            this.cities_combo.TabIndex = 0;
            // 
            // addcity_button
            // 
            this.addcity_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.addcity_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcity_button.Location = new System.Drawing.Point(198, 251);
            this.addcity_button.Name = "addcity_button";
            this.addcity_button.Size = new System.Drawing.Size(208, 34);
            this.addcity_button.TabIndex = 8;
            this.addcity_button.Text = "Add";
            this.addcity_button.UseVisualStyleBackColor = true;
            this.addcity_button.Click += new System.EventHandler(this.addcity_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.panel4.Controls.Add(this.panel_add);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(609, 487);
            this.panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(140)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.Location = new System.Drawing.Point(22, 78);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(191, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 33);
            this.label10.TabIndex = 10;
            this.label10.Text = "Add new cities";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "* Logout saves changes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(186, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "Favourite cities";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "* See more information about the selected city.";
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "More";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.today_w);
            this.panel5.Controls.Add(this.day5_w);
            this.panel5.Controls.Add(this.day4_w);
            this.panel5.Controls.Add(this.day3_w);
            this.panel5.Controls.Add(this.day2_w);
            this.panel5.Controls.Add(this.day1_w);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.selected_city);
            this.panel5.Location = new System.Drawing.Point(292, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 487);
            this.panel5.TabIndex = 1;
            // 
            // selected_city
            // 
            this.selected_city.AutoSize = true;
            this.selected_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_city.Location = new System.Drawing.Point(192, 25);
            this.selected_city.Name = "selected_city";
            this.selected_city.Size = new System.Drawing.Size(198, 33);
            this.selected_city.TabIndex = 13;
            this.selected_city.Text = "selected_city";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(183, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Today";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(190, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Day 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(190, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Day 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(190, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Day 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(190, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 20);
            this.label18.TabIndex = 18;
            this.label18.Text = "Day 4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(190, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "Day 5";
            // 
            // day1_w
            // 
            this.day1_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1_w.Location = new System.Drawing.Point(269, 140);
            this.day1_w.Name = "day1_w";
            this.day1_w.ReadOnly = true;
            this.day1_w.Size = new System.Drawing.Size(144, 26);
            this.day1_w.TabIndex = 20;
            // 
            // day2_w
            // 
            this.day2_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2_w.Location = new System.Drawing.Point(269, 187);
            this.day2_w.Name = "day2_w";
            this.day2_w.ReadOnly = true;
            this.day2_w.Size = new System.Drawing.Size(144, 26);
            this.day2_w.TabIndex = 21;
            // 
            // day3_w
            // 
            this.day3_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3_w.Location = new System.Drawing.Point(269, 235);
            this.day3_w.Name = "day3_w";
            this.day3_w.ReadOnly = true;
            this.day3_w.Size = new System.Drawing.Size(144, 26);
            this.day3_w.TabIndex = 22;
            // 
            // day4_w
            // 
            this.day4_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4_w.Location = new System.Drawing.Point(269, 284);
            this.day4_w.Name = "day4_w";
            this.day4_w.ReadOnly = true;
            this.day4_w.Size = new System.Drawing.Size(144, 26);
            this.day4_w.TabIndex = 23;
            // 
            // day5_w
            // 
            this.day5_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5_w.Location = new System.Drawing.Point(269, 335);
            this.day5_w.Name = "day5_w";
            this.day5_w.ReadOnly = true;
            this.day5_w.Size = new System.Drawing.Size(144, 26);
            this.day5_w.TabIndex = 24;
            // 
            // today_w
            // 
            this.today_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_w.Location = new System.Drawing.Point(269, 94);
            this.today_w.Name = "today_w";
            this.today_w.ReadOnly = true;
            this.today_w.Size = new System.Drawing.Size(144, 26);
            this.today_w.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "* Some cities may not be on the weather and forecast database.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox pass_login;
        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pass_reg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_reg;
        private System.Windows.Forms.TextBox user_reg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox encrypt_reg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox encrypt_login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label email_main;
        private System.Windows.Forms.Label user_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button addcity_button;
        private System.Windows.Forms.ComboBox cities_combo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox today_w;
        private System.Windows.Forms.TextBox day5_w;
        private System.Windows.Forms.TextBox day4_w;
        private System.Windows.Forms.TextBox day3_w;
        private System.Windows.Forms.TextBox day2_w;
        private System.Windows.Forms.TextBox day1_w;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label selected_city;
        private System.Windows.Forms.Label label8;
    }
}

