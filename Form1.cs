using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterTab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Return押下時にビープ音がならないようにする
            e.SuppressKeyPress = true;
            if (e.KeyCode.ToString()=="Return")
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
