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
    public partial class ListStringForm : Form
    {
        public List<string> StringData
        {
            get { return textBox1.Lines.ToList(); }
            set { textBox1.Lines = value.ToArray(); }
        }

        public string FormHeader 
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public ListStringForm()
        {
            InitializeComponent();
        }

       
    }
}
