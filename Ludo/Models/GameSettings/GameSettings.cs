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
                //lblWarning.Location = new System.Drawing.Point(17, 169);
                lblWarning.Text = "At least two players have to be checked.";
            }

            if(emptyName)
            {
                //lblWarning.Location = new System.Drawing.Point(17, 169);
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
    }
}
