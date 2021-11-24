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
    public partial class Form3 : Form
    {
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

        int REFERENCE;
        string LABELNAME;
        string DEPARTMENT;
        string DATE;
        string MACADDRESS;
        string DEVICENAME;
        string ASSIGNEE;

        public Form3(int _reference, string _labelName, string _department, string _date, string _macAddress, string _deviceName, string _assignee /*, string _summary */)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            REFERENCE = _reference;
            LABELNAME = _labelName;
            DEPARTMENT = _department;
            DATE = _date;
            MACADDRESS = _macAddress;
            DEVICENAME = _deviceName;
            ASSIGNEE = _assignee;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            	    // Convert INTEGER text box to String
	        referenceTextBox.Text = REFERENCE.ToString();
            labelNameTextBox.Text = LABELNAME;
            departmentComboBox.Text = DEPARTMENT;
            dateTimePicker.Text = DATE;
            macAddressTextBox.Text = MACADDRESS;
            deviceNameTextBox.Text = DEVICENAME;
            assigneeTextBox.Text = ASSIGNEE;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Convert INTEGER text box to Int32
            REFERENCE = Convert.ToInt32(referenceTextBox.Text);
            LABELNAME = labelNameTextBox.Text;
            DEPARTMENT = departmentComboBox.Text;
            DATE = dateTimePicker.Text;
            MACADDRESS = macAddressTextBox.Text;
            DEVICENAME = deviceNameTextBox.Text;
            ASSIGNEE = assigneeTextBox.Text;

            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "UPDATE app.devices SET reference = @reference," +
                                                            "labelName = @labelName," +
                                                            "department = @department," +
                                                            "date = @date," +
                                                            "macAddress = @macAddress," +
                                                            "deviceName = @deviceName," +
                                                            "assignee = @assignee WHERE reference = @reference";

                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

                sqlConn.Open();
                sqlCmd.Parameters.AddWithValue("@reference", REFERENCE);
                sqlCmd.Parameters.AddWithValue("@labelName", LABELNAME);
                sqlCmd.Parameters.AddWithValue("@department", DEPARTMENT);
                sqlCmd.Parameters.AddWithValue("@date", DATE);
                sqlCmd.Parameters.AddWithValue("@macAddress", MACADDRESS);
                sqlCmd.Parameters.AddWithValue("@deviceName", DEVICENAME);
                sqlCmd.Parameters.AddWithValue("@assignee", ASSIGNEE);

                int result = sqlCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Device update successful", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Device update unsuccessful", "Handler management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            labelNameTextBox.Text = "";
            departmentComboBox.Text = "";
            dateTimePicker.ResetText();
            macAddressTextBox.Text = "";
            deviceNameTextBox.Text = "";
            assigneeTextBox.Text = "";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
