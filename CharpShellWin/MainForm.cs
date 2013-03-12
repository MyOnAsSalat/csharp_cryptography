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
    public partial class MainForm : Form
    {
        public MainForm()
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

        

        CharpExecuter cs;

        //Инициализация
        private void Form1_Load(object sender, EventArgs e)
        {
            cs = new CharpExecuter(new ExecuteLogHandler(Log));
        }
        
        //Перенаправление вывода в textbox
        public void Log(object msg) 
        {
            textBox2.Text += string.Concat(msg, Environment.NewLine);
        }

        //Выполнение введенного кода
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            cs.FormatSources(textBox1.Text);
            cs.Execute();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListStringForm rf = new ListStringForm();
            rf.StringData = cs.Refferences;
            rf.FormHeader = "Refferences";
            rf.ShowDialog();
            cs.Refferences = rf.StringData;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "CSharp files (*.cs)|*.cs|All files (*.*)|*.*";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                File.WriteAllText(sf.FileName,  cs.FormatSources(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ListStringForm rf = new ListStringForm();
            rf.StringData = cs.Usings;
            rf.FormHeader = "Usings";
            rf.ShowDialog();
            cs.Usings = rf.StringData;
        }
    }
}
