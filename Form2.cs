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
    public partial class Form2 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();

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

        public Form2(string _username)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            usernameLabel.Text = _username;
        }

        private void departmentDB()
        {
            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "SELECT * FROM app.department";
                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();

                MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
                sqlDtA.SelectCommand = sqlCmd;

                DataTable sqlDt = new DataTable();
                sqlDtA.Fill(sqlDt);

                //dataGridView.DataSource = sqlDt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deviceDB()
        {
            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "SELECT * FROM app.devices";
                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();

                MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
                sqlDtA.SelectCommand = sqlCmd;

                DataTable sqlDt = new DataTable();
                sqlDtA.Fill(sqlDt);

                dataGridView.DataSource = sqlDt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            referenceTextBox.Text = "";
            labelNameTextBox.Text = "";
            departmentComboBox.Items.Clear();
            dateTimePicker.ResetText();
            macAddressTextBox.Text = "";
            deviceNameTextBox.Text = "";
            othersTextBox.Text = "";
            assigneeTextBox.Text = "";
            summaryTextBox.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                // Deleting from Database

            if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int columnHeader;
                columnHeader = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["referenceColumn"].Value);

                string deviceName;
                deviceName = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["deviceNameColumn"].Value);

                try
                {
                    string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                    string sqlQuery = "DELETE FROM app.devices WHERE reference = @reference";

                    MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

                    sqlConn.Open();
                    sqlCmd.Parameters.AddWithValue("@reference", columnHeader);

                    int result = sqlCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(deviceName + " deleted successfully", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deviceDB();
                    }
                    else
                    {
                        MessageBox.Show(deviceName + " deletion unsuccessful", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            // Updating in Database

            if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                // Declaring Objects

                int reference;
                string labelName;
                string department;
                string date;
                string macAddress;
                string deviceName;
                string assignee;

            // Convert INTEGER object to Int32
                reference = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["referenceColumn"].Value);
                labelName = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["labelNameColumn"].Value);
                department = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["departmentColumn"].Value);
                date = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["dateColumn"].Value);
                macAddress = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["macAddressColumn"].Value);
                deviceName = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["deviceNameColumn"].Value);
                assignee = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["assigneeColumn"].Value);

                Form3 devicesForm = new Form3(reference, labelName, department, date, macAddress, deviceName, assignee);
                devicesForm.ShowDialog();

                deviceDB();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            deviceDB();

            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "SELECT * FROM app.department";

                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();
                MySqlDataReader sqlRd = sqlCmd.ExecuteReader();

                while (sqlRd.Read())
                {
                    departmentComboBox.Items.Add(sqlRd.GetString("Department"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertDeviceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "INSERT INTO app.devices (reference, labelName, department, date, macAddress, deviceName, assignee, summary)" +
                    "values('" + referenceTextBox.Text + "'," +
                            "'" + labelNameTextBox.Text + "'," +
                            "'" + departmentComboBox.Text + "'," +
                            "'" + dateTimePicker.Text + "'," +
                            "'" + macAddressTextBox.Text + "'," +
                            "'" + deviceNameTextBox.Text + "'," +
                            "'" + assigneeTextBox.Text + "'," +
                            "'" + summaryTextBox.Text + "');";

                MySqlConnection sqlConn = new MySqlConnection(sqlServer);

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlRd;

                sqlConn.Open();
                sqlRd = sqlCmd.ExecuteReader();
                MessageBox.Show(deviceNameTextBox.Text + " added successfully", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConn.Close();
                deviceDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dashAddDeviceButton_Click(object sender, EventArgs e)
        {
            addDevicePanel.Show();
            devicesPanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void dashDevicesButton_Click(object sender, EventArgs e)
        {
            devicesPanel.Show();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void dashHomeButton_Click(object sender, EventArgs e)
        {
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addDevicePanel.Show();
            devicesPanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void devicesButton1_Click(object sender, EventArgs e)
        {
            devicesPanel.Show();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void devicesButton2_Click(object sender, EventArgs e)
        {
            devicesPanel.Show();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void devicesButton3_Click(object sender, EventArgs e)
        {
            devicesPanel.Show();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
            managePanel.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 credentialPage = new Form1();
            credentialPage.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != "")
            {
                try
                {
                    Random genNumber = new Random();
                    int reference = genNumber.Next(0, 2500);

                    string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                    string sqlQuery = "INSERT INTO app.accounts (Reference, Firstname, Lastname, Username, Password, Contact)" +
                        "values('" + reference + "'," +
                                "'" + firstNameTextBox.Text + "'," +
                                "'" + lastNameTextBox.Text + "'," +
                                "'" + usernameTextBox.Text + "'," +
                                "'" + passwordTextBox.Text + "'," +
                                "'" + contactTextBox.Text + "');";

                    MySqlConnection sqlConn = new MySqlConnection(sqlServer);

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    MySqlDataReader sqlRd;

                    sqlConn.Open();
                    sqlRd = sqlCmd.ExecuteReader();

                    MessageBox.Show(usernameTextBox.Text + " account created successfully", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    contactTextBox.Text = "";

                    sqlConn.Close();
                    deviceDB();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                passwordTextBox.Text = "* Strictly required *";
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            contactTextBox.Text = "";
        }

        private void userAccountButton_Click(object sender, EventArgs e)
        {
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Show();
            managePanel.Hide();
        }

        private void superUserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(superUserTextBox.Text == "superuser")
            {
                MessageBox.Show("Super User can now add accounts", "Handler super mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createButton.Enabled = true;
                superUserTextBox.Text = "";
            }
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (editDepartmentTextBox.Text != "")
            {
                try
                {
                    Random genNumber = new Random();
                    int reference = genNumber.Next(0, 2500);

                    string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                    string sqlQuery = "INSERT INTO app.department (Reference, Department)" +
                        "values('" + reference + "'," +
                                "'" + editDepartmentTextBox.Text + "');";

                    MySqlConnection sqlConn = new MySqlConnection(sqlServer);

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    MySqlDataReader sqlRd;

                    sqlConn.Open();
                    sqlRd = sqlCmd.ExecuteReader();
                    sqlConn.Close();

                    departmentDB();

                    MessageBox.Show(editDepartmentTextBox.Text + " added as Department", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editDepartmentTextBox.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dashManageButton_Click(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void removeDepartmentButton_Click(object sender, EventArgs e)
        {
            if (editDepartmentTextBox.Text != "")
            {
                try
                {
                    string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                    string sqlQuery = "DELETE FROM app.department WHERE Department = '" + editDepartmentTextBox.Text + "';";

                    MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    MySqlDataReader sqlRd;

                    sqlConn.Open();
                    sqlRd = sqlCmd.ExecuteReader();

                    MessageBox.Show(editDepartmentTextBox.Text + " department has been deleted successfully", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editDepartmentTextBox.Text = "";

                    sqlConn.Close();
                    departmentDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editDepartmentButton_Click(object sender, EventArgs e)
        {
            userCredentialsButton.Location = new Point(32, 394);
            editDepartmentPanel.Visible = true;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            editDepartmentPanel.Hide();
            userCredentialsButton.Location = new Point(32, 285);
        }

        private void manageButton1_Click(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void manageButton2_Click(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void manageButton3_Click(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void manageButton1_Click_1(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void manageButton2_Click_1(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }

        private void manageButton3_Click_1(object sender, EventArgs e)
        {
            managePanel.Show();
            devicesPanel.Hide();
            addDevicePanel.Hide();
            addUserAccountPanel.Hide();
        }
    }
}
