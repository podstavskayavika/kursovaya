using KidsGame.Data_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsGame.User_Interface
{
    public partial class GameMenu : Form
    {
        DataOperations dataOp;

        public GameMenu(DataOperations dataOp)
        {
            InitializeComponent();
            this.dataOp = dataOp;
        }

        private void goTooPaint_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen(dataOp);
            gameScreen.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            gameScreen.Show();
            this.Hide();
        }

        private void GameMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goToFigures_Click(object sender, EventArgs e)
        {
            FigureTransferring figures = new FigureTransferring(dataOp);
            figures.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            figures.Show();
            this.Hide();
        }
    }
}
