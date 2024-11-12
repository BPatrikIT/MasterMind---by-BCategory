using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace MasterMind
{
    public partial class mastermind : Form
    {
        Thread th;

        public mastermind()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(openGame);
            th.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openGame()
        {
            Application.Run(new game());
        }
    }
}