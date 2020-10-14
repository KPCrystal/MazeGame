using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Event

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            retryGame();
        }

        /// <summary>
        /// Wall hit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            retryGame();
        }

        /// <summary>
        /// End point event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void End_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Won!");
        }

        #endregion

        #region Method

        /// <summary>
        /// Set cursor to starting point
        /// </summary>
        private void retryGame()
        {
            Point startingpoint = lblStart.Location;
            Cursor.Position = PointToScreen(startingpoint);
        }

        #endregion

    }
}
