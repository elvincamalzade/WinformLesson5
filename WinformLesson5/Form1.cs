using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //EXAMPLE 1

            Form2 form2 = new Form2();
            this.Hide();
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Example 1
            //Data Transfer by Constructor

            //Form2 form2 = new Form2(textBox1.Text);
            //this.Hide();
            //DialogResult result = form2.ShowDialog();
            //if (result == DialogResult.Cancel)
            //{
            //    this.Show();
            //}



            //Example 2
            //Data Transfer by Method

            //Form2 form2 = new Form2();
            //form2.MyText = textBox1.Text;
            //form2.ShowDialog();



            //Example 3

            //User user = new User
            //{
            //    Name=nameTxtb.Text,
            //    Surname=surnameTxtb.Text
            //};

            //int.TryParse(ageMTxtb.Text, out int age);
            //user.Age = age;


            //Form2 form2 = new Form2();
            //form2.ShowDialog(user);





            //From Child to Parent

            //Form2 form2 = new Form2();

            //if (form2.ShowDialog() == DialogResult.OK)
            //{
            //    label1.Text = form2.MyText;
            //}



            //Form2 form2 = new Form2();
            //form2.Show();

        }
    }
}
