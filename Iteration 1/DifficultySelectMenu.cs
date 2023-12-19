using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration_1
{
    public partial class DifficultySelectMenu : Form
    {
        public static SelectedDifficulty difficulty = SelectedDifficulty.Easy; //Defaults the selected value to easy
        public enum SelectedDifficulty
        {
            Easy,
            Medium,
            Hard
        }
        public DifficultySelectMenu()
        {
            InitializeComponent();
        }
        void GoTo(Form Destination)
        {
            Destination.Show(); //Opens Destination form
            Destination.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the Destination forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { Destination.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the Destination form
            Destination.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of destination form with the MainMenu form
            this.Hide(); //Hides MainMenu form
        }
        private void DifficultySelectMenu_Load(object sender, EventArgs e)
        {
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MapSelectMenu mapSelectMenu = new MapSelectMenu();
            GoTo(mapSelectMenu);
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Easy;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Medium;

        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            difficulty = SelectedDifficulty.Hard;

        }
    }
}
