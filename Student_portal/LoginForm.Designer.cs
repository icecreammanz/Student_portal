namespace Student_portal
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            CenterPanel = new Panel();
            Verificationpanel = new Panel();
            fifthtxtbox = new TextBox();
            fourthtxtbox = new TextBox();
            thirdtxtbox = new TextBox();
            secondtxtbox = new TextBox();
            verifyButton = new Button();
            linkLabel2 = new LinkLabel();
            firsttxtbox = new TextBox();
            verificationCodeLabel = new Label();
            LoginPanel = new Panel();
            eyeofrah = new PictureBox();
            infolab = new Label();
            loginbtn = new Button();
            forgotpassowrd = new LinkLabel();
            passwrodtxt = new TextBox();
            label3 = new Label();
            studentidtxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PassResetPanel = new Panel();
            resetPasswordButton = new Button();
            backToLoginLink = new LinkLabel();
            confirmPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            ForgotPassPanel = new Panel();
            Sendoptbtn = new Button();
            linkLabel1 = new LinkLabel();
            studentidopttxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CenterPanel.SuspendLayout();
            Verificationpanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeofrah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PassResetPanel.SuspendLayout();
            ForgotPassPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CenterPanel
            // 
       
            CenterPanel.Controls.Add(LoginPanel);
            CenterPanel.Controls.Add(PassResetPanel);
            CenterPanel.Controls.Add(ForgotPassPanel);
            CenterPanel.Controls.Add(Verificationpanel);
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(0, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(497, 588);
            CenterPanel.TabIndex = 0;
            // 
            // Verificationpanel
            // 
            Verificationpanel.Controls.Add(fifthtxtbox);
            Verificationpanel.Controls.Add(fourthtxtbox);
            Verificationpanel.Controls.Add(thirdtxtbox);
            Verificationpanel.Controls.Add(secondtxtbox);
            Verificationpanel.Controls.Add(verifyButton);
            Verificationpanel.Controls.Add(linkLabel2);
            Verificationpanel.Controls.Add(firsttxtbox);
            Verificationpanel.Controls.Add(verificationCodeLabel);
            Verificationpanel.Dock = DockStyle.Fill;
            Verificationpanel.Location = new Point(0, 0);
            Verificationpanel.Name = "Verificationpanel";
            Verificationpanel.Size = new Size(497, 588);
            Verificationpanel.TabIndex = 16;
            // 
            // fifthtxtbox
            // 
            fifthtxtbox.BorderStyle = BorderStyle.FixedSingle;
            fifthtxtbox.Font = new Font("Segoe UI", 11F);
            fifthtxtbox.Location = new Point(339, 96);
            fifthtxtbox.Name = "fifthtxtbox";
            fifthtxtbox.Size = new Size(55, 27);
            fifthtxtbox.TabIndex = 16;
            fifthtxtbox.KeyPress += fifthtxtbox_KeyPress;
            // 
            // fourthtxtbox
            // 
            fourthtxtbox.BorderStyle = BorderStyle.FixedSingle;
            fourthtxtbox.Font = new Font("Segoe UI", 11F);
            fourthtxtbox.Location = new Point(278, 96);
            fourthtxtbox.Name = "fourthtxtbox";
            fourthtxtbox.Size = new Size(55, 27);
            fourthtxtbox.TabIndex = 15;
            fourthtxtbox.KeyPress += fourthtxtbox_KeyPress;
            // 
            // thirdtxtbox
            // 
            thirdtxtbox.BorderStyle = BorderStyle.FixedSingle;
            thirdtxtbox.Font = new Font("Segoe UI", 11F);
            thirdtxtbox.Location = new Point(217, 96);
            thirdtxtbox.Name = "thirdtxtbox";
            thirdtxtbox.Size = new Size(55, 27);
            thirdtxtbox.TabIndex = 14;
            thirdtxtbox.KeyPress += thirdtxtbox_KeyPress;
            // 
            // secondtxtbox
            // 
            secondtxtbox.BorderStyle = BorderStyle.FixedSingle;
            secondtxtbox.Font = new Font("Segoe UI", 11F);
            secondtxtbox.Location = new Point(156, 96);
            secondtxtbox.Name = "secondtxtbox";
            secondtxtbox.Size = new Size(55, 27);
            secondtxtbox.TabIndex = 13;
            secondtxtbox.KeyPress += secondtxtbox_KeyPress;
            // 
            // verifyButton
            // 
            verifyButton.BackColor = Color.FromArgb(40, 51, 73);
            verifyButton.BackgroundImageLayout = ImageLayout.Center;
            verifyButton.FlatStyle = FlatStyle.Flat;
            verifyButton.Font = new Font("Segoe UI", 10F);
            verifyButton.ForeColor = Color.FromArgb(0, 126, 249);
            verifyButton.ImageAlign = ContentAlignment.MiddleRight;
            verifyButton.Location = new Point(149, 151);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(197, 46);
            verifyButton.TabIndex = 12;
            verifyButton.Text = "Verify Code";
            verifyButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            verifyButton.UseVisualStyleBackColor = false;
            verifyButton.MouseClick += verifyButton_MouseClick;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.ForeColor = SystemColors.Highlight;
            linkLabel2.LinkColor = SystemColors.Highlight;
            linkLabel2.Location = new Point(200, 219);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(93, 19);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back To Login";
            linkLabel2.MouseClick += linkLabel2_MouseClick;
            // 
            // firsttxtbox
            // 
            firsttxtbox.BorderStyle = BorderStyle.FixedSingle;
            firsttxtbox.Font = new Font("Segoe UI", 11F);
            firsttxtbox.Location = new Point(95, 96);
            firsttxtbox.Name = "firsttxtbox";
            firsttxtbox.Size = new Size(55, 27);
            firsttxtbox.TabIndex = 10;
            firsttxtbox.MouseClick += firsttxtbox_MouseClick;
            firsttxtbox.KeyPress += firsttxtbox_KeyPress;
            // 
            // verificationCodeLabel
            // 
            verificationCodeLabel.AutoSize = true;
            verificationCodeLabel.Font = new Font("Segoe UI", 12F);
            verificationCodeLabel.ForeColor = SystemColors.Highlight;
            verificationCodeLabel.Location = new Point(149, 49);
            verificationCodeLabel.Name = "verificationCodeLabel";
            verificationCodeLabel.Size = new Size(182, 21);
            verificationCodeLabel.TabIndex = 9;
            verificationCodeLabel.Text = "Enter Confirmation Code";
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(eyeofrah);
            LoginPanel.Controls.Add(infolab);
            LoginPanel.Controls.Add(loginbtn);
            LoginPanel.Controls.Add(forgotpassowrd);
            LoginPanel.Controls.Add(passwrodtxt);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(studentidtxt);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(497, 588);
            LoginPanel.TabIndex = 0;
            // 
            // eyeofrah
            // 
            eyeofrah.BackColor = Color.White;
            eyeofrah.BorderStyle = BorderStyle.FixedSingle;
            eyeofrah.Image = Properties.Resources.icons8_closed_eye_50;
            eyeofrah.Location = new Point(342, 333);
            eyeofrah.Name = "eyeofrah";
            eyeofrah.Size = new Size(37, 27);
            eyeofrah.SizeMode = PictureBoxSizeMode.Zoom;
            eyeofrah.TabIndex = 19;
            eyeofrah.TabStop = false;
            eyeofrah.MouseClick += eyeofrah_Click;
            // 
            // infolab
            // 
            infolab.AutoSize = true;
            infolab.Font = new Font("Segoe UI", 14F);
            infolab.ForeColor = Color.Red;
            infolab.Location = new Point(158, 490);
            infolab.Name = "infolab";
            infolab.Size = new Size(209, 25);
            infolab.TabIndex = 18;
            infolab.Text = "Please Fill both the info";
            // 
            // loginbtn
            // 
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginbtn.ForeColor = SystemColors.MenuHighlight;
            loginbtn.Location = new Point(206, 408);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(105, 39);
            loginbtn.TabIndex = 17;
            loginbtn.Text = "Log in";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.MouseClick += loginbtn_MouseClick;
            // 
            // forgotpassowrd
            // 
            forgotpassowrd.AutoSize = true;
            forgotpassowrd.Font = new Font("Segoe UI", 10F);
            forgotpassowrd.ForeColor = SystemColors.Highlight;
            forgotpassowrd.LinkColor = SystemColors.Highlight;
            forgotpassowrd.Location = new Point(261, 365);
            forgotpassowrd.Name = "forgotpassowrd";
            forgotpassowrd.Size = new Size(118, 19);
            forgotpassowrd.TabIndex = 16;
            forgotpassowrd.TabStop = true;
            forgotpassowrd.Text = "Forgot Password?";
            forgotpassowrd.MouseClick += forgotpassowrd_MouseClick;
            // 
            // passwrodtxt
            // 
            passwrodtxt.BorderStyle = BorderStyle.FixedSingle;
            passwrodtxt.Font = new Font("Segoe UI", 11F);
            passwrodtxt.Location = new Point(138, 333);
            passwrodtxt.Name = "passwrodtxt";
            passwrodtxt.PasswordChar = '*';
            passwrodtxt.Size = new Size(241, 27);
            passwrodtxt.TabIndex = 15;
            passwrodtxt.MouseClick += passwrodtxt_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(138, 309);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // studentidtxt
            // 
            studentidtxt.BorderStyle = BorderStyle.FixedSingle;
            studentidtxt.Font = new Font("Segoe UI", 11F);
            studentidtxt.Location = new Point(138, 258);
            studentidtxt.Name = "studentidtxt";
            studentidtxt.Size = new Size(241, 27);
            studentidtxt.TabIndex = 13;
            studentidtxt.MouseClick += studentidtxt_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(138, 236);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 12;
            label2.Text = "Student ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(119, 157);
            label1.Name = "label1";
            label1.Size = new Size(282, 25);
            label1.TabIndex = 11;
            label1.Text = "ID replacement Student Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hilcoe_Logo;
            pictureBox1.Location = new Point(43, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // PassResetPanel
            // 
            PassResetPanel.Controls.Add(resetPasswordButton);
            PassResetPanel.Controls.Add(backToLoginLink);
            PassResetPanel.Controls.Add(confirmPasswordTextBox);
            PassResetPanel.Controls.Add(confirmPasswordLabel);
            PassResetPanel.Controls.Add(newPasswordTextBox);
            PassResetPanel.Controls.Add(newPasswordLabel);
            PassResetPanel.Dock = DockStyle.Fill;
            PassResetPanel.Location = new Point(0, 0);
            PassResetPanel.Name = "PassResetPanel";
            PassResetPanel.Size = new Size(497, 588);
            PassResetPanel.TabIndex = 14;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.BackColor = Color.FromArgb(40, 51, 73);
            resetPasswordButton.BackgroundImageLayout = ImageLayout.Center;
            resetPasswordButton.FlatStyle = FlatStyle.Flat;
            resetPasswordButton.Font = new Font("Segoe UI", 10F);
            resetPasswordButton.ForeColor = Color.FromArgb(0, 126, 249);
            resetPasswordButton.ImageAlign = ContentAlignment.MiddleRight;
            resetPasswordButton.Location = new Point(142, 236);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(197, 46);
            resetPasswordButton.TabIndex = 14;
            resetPasswordButton.Text = "Reset Password";
            resetPasswordButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            resetPasswordButton.UseVisualStyleBackColor = false;
            resetPasswordButton.MouseClick += resetPasswordButton_MouseClick;
            // 
            // backToLoginLink
            // 
            backToLoginLink.AutoSize = true;
            backToLoginLink.Font = new Font("Segoe UI", 10F);
            backToLoginLink.ForeColor = SystemColors.Highlight;
            backToLoginLink.LinkColor = SystemColors.Highlight;
            backToLoginLink.Location = new Point(194, 305);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(93, 19);
            backToLoginLink.TabIndex = 15;
            backToLoginLink.TabStop = true;
            backToLoginLink.Text = "Back To Login";
            backToLoginLink.MouseClick += backToLoginLink_MouseClick;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 11F);
            confirmPasswordTextBox.Location = new Point(112, 191);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(269, 27);
            confirmPasswordTextBox.TabIndex = 13;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 12F);
            confirmPasswordLabel.ForeColor = SystemColors.Highlight;
            confirmPasswordLabel.Location = new Point(167, 157);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(137, 21);
            confirmPasswordLabel.TabIndex = 12;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            newPasswordTextBox.Font = new Font("Segoe UI", 11F);
            newPasswordTextBox.Location = new Point(112, 111);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(269, 27);
            newPasswordTextBox.TabIndex = 11;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI", 12F);
            newPasswordLabel.ForeColor = SystemColors.Highlight;
            newPasswordLabel.Location = new Point(167, 73);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(152, 21);
            newPasswordLabel.TabIndex = 10;
            newPasswordLabel.Text = "Enter New Password";
            // 
            // ForgotPassPanel
            // 
            ForgotPassPanel.Controls.Add(Sendoptbtn);
            ForgotPassPanel.Controls.Add(linkLabel1);
            ForgotPassPanel.Controls.Add(studentidopttxt);
            ForgotPassPanel.Controls.Add(label4);
            ForgotPassPanel.Controls.Add(label5);
            ForgotPassPanel.Dock = DockStyle.Fill;
            ForgotPassPanel.Location = new Point(0, 0);
            ForgotPassPanel.Name = "ForgotPassPanel";
            ForgotPassPanel.Size = new Size(497, 588);
            ForgotPassPanel.TabIndex = 20;
            // 
            // Sendoptbtn
            // 
            Sendoptbtn.BackColor = Color.FromArgb(46, 51, 73);
            Sendoptbtn.BackgroundImageLayout = ImageLayout.Center;
            Sendoptbtn.FlatStyle = FlatStyle.Flat;
            Sendoptbtn.Font = new Font("Segoe UI", 10F);
            Sendoptbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Sendoptbtn.Image = (Image)resources.GetObject("Sendoptbtn.Image");
            Sendoptbtn.ImageAlign = ContentAlignment.MiddleRight;
            Sendoptbtn.Location = new Point(150, 273);
            Sendoptbtn.Name = "Sendoptbtn";
            Sendoptbtn.Size = new Size(197, 46);
            Sendoptbtn.TabIndex = 13;
            Sendoptbtn.Text = "Send Code";
            Sendoptbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Sendoptbtn.UseVisualStyleBackColor = false;
            Sendoptbtn.MouseClick += Sendoptbtn_MouseClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.ForeColor = SystemColors.Highlight;
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(200, 207);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 19);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back To Login";
            linkLabel1.MouseClick += Backtologin_MouseClick;
            // 
            // studentidopttxt
            // 
            studentidopttxt.BorderStyle = BorderStyle.FixedSingle;
            studentidopttxt.Font = new Font("Segoe UI", 11F);
            studentidopttxt.Location = new Point(114, 162);
            studentidopttxt.Name = "studentidopttxt";
            studentidopttxt.Size = new Size(269, 27);
            studentidopttxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(187, 124);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 10;
            label4.Text = "Enter Student ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(167, 73);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 9;
            label5.Text = "Forgor Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(497, 588);
            Controls.Add(CenterPanel);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            CenterPanel.ResumeLayout(false);
            Verificationpanel.ResumeLayout(false);
            Verificationpanel.PerformLayout();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeofrah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PassResetPanel.ResumeLayout(false);
            PassResetPanel.PerformLayout();
            ForgotPassPanel.ResumeLayout(false);
            ForgotPassPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CenterPanel;
        private Panel LoginPanel;
        private PictureBox eyeofrah;
        private Label infolab;
        private Button loginbtn;
        private LinkLabel forgotpassowrd;
        private TextBox passwrodtxt;
        private Label label3;
        private TextBox studentidtxt;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel ForgotPassPanel;
        private Button Sendoptbtn;
        private LinkLabel linkLabel1;
        private TextBox studentidopttxt;
        private Label label4;
        private Label label5;
        private Panel PassResetPanel;
        private Button resetPasswordButton;
        private LinkLabel backToLoginLink;
        private TextBox confirmPasswordTextBox;
        private Label confirmPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Panel Verificationpanel;
        private Button verifyButton;
        private LinkLabel linkLabel2;
        private TextBox firsttxtbox;
        private Label verificationCodeLabel;
        private TextBox fifthtxtbox;
        private TextBox fourthtxtbox;
        private TextBox thirdtxtbox;
        private TextBox secondtxtbox;
    }
}