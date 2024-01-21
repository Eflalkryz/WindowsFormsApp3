using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Context c = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //c.Database.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Students.ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var result = c.Students.Where(x => x.Exam1 < 50);
                dataGridView1.DataSource = result.ToList();

            }
            if (radioButton2.Checked)
            {
                var result = c.Students.Where(x => x.Name == "Mehmet");
                dataGridView1.DataSource = result.ToList();

            }
            if (radioButton3.Checked)
            {
                var result = c.Students.Where(x => x.Name == textBox1.Text || x.Surname == textBox1.Text);
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton4.Checked)
            {
                var result = c.Students.Select(x => new { Surname = x.Surname });
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton5.Checked)
            {
                var result = c.Students.Select(x => new { Name = x.Name.ToUpper(), Surname = x.Surname.ToLower() });
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton6.Checked)
            {
                var result = c.Students.Select(x => new { Name = x.Name.ToUpper(), Surname = x.Surname.ToLower() }).Where(x=>x.Name !="Mehmet");
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton7.Checked)
            {
                var result = c.Students.Select(x => new
                {
                    Name = x.Name,
                    Surname = x.Surname,
                    State = x.Avg > 50 ? "Pass" : "Fail"
                });
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton8.Checked)
            {
                var result = c.Students.OrderBy(x => x.StudentID).Take(3);
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton9.Checked)
            {
                var result = c.Students.OrderByDescending(x => x.StudentID).Take(3);
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton10.Checked)
            {
                var result = c.Students.OrderBy(x => x.Name);
                dataGridView1.DataSource = result.ToList();
            }
            if (radioButton11.Checked)
            {
                var result = c.Students.OrderBy(x => x.Name).Skip(5);
                dataGridView1.DataSource = result.ToList();

            }
            if (radioButton12.Checked)
            {
                var result = c.Students.Max(x => x.Avg);
                label1.Text = result.ToString();

            }
            if (radioButton13.Checked)
            {
                var result = c.Students.Select(x => new { Name = x.Name, Surname = x.Surname, Average = x.Avg }).OrderByDescending(x => x.Average).Take(1);
                dataGridView1.DataSource = result.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Email = txtEmail.Text;
            student.Telephone = txtTelephone.Text;
            student.Adress = txtAdress.Text;
            student.Exam1 = Convert.ToInt32(txtExam1.Text);
            student.Exam2 = Convert.ToInt32(txtExam2.Text);
            student.Avg = Convert.ToInt32(txtAvg.Text);
            c.Students.Add(student);
            c.SaveChanges();
            MessageBox.Show("Student is added.");
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSurname.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelephone.Text = String.Empty;
            txtAdress.Text = string.Empty;
            txtExam1.Text = string.Empty;
            txtExam2.Text = string.Empty;
            txtAvg.Text = String.Empty;




        }

        private void remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Student student = c.Students.Find(id);
            c.Students.Remove(student);
            c.SaveChanges();
            MessageBox.Show("Student is deleted.");
            txtId.Text = string.Empty;
        }
    }
}
