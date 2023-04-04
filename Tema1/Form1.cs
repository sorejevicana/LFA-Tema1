using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tema1
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
            textBox2.Clear();
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            string pattern = textBox1.Text;
            // Create a Regex
            Regex rg = new Regex(pattern,RegexOptions.IgnoreCase);
            string FindPattern = textBox2.Text;
            //Get all matches
           MatchCollection matchedpattern = rg.Matches(FindPattern);
            // Print how many are found
            if (matchedpattern.Count > 0)
            {
                richTextBox1.Text = "Pattern is find  " + matchedpattern.Count.ToString() + " times";
            }
            else
            {
                richTextBox1.Text = "No Match";
                MessageBox.Show("No match");
            }
            
        }

        
    }

}
