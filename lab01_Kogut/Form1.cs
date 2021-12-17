using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_Kogut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Lina" && textBox_password.Text == "4321")
                {
                label_enter.BackColor = Color.Green;
                MessageBox.Show("Hello, Lina");
            }
            else
            {
                label_enter.BackColor = Color.Red;
                MessageBox.Show("Error login or Password");
            }
        }
    }
}
