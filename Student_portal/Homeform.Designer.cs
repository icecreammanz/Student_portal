using System.Windows.Forms;

namespace Student_portal
{
    partial class Homeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homeform));
            CenterPanel = new Panel();
            HomePanel = new Panel();
            Changeingobtn = new Button();
            tempidbtn = new Button();
            Reqidbtn = new Button();
            MenuPanel = new Panel();
            panel2 = new Panel();
            Settingbtn = new Button();
            Exitbtn = new Button();
            Historybtn = new Button();
            Homebtn = new Button();
            panel1 = new Panel();
            studentnamelbl = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ChangeinfoPanel = new Panel();
            panel5 = new Panel();
            Editbtn = new Button();
            Coursecombo = new ComboBox();
            depcombo = new ComboBox();
            phonenumtxt = new TextBox();
            label7 = new Label();
            idnotxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            FullNametxt = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            updatebtn = new Button();
            cancelbtn = new Button();
            panel3 = new Panel();
            Changepicbtn = new Button();
            pictureBox2 = new PictureBox();
            settingpanel = new Panel();
            fullscreenbtn = new Button();
            Colormodebtn = new Button();
            HistoryPanel = new Panel();
            HistoryDatagrid = new DataGridView();
            CenterPanel.SuspendLayout();
            HomePanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ChangeinfoPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            settingpanel.SuspendLayout();
            HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryDatagrid).BeginInit();
            SuspendLayout();
            // 
            // CenterPanel
            // 
            CenterPanel.BackColor = Color.FromArgb(46, 51, 73);
            CenterPanel.Controls.Add(HomePanel);
            CenterPanel.Controls.Add(MenuPanel);
            CenterPanel.Controls.Add(ChangeinfoPanel);
            CenterPanel.Controls.Add(settingpanel);
            CenterPanel.Controls.Add(HistoryPanel);
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(0, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(784, 561);
            CenterPanel.TabIndex = 0;
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(Changeingobtn);
            HomePanel.Controls.Add(tempidbtn);
            HomePanel.Controls.Add(Reqidbtn);
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Location = new Point(200, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(584, 561);
            HomePanel.TabIndex = 1;
            // 
            // Changeingobtn
            // 
            Changeingobtn.BackColor = Color.FromArgb(46, 51, 73);
            Changeingobtn.BackgroundImageLayout = ImageLayout.Center;
            Changeingobtn.FlatAppearance.BorderColor = Color.Blue;
            Changeingobtn.FlatStyle = FlatStyle.Flat;
            Changeingobtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Changeingobtn.ForeColor = Color.FromArgb(0, 126, 249);
            Changeingobtn.Image = (Image)resources.GetObject("Changeingobtn.Image");
            Changeingobtn.ImageAlign = ContentAlignment.MiddleRight;
            Changeingobtn.Location = new Point(174, 318);
            Changeingobtn.Margin = new Padding(2);
            Changeingobtn.Name = "Changeingobtn";
            Changeingobtn.Size = new Size(223, 64);
            Changeingobtn.TabIndex = 3;
            Changeingobtn.Text = "Information";
            Changeingobtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Changeingobtn.UseVisualStyleBackColor = false;
            Changeingobtn.MouseClick += Changeingobtn_MouseClick;
            // 
            // tempidbtn
            // 
            tempidbtn.BackColor = Color.FromArgb(46, 51, 73);
            tempidbtn.BackgroundImageLayout = ImageLayout.Center;
            tempidbtn.FlatAppearance.BorderColor = Color.Blue;
            tempidbtn.FlatStyle = FlatStyle.Flat;
            tempidbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tempidbtn.ForeColor = Color.FromArgb(0, 126, 249);
            tempidbtn.Image = (Image)resources.GetObject("tempidbtn.Image");
            tempidbtn.ImageAlign = ContentAlignment.MiddleRight;
            tempidbtn.Location = new Point(174, 215);
            tempidbtn.Margin = new Padding(2);
            tempidbtn.Name = "tempidbtn";
            tempidbtn.Size = new Size(223, 64);
            tempidbtn.TabIndex = 2;
            tempidbtn.Text = "Temporary ID";
            tempidbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            tempidbtn.UseVisualStyleBackColor = false;
            tempidbtn.MouseClick += tempidbtn_MouseClick;
            // 
            // Reqidbtn
            // 
            Reqidbtn.BackColor = Color.FromArgb(46, 51, 73);
            Reqidbtn.BackgroundImageLayout = ImageLayout.Center;
            Reqidbtn.FlatAppearance.BorderColor = Color.Blue;
            Reqidbtn.FlatStyle = FlatStyle.Flat;
            Reqidbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Reqidbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Reqidbtn.Image = (Image)resources.GetObject("Reqidbtn.Image");
            Reqidbtn.ImageAlign = ContentAlignment.MiddleRight;
            Reqidbtn.Location = new Point(174, 113);
            Reqidbtn.Margin = new Padding(2);
            Reqidbtn.Name = "Reqidbtn";
            Reqidbtn.Size = new Size(223, 64);
            Reqidbtn.TabIndex = 1;
            Reqidbtn.Text = "Request ID";
            Reqidbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Reqidbtn.UseVisualStyleBackColor = false;
            Reqidbtn.MouseClick += Reqidbtn_MouseClick;
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(panel2);
            MenuPanel.Controls.Add(panel1);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(200, 561);
            MenuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(Settingbtn);
            panel2.Controls.Add(Exitbtn);
            panel2.Controls.Add(Historybtn);
            panel2.Controls.Add(Homebtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 426);
            panel2.TabIndex = 1;
            // 
            // Settingbtn
            // 
            Settingbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Settingbtn.BackColor = Color.FromArgb(24, 30, 54);
            Settingbtn.BackgroundImageLayout = ImageLayout.Center;
            Settingbtn.FlatAppearance.BorderSize = 0;
            Settingbtn.FlatStyle = FlatStyle.Flat;
            Settingbtn.Font = new Font("Segoe UI", 10F);
            Settingbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Settingbtn.Image = Properties.Resources.settings;
            Settingbtn.ImageAlign = ContentAlignment.MiddleRight;
            Settingbtn.Location = new Point(0, 368);
            Settingbtn.Name = "Settingbtn";
            Settingbtn.Size = new Size(197, 46);
            Settingbtn.TabIndex = 3;
            Settingbtn.Text = "Settings";
            Settingbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Settingbtn.UseVisualStyleBackColor = false;
            Settingbtn.MouseClick += Settingbtn_MouseClick;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.FromArgb(24, 30, 54);
            Exitbtn.BackgroundImageLayout = ImageLayout.Center;
            Exitbtn.FlatAppearance.BorderColor = Color.Red;
            Exitbtn.FlatStyle = FlatStyle.Flat;
            Exitbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Exitbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Exitbtn.ImageAlign = ContentAlignment.MiddleRight;
            Exitbtn.Location = new Point(0, 132);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(200, 59);
            Exitbtn.TabIndex = 2;
            Exitbtn.Text = "Exit";
            Exitbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.MouseClick += Exitbtn_MouseClick;
            // 
            // Historybtn
            // 
            Historybtn.BackColor = Color.FromArgb(24, 30, 54);
            Historybtn.BackgroundImageLayout = ImageLayout.Center;
            Historybtn.FlatAppearance.BorderSize = 0;
            Historybtn.FlatStyle = FlatStyle.Flat;
            Historybtn.Font = new Font("Segoe UI", 10F);
            Historybtn.ForeColor = Color.FromArgb(0, 126, 249);
            Historybtn.Image = (Image)resources.GetObject("Historybtn.Image");
            Historybtn.ImageAlign = ContentAlignment.MiddleRight;
            Historybtn.Location = new Point(0, 80);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(197, 46);
            Historybtn.TabIndex = 1;
            Historybtn.Text = "History";
            Historybtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Historybtn.UseVisualStyleBackColor = false;
            Historybtn.MouseClick += Historybtn_MouseClick;
            // 
            // Homebtn
            // 
            Homebtn.BackColor = Color.FromArgb(24, 30, 54);
            Homebtn.BackgroundImageLayout = ImageLayout.Center;
            Homebtn.FlatAppearance.BorderSize = 0;
            Homebtn.FlatStyle = FlatStyle.Flat;
            Homebtn.Font = new Font("Segoe UI", 10F);
            Homebtn.ForeColor = Color.FromArgb(0, 126, 249);
            Homebtn.Image = (Image)resources.GetObject("Homebtn.Image");
            Homebtn.ImageAlign = ContentAlignment.MiddleRight;
            Homebtn.Location = new Point(0, 28);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(197, 46);
            Homebtn.TabIndex = 0;
            Homebtn.Text = "Home";
            Homebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Homebtn.UseVisualStyleBackColor = false;
            Homebtn.MouseClick += Homebtn_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(studentnamelbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 135);
            panel1.TabIndex = 0;
            // 
            // studentnamelbl
            // 
            studentnamelbl.AutoSize = true;
            studentnamelbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            studentnamelbl.ForeColor = Color.WhiteSmoke;
            studentnamelbl.Location = new Point(54, 92);
            studentnamelbl.Name = "studentnamelbl";
            studentnamelbl.Size = new Size(92, 19);
            studentnamelbl.TabIndex = 2;
            studentnamelbl.Text = "Student ABC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(30, 62);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._1833226;
            pictureBox1.Location = new Point(54, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ChangeinfoPanel
            // 
            ChangeinfoPanel.Controls.Add(panel5);
            ChangeinfoPanel.Controls.Add(panel4);
            ChangeinfoPanel.Controls.Add(panel3);
            ChangeinfoPanel.Dock = DockStyle.Fill;
            ChangeinfoPanel.Location = new Point(0, 0);
            ChangeinfoPanel.Name = "ChangeinfoPanel";
            ChangeinfoPanel.Size = new Size(784, 561);
            ChangeinfoPanel.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(Editbtn);
            panel5.Controls.Add(Coursecombo);
            panel5.Controls.Add(depcombo);
            panel5.Controls.Add(phonenumtxt);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(idnotxt);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(FullNametxt);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 368);
            panel5.TabIndex = 2;
            // 
            // Editbtn
            // 
            Editbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Editbtn.BackColor = Color.Gray;
            Editbtn.FlatAppearance.BorderSize = 0;
            Editbtn.FlatStyle = FlatStyle.Flat;
            Editbtn.Font = new Font("Segoe UI", 10F);
            Editbtn.ForeColor = Color.White;
            Editbtn.Location = new Point(695, 0);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(89, 32);
            Editbtn.TabIndex = 24;
            Editbtn.Text = "Edit";
            Editbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.MouseClick += Editbtn_MouseClick;
            // 
            // Coursecombo
            // 
            Coursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            Coursecombo.FlatStyle = FlatStyle.Popup;
            Coursecombo.FormattingEnabled = true;
            Coursecombo.Location = new Point(190, 260);
            Coursecombo.Name = "Coursecombo";
            Coursecombo.Size = new Size(243, 23);
            Coursecombo.TabIndex = 23;
            // 
            // depcombo
            // 
            depcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            depcombo.FlatStyle = FlatStyle.Popup;
            depcombo.FormattingEnabled = true;
            depcombo.Location = new Point(190, 206);
            depcombo.Name = "depcombo";
            depcombo.Size = new Size(243, 23);
            depcombo.TabIndex = 22;
            // 
            // phonenumtxt
            // 
            phonenumtxt.BorderStyle = BorderStyle.None;
            phonenumtxt.Enabled = false;
            phonenumtxt.Font = new Font("Segoe UI", 11F);
            phonenumtxt.Location = new Point(190, 152);
            phonenumtxt.Name = "phonenumtxt";
            phonenumtxt.Size = new Size(243, 20);
            phonenumtxt.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(80, 150);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 20;
            label7.Text = "Phone No";
            // 
            // idnotxt
            // 
            idnotxt.BorderStyle = BorderStyle.None;
            idnotxt.Enabled = false;
            idnotxt.Font = new Font("Segoe UI", 11F);
            idnotxt.Location = new Point(190, 42);
            idnotxt.Name = "idnotxt";
            idnotxt.Size = new Size(243, 20);
            idnotxt.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(80, 40);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 18;
            label6.Text = "ID No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(80, 258);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 17;
            label5.Text = "Courses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(80, 204);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 16;
            label3.Text = "Dep";
            // 
            // FullNametxt
            // 
            FullNametxt.BorderStyle = BorderStyle.None;
            FullNametxt.Enabled = false;
            FullNametxt.Font = new Font("Segoe UI", 11F);
            FullNametxt.Location = new Point(190, 94);
            FullNametxt.Name = "FullNametxt";
            FullNametxt.Size = new Size(243, 20);
            FullNametxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(80, 92);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 14;
            label4.Text = "Full Name";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(updatebtn);
            panel4.Controls.Add(cancelbtn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 503);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 58);
            panel4.TabIndex = 1;
            // 
            // updatebtn
            // 
            updatebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updatebtn.BackColor = Color.FromArgb(46, 51, 73);
            updatebtn.BackgroundImageLayout = ImageLayout.Center;
            updatebtn.FlatAppearance.BorderColor = Color.Blue;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            updatebtn.ForeColor = Color.FromArgb(0, 126, 249);
            updatebtn.ImageAlign = ContentAlignment.MiddleRight;
            updatebtn.Location = new Point(642, 7);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(129, 46);
            updatebtn.TabIndex = 6;
            updatebtn.Text = "Update";
            updatebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelbtn.BackColor = Color.FromArgb(46, 51, 73);
            cancelbtn.BackgroundImageLayout = ImageLayout.Center;
            cancelbtn.FlatAppearance.BorderColor = Color.Blue;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cancelbtn.ForeColor = Color.FromArgb(0, 126, 249);
            cancelbtn.ImageAlign = ContentAlignment.MiddleRight;
            cancelbtn.Location = new Point(503, 7);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(129, 46);
            cancelbtn.TabIndex = 5;
            cancelbtn.Text = "Cancel";
            cancelbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.MouseClick += cancelbtn_MouseClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Changepicbtn);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 135);
            panel3.TabIndex = 0;
            // 
            // Changepicbtn
            // 
            Changepicbtn.Anchor = AnchorStyles.Top;
            Changepicbtn.BackColor = Color.FromArgb(46, 51, 73);
            Changepicbtn.BackgroundImageLayout = ImageLayout.Center;
            Changepicbtn.FlatAppearance.BorderColor = Color.Blue;
            Changepicbtn.FlatStyle = FlatStyle.Flat;
            Changepicbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Changepicbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Changepicbtn.ImageAlign = ContentAlignment.MiddleRight;
            Changepicbtn.Location = new Point(412, 72);
            Changepicbtn.Name = "Changepicbtn";
            Changepicbtn.Size = new Size(77, 50);
            Changepicbtn.TabIndex = 6;
            Changepicbtn.Text = "Change pic";
            Changepicbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Changepicbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources._1833226;
            pictureBox2.Location = new Point(320, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // settingpanel
            // 
            settingpanel.Controls.Add(fullscreenbtn);
            settingpanel.Controls.Add(Colormodebtn);
            settingpanel.Dock = DockStyle.Fill;
            settingpanel.Location = new Point(0, 0);
            settingpanel.Name = "settingpanel";
            settingpanel.Size = new Size(784, 561);
            settingpanel.TabIndex = 4;
            // 
            // fullscreenbtn
            // 
            fullscreenbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fullscreenbtn.BackColor = Color.FromArgb(46, 51, 73);
            fullscreenbtn.BackgroundImageLayout = ImageLayout.Center;
            fullscreenbtn.FlatAppearance.BorderColor = Color.Blue;
            fullscreenbtn.FlatStyle = FlatStyle.Flat;
            fullscreenbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fullscreenbtn.ForeColor = Color.FromArgb(0, 126, 249);
            fullscreenbtn.ImageAlign = ContentAlignment.MiddleRight;
            fullscreenbtn.Location = new Point(184, 202);
            fullscreenbtn.Name = "fullscreenbtn";
            fullscreenbtn.Size = new Size(197, 46);
            fullscreenbtn.TabIndex = 5;
            fullscreenbtn.Text = "Enter Fullscreen";
            fullscreenbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            fullscreenbtn.UseVisualStyleBackColor = false;
            fullscreenbtn.MouseClick += fullscreenbtn_MouseClick;
            // 
            // Colormodebtn
            // 
            Colormodebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Colormodebtn.BackColor = Color.FromArgb(46, 51, 73);
            Colormodebtn.BackgroundImageLayout = ImageLayout.Center;
            Colormodebtn.FlatAppearance.BorderColor = Color.Blue;
            Colormodebtn.FlatStyle = FlatStyle.Flat;
            Colormodebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Colormodebtn.ForeColor = Color.FromArgb(0, 126, 249);
            Colormodebtn.ImageAlign = ContentAlignment.MiddleRight;
            Colormodebtn.Location = new Point(184, 135);
            Colormodebtn.Name = "Colormodebtn";
            Colormodebtn.Size = new Size(197, 46);
            Colormodebtn.TabIndex = 4;
            Colormodebtn.Text = "Dark Mode";
            Colormodebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Colormodebtn.UseVisualStyleBackColor = false;
            Colormodebtn.MouseClick += Colormodebtn_MouseClick;
            // 
            // HistoryPanel
            // 
            HistoryPanel.Controls.Add(HistoryDatagrid);
            HistoryPanel.Dock = DockStyle.Fill;
            HistoryPanel.Location = new Point(0, 0);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(784, 561);
            HistoryPanel.TabIndex = 6;
            // 
            // HistoryDatagrid
            // 
            HistoryDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryDatagrid.Dock = DockStyle.Fill;
            HistoryDatagrid.Location = new Point(0, 0);
            HistoryDatagrid.Name = "HistoryDatagrid";
            HistoryDatagrid.Size = new Size(784, 561);
            HistoryDatagrid.TabIndex = 0;
            // 
            // Homeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(CenterPanel);
            Name = "Homeform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homeform";
            Load += Homeform_Load_1;
     
            CenterPanel.ResumeLayout(false);
            HomePanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ChangeinfoPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            settingpanel.ResumeLayout(false);
            HistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HistoryDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CenterPanel;
        private Panel MenuPanel;
        private Panel panel2;
        private Panel panel1;
        private Label studentnamelbl;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Homebtn;
        private Button Historybtn;
        private Button Exitbtn;
        private Button Settingbtn;
        private Panel HomePanel;
        private Button Reqidbtn;
        private Button Changeingobtn;
        private Button tempidbtn;
        private Panel ChangeinfoPanel;
        private Panel panel3;
        private Button Changepicbtn;
        private PictureBox pictureBox2;
        private Panel panel5;
        private ComboBox Coursecombo;
        private ComboBox depcombo;
        private TextBox phonenumtxt;
        private Label label7;
        private TextBox idnotxt;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox FullNametxt;
        private Label label4;
        private Panel panel4;
        private Button cancelbtn;
        private Button updatebtn;
        private Button Editbtn;
        private Panel settingpanel;
        private Button Colormodebtn;
        private Button fullscreenbtn;
        private Panel HistoryPanel;
        private DataGridView HistoryDatagrid;
    }
}