using Ludo.Models.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
            btnStart.MouseEnter += new EventHandler(btnStart_MouseEnter);
            btnStart.MouseLeave += new EventHandler(btnStart_MouseLeave);
            btnExit.MouseEnter += new EventHandler(btnExit_MouseEnter);
            btnExit.MouseLeave += new EventHandler(btnExit_MouseLeave);
            btnAbout.MouseEnter += new EventHandler(btnAbout_MouseEnter);
            btnAbout.MouseLeave += new EventHandler(btnAbout_MouseLeave);
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStart;
        }
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStartGlow;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExit;
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExitGlow;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = Properties.Resources.BtnAbout;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = Properties.Resources.BtnAboutGlow;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            int players = 0;
            bool emptyName = false;

            if (plrOneCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrOneText.Text))
                    emptyName = true;
            }
            if (plrTwoCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrTwoText.Text))
                    emptyName = true;
            }
            if (plrThreeCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrThreeText.Text))
                    emptyName = true;
            }
            if (plrFourCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrFourText.Text))
                    emptyName = true;
            }

            if(players < 2)
            {
                lblWarning.Text = "At least two players have to be checked.";
                lblWarning.ForeColor = Color.Red;
            }

            if(emptyName)
            {
                lblWarning.Text = "Please, don't leave empty name spaces.";
            }
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.FormBorderStyle = FormBorderStyle.FixedSingle;
            about.Show();
        }

        private void plrOneCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
