using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Belinda" && textBox3.Text=="123")
            {
                new Menu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username/Password salah");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Belinda" && textBox3.Text == "123")
            {
                new Menu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username/Password salah");
            }
        }
    }
}
