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
    public partial class MapSelectMenu : Form
    {
        public static SelectedMap map;
        public enum SelectedMap
        {
            Map1,
            Map2,
            Map3
        }
        MainMenu mainMenu = new MainMenu();
        DifficultySelectMenu difficultySelectMenu = new DifficultySelectMenu();
        public MapSelectMenu()
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

        private void MapSelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e) //Opens MainMenu Form and Hides the previous form
        {
            GoTo(mainMenu);
        }

        private void btnMap1_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map1;
            GoTo(difficultySelectMenu);
        }

        private void btnMap2_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map2;
            GoTo(difficultySelectMenu);
        }

        private void btnMap3_Click(object sender, EventArgs e)
        {
            map = SelectedMap.Map3;
            GoTo(difficultySelectMenu);
        }
    }
}
