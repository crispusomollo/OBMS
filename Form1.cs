using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

//string connectionString = "@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents\OBMS.accdb";

namespace OBMS
{
    public partial class Form1 : Form
    {
        //string connectionString = "@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\OBMS.accdb";
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\OBMS.accdb;Persist Security Info=False;";

        public Form1(){
            InitializeComponent();

            // Set Form Properties
            this.Text = "Online Bus Management System";
            this.Size = new System.Drawing.Size(500, 300);

            // Welcome Label
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome to the Bus Management System!";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblWelcome);

            // Login Button
            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(20, 50);
            btnLogin.AutoSize = true;
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            // Conn Test Button
            Button btnDbConn = new Button();
            btnLogin.Text = "Test Connection";
            btnLogin.Location = new System.Drawing.Point(30, 90);
            btnLogin.AutoSize = true;
            btnLogin.Click += BtnDbConn_Click;
            this.Controls.Add(btnDbConn);
            
        }

        private void BtnLogin_Click(object sender, EventArgs e){
            MessageBox.Show("Login functionality not implemented yet!");
        }

        private void BtnDbConn_Click(object sender, EventArgs e){
            try{
                using (OleDbConnection conn = new OleDbConnection(connectionString)){
                    conn.Open();
                    MessageBox.Show("Successfully Connected to DB");
                }
            } 
            catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }

}