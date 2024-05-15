using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Management_System
{
    public partial class adduser : Form
    {
        UserClass user = new UserClass();
        public adduser()
        {
            InitializeComponent();
        }

        private void adduser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.getaddUser();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void getTable()
        {
            dataGridView1.DataSource = user.getaddUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""||textBox2.Text =="" || textBox3.Text == "")
            {
                MessageBox.Show("Remplir les champs !!!");
            }
            else
            {
                try
                {
                    string username = textBox1.Text;
                    string pass = textBox2.Text;
                    string id = textBox3.Text;

                    Boolean insertUser = user.insertUser(id, username, pass);
                    if (insertUser)
                    {
                        MessageBox.Show("New User save successfuly", "User Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button2.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "Error Save" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.PerformClick();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Required Field - Id no", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox3.Text;
                    Boolean deleteGuest = user.removeUser(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("User data remove successfuly", "User Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // you can clear all text after the delete action
                        button2.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - User not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Required Field - Id no, first name and phone no:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string username = textBox1.Text;
                    string pass = textBox2.Text;
                    string id = textBox3.Text;

                    Boolean editGuest = user.editUser(id,username,pass);
                    if (editGuest)
                    {
                        MessageBox.Show("User data Update successfuly", "Update Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button2.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest data not update", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
