using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharpShellWin
{
    public partial class RefferencesForm : Form
    {
        public string[] Refferences
        {
            get { return textBox1.Lines; }
            set { textBox1.Lines = value; }
        }

        public RefferencesForm()
        {
            InitializeComponent();
        }

       
    }
}
