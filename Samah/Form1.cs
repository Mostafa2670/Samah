using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Samah.Classes;
namespace Samah
{
    public partial class Form1 : Form
    {
        private IBarometry iBarometry = new Barometry();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           iBarometry.Group_1();
         
        }
    }
}
