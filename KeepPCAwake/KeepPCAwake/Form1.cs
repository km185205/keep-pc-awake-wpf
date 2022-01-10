using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepPCAwake
{
    public partial class Form1 : Form
    {
        PowerRequest powerRequest = new PowerRequest();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            powerRequest.EnableConstantDisplayAndPower(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            powerRequest.EnableConstantDisplayAndPower(false);
        }
    }
}
