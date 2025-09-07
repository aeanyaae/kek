using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        public Logic Logic { get; set; }

        public Form1()
        {
            InitializeComponent();
            Logic = new Logic();
            this.button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.AddStudent(textBox1.Text, textBox2.Text, textBox3.Text);
            listBox1.Items.Add(Logic.GetAll());
        }
    }
}
