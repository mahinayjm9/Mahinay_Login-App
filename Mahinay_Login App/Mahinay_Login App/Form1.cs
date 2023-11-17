using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahinay_Login_App
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            result = db.sp_login(textBox1.Text, textBox2.Text).Count();

            if (result == 0)
            {
                MessageBox.Show("Unknow username or password");
            }
            else
            {
                if(db.sp_type(textBox1.Text,textBox2.Text) == 0)
                {
                    MessageBox.Show("Welcome Admin");
                }
                else
                {
                    MessageBox.Show("Welcome Staff");
                }
                Form2 dashboardForm = new Form2();
                dashboardForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
