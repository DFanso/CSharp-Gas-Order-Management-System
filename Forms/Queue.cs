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
    public partial class Queue : Form
    {
        public Queue()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Book_Load(Object sender,EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string MyConnection2 = "datasource=brd4d80jhwckvkrfb75w-mysql.services.clever-cloud.com;port=3306; username = uzgnlt5q7jytc8om; password=upImSxLkUgziqajzdnKO";

            try
            {

                //Display query  
                string Query = "select * from brd4d80jhwckvkrfb75w.orders;";
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
        bool validate()
        {
            if (OrderID.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            string orderid = OrderID.Text;
            string status = Status.Text;

            if (OrderID.Text == "" || Status.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=brd4d80jhwckvkrfb75w-mysql.services.clever-cloud.com; database=brd4d80jhwckvkrfb75w;port=3306; username = uzgnlt5q7jytc8om; password=upImSxLkUgziqajzdnKO "); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from orders where OrderID='" + orderid + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection2 = "datasource=brd4d80jhwckvkrfb75w-mysql.services.clever-cloud.com;port=3306; username = uzgnlt5q7jytc8om; password=upImSxLkUgziqajzdnKO";




                    try
                    {

                        string Query = "update brd4d80jhwckvkrfb75w.orders set Status= '" + status + "'  where OrderID='" + orderid + "';";

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
                    MessageBox.Show("Order ID Does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                OrderID.Text = string.Empty;
                Status.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close(); // always close connection }

            }




            
               

            
        }

        private void fNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
