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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }


        bool validate()
        {
            if ((nic.Text == "") || (type.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string NIC = nic.Text;
            string Type = type.Text;

            
            if (nic.Text == "" || type.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type.Text == "TYPE 1" || type.Text == "TYPE 2" || type.Text == "TYPE 3")
            {
                MySqlConnection con = new MySqlConnection("datasource=brd4d80jhwckvkrfb75w-mysql.services.clever-cloud.com; database=brd4d80jhwckvkrfb75w;port=3306; username = uzgnlt5q7jytc8om; password=upImSxLkUgziqajzdnKO"); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customers where NIC='" + NIC + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection = "datasource=brd4d80jhwckvkrfb75w-mysql.services.clever-cloud.com;port=3306; username = uzgnlt5q7jytc8om; password=upImSxLkUgziqajzdnKO";

                    try
                    {

                        string Query = "insert into brd4d80jhwckvkrfb75w.orders(NIC, Type) values('" + NIC + "','" + Type + "');";

                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection);

                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Order Added to the Queue", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("NIC Does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                nic.Text = string.Empty;
                type.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close(); // always close connection }

            }
            else
            {
               

                MessageBox.Show("Wrong Gas Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }

        
    }
