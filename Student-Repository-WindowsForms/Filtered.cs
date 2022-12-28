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
    public partial class Filtered : Form
    {
        public Filtered(List<Student> filteredStudents)
        {
            InitializeComponent();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student.ToString());
            }
        }

        private void Filtered_Load(object sender, EventArgs e)
        {

        }
    }
}
