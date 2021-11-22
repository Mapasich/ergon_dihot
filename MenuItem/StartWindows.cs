using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuItem
{
    public partial class StartWindows : Form
    {
        public StartWindows()
        {
            InitializeComponent();
        }

        public static string equation = "x^3 + x^2 + x = 0";
        public static bool createGraph;
        public static int key = 0;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        public static bool Start(bool r1, bool r2, bool r4, bool cgY, bool cgN)
        {
            if (r1 != true)
            {
                if (r2 == true)
                {
                    equation = "x^4 + x^3 + x = 0";
                }
                else if (r4 == true)
                {
                    equation = "x^2 + x + c = 0";
                }
            }
            if (cgN)
            {
                createGraph = false;
            }
            else if (cgY)
            {
                createGraph = true;
            }
            key = 1;
            return createGraph;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool r1 = radioButton1.Checked;
            bool r2 = radioButton4.Checked;
            bool r4 = radioButton2.Checked;
            bool cgN = radioButton6.Checked;
            bool cgY = radioButton5.Checked;
            Start(r1, r2, r4, cgY, cgN);
            this.Close();
        }
    }
}