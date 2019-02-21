using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flipBtn_Click(object sender, EventArgs e)
        {
            cardBackpic.Visible = !cardBackpic.Visible;
            cardFacePic.Visible = !cardFacePic.Visible;
        }

        private void showFaceBtn_Click(object sender, EventArgs e)
        {
            cardBackpic.Visible = false;
            cardFacePic.Visible = true;
        }

        private void showBackBtn_Click(object sender, EventArgs e)
        {
            cardBackpic.Visible = true;
            cardFacePic.Visible = false;
        }
    }
}
