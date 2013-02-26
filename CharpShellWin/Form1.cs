using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CharpShell;

namespace CharpShellWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files(*.txt)|*.txt|CSharp files (*.cs)|*.cs|All files (*.*)|*.*";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = File.ReadAllText(of.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            cs.FormatSources(textBox1.Text);
            cs.Execute();
        }

        CharpExecuter cs;

        private void Form1_Load(object sender, EventArgs e)
        {
            cs = new CharpExecuter(new ExecuteLogHandler(Log));
        }
        
        public void Log(string msg) 
        {
            textBox2.Text += string.Concat(msg, Environment.NewLine);
        }
    }
}
