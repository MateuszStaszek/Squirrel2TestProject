using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squirrel2
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBinding()
        {
            PeopleList.DataSource = people;
            PeopleList.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int ageInt = Int32.Parse(ageInsText.Text);
            int IDInt = Int32.Parse(IDInsText.Text);
            db.InsertPerson(IDInt,firstNameInsText.Text, lastNameInsText.Text, ageInt);
            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            ageInsText.Text = "TestIfWOrks";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
