using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_portal
{
    public partial class Homeform : Form
    {
        private bool isDeleting = true;
        private bool isDarkMode = true;
        private bool isFullScreen = false;
        private string studentid;


        private readonly Font CommonLabelFont = new Font("Segoe UI", 12F);
        private readonly Color CommonTextColor = SystemColors.Highlight;
        private readonly Color CommonControlBackColor = Color.FromArgb(46, 51, 73);
        private readonly Color CommonControlForeColor = Color.FromArgb(0, 126, 249);
        private readonly Font CommonButtonFont = new Font("Segoe UI", 10F);

 
        private const int ButtonPadding = 30;
        private const double MenuPanelWidthRatio = 0.256;
        private const double ButtonWidthRatio = 0.4;
        private const double ButtonHeightRatio = 0.1;
        private const double MenuButtonHeightRatio = 0.1;


        public Homeform(string StudentId = "")
        {  
            Homeform_Load(null, EventArgs.Empty);
            studentid = StudentId;
        }

        private void Homeform_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            ShowPanel(HomePanel);
       
            ToggleEditMode();
            fullscreenbtn.Text = "Enter Fullscreen";
            this.MinimumSize = new Size(800, 600);

            this.FormClosing += Close_form;
            this.Resize += Homeform_Resize;
        }


        private void Close_form(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void AdjustButtonLayout()
        {
            if (CenterPanel == null || MenuPanel == null)
                return;


            // Adjust Menu Panel Layout
            AdjustMenuPanelLayout();

            // Adjust other panels layout
            if (HomePanel.Visible)
            {
                AdjustPanelLayout(HomePanel, Reqidbtn, tempidbtn, Changeingobtn);
            }
            else if (settingpanel.Visible)
            {
                AdjustPanelLayout(settingpanel, Colormodebtn, fullscreenbtn);
            }
        }

        private void AdjustMenuPanelLayout()
        {
            int panelWidth = CenterPanel.Width;
            int panelHeight = CenterPanel.Height;

            int menuPanelWidth = (int)(panelWidth * MenuPanelWidthRatio);
            MenuPanel.Size = new Size(menuPanelWidth, panelHeight);

            int MbtnWidth = MenuPanel.Width;
            int MbtnHeight = (int)(MenuPanel.Height * MenuButtonHeightRatio);

            int McenterX = MenuPanel.Width - MbtnWidth;
            int MbuttonTotalHeight = (MbtnHeight * 2) + ButtonPadding;
            int MbuttonCenterY = (MenuPanel.Height - MbuttonTotalHeight) / 30;


            Button[] topButtons = { Homebtn, Historybtn, Exitbtn };

            for (int i = 0; i < topButtons.Length; i++)
            {
                topButtons[i].Size = new Size(MbtnWidth, MbtnHeight);
                topButtons[i].Location = new Point(McenterX, MbuttonCenterY + i * (MbtnHeight));
            }


            Settingbtn.Size = new Size(MbtnWidth, MbtnHeight);

        }

        private void AdjustPanelLayout(Panel panel, params Button[] buttons)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            int btnWidth = (int)(panelWidth * ButtonWidthRatio);
            int btnHeight = (int)(panelHeight * ButtonHeightRatio);
            int centerX = (panelWidth - btnWidth) / 2;

            int buttonTotalHeight = (btnHeight * buttons.Length) + ((buttons.Length - 1) * ButtonPadding);
            int buttonCenterY = (panelHeight - buttonTotalHeight) / 2;


            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Size = new Size(btnWidth, btnHeight);
                buttons[i].Location = new Point(centerX + 30, buttonCenterY + i * (btnHeight + ButtonPadding));
            }
        }

        private void Homeform_Resize(object sender, EventArgs e)
        {
            AdjustButtonLayout();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private void ShowPanel(Panel panelToShow)
        {
            if (panelToShow == null) return;

            HomePanel.Visible = panelToShow == HomePanel;
            ChangeinfoPanel.Visible = panelToShow == ChangeinfoPanel;
            settingpanel.Visible = panelToShow == settingpanel;
            HistoryPanel.Visible = panelToShow == HistoryPanel;

            panelToShow.BringToFront();
            AdjustButtonLayout();
        }

        private void Homebtn_MouseClick(object sender, MouseEventArgs e)
        {
            ShowPanel(HomePanel);
        }

        private void Changeingobtn_MouseClick(object sender, MouseEventArgs e)
        {

            ShowPanel(ChangeinfoPanel);

        }
        private void Settingbtn_MouseClick(object sender, MouseEventArgs e)
        {
            ShowPanel(settingpanel);
        }
        private void Colormodebtn_MouseClick(object sender, MouseEventArgs e)
        {
            ToggleColorMode();
        }

        private void ToggleColorMode()
        {
            if (isDarkMode)
            {
                CenterPanel.BackColor = Color.FromArgb(230, 240, 255);
                MenuPanel.BackColor = Color.FromArgb(200, 210, 235);
                panel1.BackColor = Color.FromArgb(200, 210, 235);
                panel2.BackColor = Color.FromArgb(200, 210, 235);

                Colormodebtn.BackColor = Color.FromArgb(230, 240, 255);
                Colormodebtn.ForeColor = Color.Black;
                Colormodebtn.Text = "Dark Mode";

                Reqidbtn.BackColor = Color.FromArgb(200, 210, 235);
                tempidbtn.BackColor = Color.FromArgb(200, 210, 235);
                Changeingobtn.BackColor = Color.FromArgb(200, 210, 235);
                updatebtn.BackColor = Color.FromArgb(200, 210, 235);
                cancelbtn.BackColor = Color.FromArgb(200, 210, 235);
                Changepicbtn.BackColor = Color.FromArgb(200, 210, 235);

                updatebtn.ForeColor = Color.Black;
                cancelbtn.ForeColor = Color.Black;
                Changepicbtn.ForeColor = Color.Black;
                Reqidbtn.ForeColor = Color.Black;
                tempidbtn.ForeColor = Color.Black;
                Changeingobtn.ForeColor = Color.Black;

                Homebtn.ForeColor = Color.Black;
                Historybtn.ForeColor = Color.Black;
                Exitbtn.ForeColor = Color.Black;
                Settingbtn.ForeColor = Color.Black;

                Homebtn.BackColor = Color.FromArgb(200, 210, 235);
                Historybtn.BackColor = Color.FromArgb(200, 210, 235);
                Exitbtn.BackColor = Color.FromArgb(200, 210, 235);
                Settingbtn.BackColor = Color.FromArgb(200, 210, 235);
                fullscreenbtn.BackColor = Color.FromArgb(200, 210, 235);
                fullscreenbtn.ForeColor = Color.Black;


                label1.ForeColor = Color.Black;
                studentnamelbl.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            else
            {
                CenterPanel.BackColor = CommonControlBackColor;
                MenuPanel.BackColor = Color.FromArgb(24, 30, 54);
                panel1.BackColor = Color.FromArgb(24, 30, 54);
                panel2.BackColor = Color.FromArgb(24, 30, 54);

                Colormodebtn.BackColor = CommonControlBackColor;
                Colormodebtn.ForeColor = CommonControlForeColor;
                Colormodebtn.Text = "Light Mode";

                Reqidbtn.BackColor = CommonControlBackColor;
                tempidbtn.BackColor = CommonControlBackColor;
                Changeingobtn.BackColor = CommonControlBackColor;
                updatebtn.BackColor = CommonControlBackColor;
                cancelbtn.BackColor = CommonControlBackColor;
                Changepicbtn.BackColor = CommonControlBackColor;

                updatebtn.ForeColor = CommonControlForeColor;
                cancelbtn.ForeColor = CommonControlForeColor;
                Changepicbtn.ForeColor = CommonControlForeColor;

                Reqidbtn.ForeColor = CommonControlForeColor;
                tempidbtn.ForeColor = CommonControlForeColor;
                Changeingobtn.ForeColor = CommonControlForeColor;
                Homebtn.ForeColor = CommonControlForeColor;
                Historybtn.ForeColor = CommonControlForeColor;
                Exitbtn.ForeColor = CommonControlForeColor;
                Settingbtn.ForeColor = CommonControlForeColor;
                fullscreenbtn.ForeColor = CommonControlForeColor;


                Homebtn.BackColor = Color.FromArgb(24, 30, 54);
                Historybtn.BackColor = Color.FromArgb(24, 30, 54);
                Exitbtn.BackColor = Color.FromArgb(24, 30, 54);
                Settingbtn.BackColor = Color.FromArgb(24, 30, 54);
                fullscreenbtn.BackColor = CommonControlBackColor;

                label1.ForeColor = CommonTextColor;
                studentnamelbl.ForeColor = Color.WhiteSmoke;
                label6.ForeColor = CommonTextColor;
                label4.ForeColor = CommonTextColor;
                label7.ForeColor = CommonTextColor;
                label3.ForeColor = CommonTextColor;
                label5.ForeColor = CommonTextColor;
            }

            isDarkMode = !isDarkMode;
        }

        private void ToggleEditMode()
        {
            if (isDeleting)
            {
                updatebtn.Text = "Delete";
                cancelbtn.Visible = false;
                Editbtn.Text = "Edit";


                idnotxt.Enabled = false;
                FullNametxt.Enabled = false;
                phonenumtxt.Enabled = false;
            }
            else
            {
                updatebtn.Text = "Update";
                cancelbtn.Visible = true;
                Editbtn.Text = "Editing...";

                idnotxt.Enabled = true;
                FullNametxt.Enabled = true;
                phonenumtxt.Enabled = true;

            }

            isDeleting = !isDeleting;
        }

        private void updatebtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDeleting)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    idnotxt.Clear();
                    FullNametxt.Clear();
                    phonenumtxt.Clear();

                    ToggleEditMode();
                }

            }

        }
        private void Editbtn_MouseClick(object sender, MouseEventArgs e)
        {
            ToggleEditMode();
        }

        private void cancelbtn_MouseClick(object sender, MouseEventArgs e)
        {
            idnotxt.Clear();
            FullNametxt.Clear();
            phonenumtxt.Clear();
        }

        private void Exitbtn_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void fullscreenbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isFullScreen)
            {
                fullscreenbtn.Text = "Exit Fullscreen";
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {

                fullscreenbtn.Text = "Enter Fullscreen";
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;

            }
            isFullScreen = !isFullScreen;
        }

        private void Historybtn_MouseClick(object sender, MouseEventArgs e)
        {
            ShowPanel(HistoryPanel);
        }

        private void Reqidbtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tempidbtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Homeform_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}