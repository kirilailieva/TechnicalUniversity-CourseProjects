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
    public partial class Registered : Form
    {
        private List<Student> AllStudents;
        public Registered(List<Student> allStudents)
        {
            InitializeComponent();
            AllStudents = allStudents;
            foreach (var student in AllStudents)
            {
                listBox1.Items.Add(student);
            }
        }

        private void Registered_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> st = new List<Student>();
            st.AddRange(AllStudents.Where(x => x.Grade >= 5.50).ToList());
            Filtered excellent = new Filtered(st);
            excellent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> st = new List<Student>();
            st.AddRange(AllStudents.Where(x => x.Grade < 3.00).ToList());
            Filtered excellent = new Filtered(st);
            excellent.ShowDialog();
        }
    }
}
