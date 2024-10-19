using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class OpeningScreen : Form
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void OpeningScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new
            SoundPlayer(Snake.Properties.Resources.Predator_wav);
            sp.PlayLooping();
        }      

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            ChooseOption choose = new ChooseOption();
            choose.ShowDialog();
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
