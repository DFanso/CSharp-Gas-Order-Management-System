using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ModernDesignTutorial.Forms
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool validate()
        {
            if ((fNameTxtBox.Text == "") || (textBox2.Text == "") ||
               (textBox4.Text == "") || (textBox1.Text == "") ||
               (textBox3.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        bool validateDelete()
        {
            if (textBox3.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {






           



        }

        private void update_Click(object sender, EventArgs e)
        {


            

        }

        private void remove_Click(object sender, EventArgs e)
        {

            

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void update_Click_1(object sender, EventArgs e)
        {
           

        }

        private void remove_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=sql6.freemysqlhosting.net;port=3306;username=sql6484926;password=rr1HCtdhkv";

            try
            {

                //Display query  
                string Query = "select * from sql6484926.customers;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // MyConn2.Close();  
            }

        }

        private void add_Click_1(object sender, EventArgs e)
        {

            string MyConnection = "datasource=sql6.freemysqlhosting.net;port=3306;username=sql6484926;password=rr1HCtdhkv";


            if (validate())
            {
                try
                {
                    string fname = fNameTxtBox.Text;
                    string lname = textBox2.Text;
                    string address = textBox4.Text;
                    int phoneNo = Convert.ToInt32(textBox1.Text);
                    string nic = textBox3.Text;

                    string Query = "insert into sql6484926.customers(NIC, Fname, Lname, PhoneNo, Address) values('" + nic + "','" + fname + "','" + lname + "','" + phoneNo + "', '" + address + "');";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Customer Added to the database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Enter all Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void update_Click_2(object sender, EventArgs e)
        {
            if (validate())
            {
                string MyConnection2 = "datasource=sql6.freemysqlhosting.net;port=3306;username=sql6484926;password=rr1HCtdhkv";

                string fname = fNameTxtBox.Text;
                string lname = textBox2.Text;
                string address = textBox4.Text;
                int phoneNo = Convert.ToInt32(textBox1.Text);
                string nic = textBox3.Text;


                try
                {

                    string Query = "update sql6484926.customers set Fname ='" + fname + "',Lname='" + lname + "',PhoneNo='" + phoneNo + "',Address='" + address + "'  where NIC='" + nic + "';";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Customer Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Enter NIC Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void remove_Click_2(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=sql6.freemysqlhosting.net;port=3306;username=sql6484926;password=rr1HCtdhkv";

            string nic = textBox3.Text;

            if (validateDelete())
            {
                try
                {

                    string Query = "delete from sql6484926.customers where NIC='" + nic + "';";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Customer Removed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Enter NIC Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}

