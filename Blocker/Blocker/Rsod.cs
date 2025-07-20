using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocker
{
    public partial class Rsod : Form
    {
        public Rsod()
        {
            InitializeComponent();
        }

        private void Rsod_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Rsod_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
