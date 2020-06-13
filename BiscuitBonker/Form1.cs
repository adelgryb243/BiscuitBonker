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

namespace BiscuitBonker
{
    public partial class Form1 : Form
    {
        int cookieCount = 0;
        public Form1()
        {
            InitializeComponent();
            realTimeLoop();
        }
        async void realTimeLoop() //things you want to check constantly go here, ex grandmas baking (things user doesnt do)
        {
            while (true) 
            {
               
                if (cookieCount >= 10)
                {
                    grandmaLabel.Text = "1 grandma!";
               
                }
                await Task.Delay(10);
                
                
            }
        }

        private void cookieButton_Click(object sender, EventArgs e)
        {
            cookieCount++;
                outputLabel.Text = "" + cookieCount;
            
        }
    }
}
