using System;
using System.Windows.Forms;
using System.Data.OleDb;

string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents\OBMS.accdb";

namespace OBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set Form Properties
            this.Text = "Bus Management System";
            this.Size = new System.Drawing.Size(500, 300);

            // Welcome Label
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome to the Bus Management System!";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblWelcome);

            //Test Connection
            Button btnTestConn = new Button();
            btnTestConn.Text = "Test Connection";
            btnTestConn.Location = new System.Drawing.Point(20,80);

            // Login Button
            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(20, 60);
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login functionality is not implemented yet!");
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            

            try
            {
                using var conn = new OleDbConnection(connectionString);
                conn.Open();
                MessageBox.Show("Database Connected Successfully");
            catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
