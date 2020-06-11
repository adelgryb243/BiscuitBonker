using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiscuitBonker
{
    public partial class Form1 : Form
    {
        int cookieCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cookieButton_Click(object sender, EventArgs e)
        {
            cookieCount++;
            outputLabel.Text = "" + cookieCount;

        }
    }
}
