using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeGenerator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Viewer viewerWindow = new Viewer();
            viewerWindow.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Form1 generatorWindow = new Form1();
            generatorWindow.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
