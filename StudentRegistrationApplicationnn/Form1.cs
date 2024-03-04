using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplicationnn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                dayBox.Items.Add(day);
            }

            for(int year = 1900; year < 2024; year++)
            {
                yearBox.Items.Add(year);
            }

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            foreach (string month in months)
            {
                monthBox.Items.Add(month);
            }

            string[] programs = {"Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information System", "Bachelor of Science in Computer Engineering"};

            foreach (string program in programs) 
            { 
                programBox.Items.Add(program);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstInput = lastName.Text;
            string secondInput = firstName.Text;
            string thirdInput = middleName.Text;
            string gender = "None";

            string getName = "Student Name: " + secondInput + " " + thirdInput + " " + secondInput;

            string getMonth = "Birth Date: " + dayBox.Text + "/" + monthBox.Text +"/" + yearBox.Text;

            string getProgram = "Program: " + programBox.Text;

            if (maleRadio.Checked)
            {
                gender = "Male";
            }else if (femaleRadio.Checked)
            {
                gender = "Female";
            }

            MessageBox.Show(getName + "\n" + getMonth + "\n" + "Gender: " + gender + "\n" + getProgram);
        }
    }
}
