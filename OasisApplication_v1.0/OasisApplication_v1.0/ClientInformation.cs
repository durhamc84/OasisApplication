using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace OasisApplication_v1._0
{
    public partial class ClientInformation : Form
    {
        public ClientInformation()
        {
            InitializeComponent();
        }       

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClient Click = new NewClient();
            Click.Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NeedsAssessment Click = new NeedsAssessment();
            Click.Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Services Click = new Services();
            Click.Show();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports Click = new Reports();
            Click.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            OasisDashboard Click = new OasisDashboard();
            Click.Show();
        }

        private DateTime CheckDate()
        {
            string readDate = String.Empty;
            DateTime date = new DateTime(1900,01,01);
            int selectedClient = Convert.ToInt32(comboBox1.SelectedValue);

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;User ID = sa; Password = "))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT SwipeDate FROM dbo.AttendenceLog WHERE ClientID = @client and SwipeDate = (SELECT MAX(SwipeDate) from dbo.AttendenceLog where ClientID = @client2)", con))
                {
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    cmd.Parameters.AddWithValue("@client2", selectedClient);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        readDate = reader["SwipeDate"].ToString();                                             
                    }
                    con.Close();                    
                }
            }

            date = Convert.ToDateTime(readDate);
            return date;

        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet2.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.chrisTestDatabaseDataSet2.Services);
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet1.ClientName' table. You can move, or remove it, as needed.
            this.clientNameTableAdapter.Fill(this.chrisTestDatabaseDataSet1.ClientName);
                             
        }
                    


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClient = Convert.ToInt32(comboBox1.SelectedValue);

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;User ID = sa; Password = "))
            {
                using (SqlCommand cmd = new SqlCommand(@"Select ClientID,FirstName,LastName,Gender,RaceEthnicity,Veteran,DateOfBirth,FirstArrivalDate,LockerAssigned,ContactName,ContactPhone,MailSetupDate from dbo.ClientInformation where ClientID = @client", con))
                {
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtClientID.Text = reader[0].ToString();
                            txtFirstName.Text = reader[1].ToString();
                            txtLastName.Text = reader[2].ToString();
                            txtCIGender.Text = reader[3].ToString();
                            txtCIRace.Text = reader[4].ToString();
                            txtCIVet.Text = reader[5].ToString();
                            txtCIDOB.Text = reader[6].ToString();
                            txtCIFAD.Text = reader[7].ToString();
                            txtCILockNum.Text = reader[8].ToString();
                            txtCIConName.Text = reader[9].ToString();
                            txtCIConPhone.Text = reader[10].ToString();
                            txtCIMail.Text = reader[11].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No results found");
                    }
                    reader.Close();
                    con.Close();
                }

                DataTable dtServe = new DataTable();
                DataTable dtLaundry = new DataTable();
                DataTable dtShower = new DataTable();
                DataTable dtAttend = new DataTable();
                DataTable dtNotes = new DataTable();

                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM dbo.Services WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtServe);
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM dbo.AttendenceLog WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtAttend);
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM dbo.LaundryLog WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtLaundry);
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM dbo.ShowerLog WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtShower);
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"SELECT Note FROM dbo.ClientNotes WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtNotes);
                    con.Close();
                }

                dataGridView1.DataSource = dtServe;
                dataGridView2.DataSource = dtAttend;
                dataGridView3.DataSource = dtLaundry;
                dataGridView4.DataSource = dtShower;
                dataGridView5.DataSource = dtNotes;
            }

            DateTime checkDate = CheckDate();
            DateTime currentDate = DateTime.Today;

            if (Convert.ToInt32(currentDate.Subtract(checkDate)) > 182 && Convert.ToInt32(currentDate.Subtract(checkDate)) < 365)
            {
                label14.Visible = true;
            }
            else if (Convert.ToInt32(currentDate.Subtract(checkDate)) > 365)
            {
                label15.Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process open = new Process();
            open.StartInfo.FileName = @"C:\Program Files (x86)\MSRX\MSRX.exe";
            open.EnableRaisingEvents = true;
            open.Start();
            open.WaitForExit();
            MessageBox.Show("Card Created!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int selectedClient = Convert.ToInt32(comboBox1.SelectedValue);

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;User ID = sa; Password = "))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.ClientNotes(ClientID,Note) VALUES(@client,@note)",con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    cmd.Parameters.AddWithValue("@note", txtNote.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();                    
                }

                DataTable dtNotes = new DataTable();

                using (SqlCommand cmd = new SqlCommand(@"SELECT Note FROM dbo.ClientNotes WHERE ClientID = @client", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@client", selectedClient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtNotes);
                    con.Close();
                }

                txtNote.Clear();
                dataGridView5.DataSource = dtNotes;
            }
        }
    }
}
