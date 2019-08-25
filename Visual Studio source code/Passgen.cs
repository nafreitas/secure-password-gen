using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenForm
{
    public partial class Passgen : Form
    {
        int pwdlen = 9;
        char[] ch1 = new char[9] { '!', '@', '#', '$', '%', '+', '?', ']', '[' };
        char [] ch2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

        public Passgen()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charactersToolStripMenuItem.Checked = true;
            specialCharactersToolStripMenuItem.Checked = true;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            int flag;
            int index;
            string buffer;
            for (int i = 0; i < pwdlen; i++)
            {
                if (specialCharactersToolStripMenuItem.Checked == true)
                    flag = r1.Next(1, 4);
                else flag = 1;
                if (flag == 1 || flag == 2)
                {
                    index = r2.Next(0, 62);
                    buffer = ch2[index].ToString();
                    textBox1.AppendText(buffer);
                }
                else if (flag == 3)
                {
                    index = r3.Next(0, 9);
                    buffer = ch1[index].ToString();
                    textBox1.AppendText(buffer);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch(ArgumentNullException)
            {
                //continue
            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch (ArgumentNullException)
            {
                //continue
            }
            textBox1.ResetText();
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pwdlen = 9;
            charactersToolStripMenuItem.Checked = true;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem5.Checked = false;

        }

        private void charactersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pwdlen = 10;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = true;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
        }

        private void charactersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pwdlen = 11;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = true;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem5.Checked = false;

        }

        private void charactersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pwdlen = 12;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = true;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem5.Checked = false;

        }

        private void charactersToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pwdlen = 13;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = true;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem5.Checked = false;

        }

        private void charactersToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            pwdlen = 14;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = true;
            charactersToolStripMenuItem5.Checked = false;

        }

        private void charactersToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            pwdlen = 15;
            charactersToolStripMenuItem.Checked = false;
            charactersToolStripMenuItem1.Checked = false;
            charactersToolStripMenuItem2.Checked = false;
            charactersToolStripMenuItem3.Checked = false;
            charactersToolStripMenuItem4.Checked = false;
            charactersToolStripMenuItem5.Checked = false;
            charactersToolStripMenuItem6.Checked = true;
            
        }

        private void specialCharacterAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
        }

        private void SpecialCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (specialCharactersToolStripMenuItem.Checked == true)
            specialCharactersToolStripMenuItem.Checked = false;
            else if (specialCharactersToolStripMenuItem.Checked == false)
                specialCharactersToolStripMenuItem.Checked = true;

        }
    }
}
