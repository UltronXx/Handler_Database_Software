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
using System.Runtime.InteropServices;

namespace handler
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader sqlRd;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void handlerDB()
        {
            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "SELECT * FROM app.accounts";
                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();

                MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
                sqlDtA.SelectCommand = sqlCmd;

                DataTable sqlDt = new DataTable();
                sqlDtA.Fill(sqlDt);

                // /* dataGridViewName */.DataSource = sqlDt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            handlerDB();
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand("SELECT * FROM app.accounts WHERE Password = '" +
            signInPasswordTextBox.Text + "' AND Username = '" + signInUsernameTextBox.Text + "';", sqlConn);

            try
            {
                sqlConn.ConnectionString = "datasource = localhost; port = 3306; username = root; password = admin";
                sqlConn.Open();
                sqlRd = sqlCmd.ExecuteReader();

                int count = 0;

                while (sqlRd.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    signInCommentButton.Visible = true;
                    signInCommentButton.Text = "Correct passcode";

                    Form2 homePage = new Form2(signInUsernameTextBox.Text);
                    this.Hide();
                    homePage.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate credentials found", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    signInCommentButton.Visible = true;
                    signInCommentButton.Text = "Incorrect passcode";
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
