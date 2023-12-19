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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            MapSelectMenu.SelectedMap map = MapSelectMenu.map;
            DifficultySelectMenu.SelectedDifficulty difficulty = DifficultySelectMenu.difficulty;
        }
    }
}
