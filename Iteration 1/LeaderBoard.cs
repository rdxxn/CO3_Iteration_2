using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration_1
{
    public partial class LeaderBoard : Form
    {
        SelectedDifficulty difficulty = SelectedDifficulty.Easy; //Defaults the selected value to easy
        enum SelectedDifficulty
        {
            Easy,
            Medium,
            Hard
        }
        public LeaderBoard()
        {
            InitializeComponent();
        }


        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            btnEasy.BackColor = Color.FromArgb(55, 60, 65);
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(); //Opens MainMenu form
            mainMenu.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the mainMenu forms size with the size of the LeaderBoard form
            if (this.WindowState == FormWindowState.Maximized) { mainMenu.WindowState = FormWindowState.Maximized; } //If the LeaderBoard form was maximised, Maximise the mainMenu form
            mainMenu.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of mainMenu form with the LeaderBoard form
            this.Hide(); //Hides LeaderBoard form
        }
        void changeDifficulty(SelectedDifficulty difficulty) //Highlights the selected difficulty
        {
            if(difficulty == SelectedDifficulty.Easy) 
            {
                btnEasy.BackColor = Color.FromArgb(55, 60, 65);
                btnMedium.BackColor = Color.FromArgb(35, 40, 45);
                btnHard.BackColor = Color.FromArgb(35, 40, 45);
            }
            if(difficulty == SelectedDifficulty.Medium) 
            {
                btnMedium.BackColor = Color.FromArgb(55, 60, 65);
                btnEasy.BackColor = Color.FromArgb(35, 40, 45);
                btnHard.BackColor = Color.FromArgb(35, 40, 45);
            }
            if (difficulty == SelectedDifficulty.Hard) 
            {
                btnHard.BackColor = Color.FromArgb(55, 60, 65);
                btnMedium.BackColor = Color.FromArgb(35, 40, 45);
                btnEasy.BackColor = Color.FromArgb(35, 40, 45);
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Easy;
            changeDifficulty(difficulty);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Medium;
            changeDifficulty(difficulty);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Hard;
            changeDifficulty(difficulty);
        }
    }
}
