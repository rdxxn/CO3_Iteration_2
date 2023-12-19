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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GoTo(Form Destination)
        {
            Destination.Show(); //Opens Destination form
            Destination.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the Destination forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { Destination.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the Destination form
            Destination.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of destination form with the MainMenu form
            this.Hide(); //Hides MainMenu form
        }
        private void PlayClick(object sender, EventArgs e)
        {
            MapSelectMenu MapSelectMenuForm = new MapSelectMenu();
            GoTo(MapSelectMenuForm);
        }

        private void QuitClick(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the program
        }

        private void LeaderBoardClick(object sender, EventArgs e)
        {
            LeaderBoard LeaderBoardForm = new LeaderBoard();
            GoTo(LeaderBoardForm);
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }
    }
}
