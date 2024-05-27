using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATalystttt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginHere_Click(object sender, EventArgs e)
        {
            try
            {
                // Path for the game
                string gamePath = @"C:\Users\Administrator\Downloads\Game Assets\YtPLatformer\YTPlatformer\Builds\CATalyst.exe";

                // Start the game
                Process.Start(gamePath);

                // Close the WinForms application
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to start the game: {ex.Message}");
            }
        }
    }
}
