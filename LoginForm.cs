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

namespace ModernDesignTutorial
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string uname = username.Text;
            string pass = password.Text;


            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource= sql6.freemysqlhosting.net; database=sql6484926;port=3306; username = sql6484926; password=rr1HCtdhkv"); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users where Username='" + uname + "' AND Password='" + pass + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successfully Sign In!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                username.Text = string.Empty;
                password.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close(); // always close connection }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
