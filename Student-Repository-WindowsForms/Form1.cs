using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kikk
{
    public partial class Form1 : Form
    {
        private Register r = new Register();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fName = textBox1_Name.Text;
            var LName = textBox2_LName.Text;
            var grade = double.Parse(textBox3_Grade.Text);
            var age = int.Parse(textBox4_Age.Text);

            var student = new Student(fName, LName, grade, age);
            r.students.Add(student);
            textBox1_Name.Text = "";
            textBox2_LName.Text = "";
            textBox3_Grade.Text = "";
            textBox4_Age.Text = "";
        }

        private void button2_Report_Click(object sender, EventArgs e)
        {
            Registered rs = new Registered(r.students);
            rs.ShowDialog();

        }
    }
}
