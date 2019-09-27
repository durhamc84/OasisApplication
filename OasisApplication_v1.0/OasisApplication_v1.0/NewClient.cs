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
using System.IO;

namespace OasisApplication_v1._0
{
    public partial class NewClient : Form
    {
   
        public NewClient()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {
            
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

        private void Label1_Click(object sender, EventArgs e)
        {
            OasisDashboard Click = new OasisDashboard();
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private int AddClient()
        {
            DateTime firstArrival = DateTime.Today;
            string adjDOB;

            if (txtDOB.MaskFull == true)
                adjDOB = txtDOB.Text;
            else
                adjDOB = string.Empty;

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT into dbo.ClientInformation(FirstName, LastName, Gender, RaceEthnicity, Veteran, DateOfBirth, FirstArrivalDate, ContactName, ContactPhone)" +
                    "VALUES(@fname,@lname,@gen,@race,@vet,@dob,@first,@conname,@conphone) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@gen", txtGender.Text);
                    cmd.Parameters.AddWithValue("@race", txtRace.Text);
                    cmd.Parameters.AddWithValue("@vet", txtVet.Text);
                    cmd.Parameters.AddWithValue("@dob", adjDOB);
                    cmd.Parameters.AddWithValue("@first", firstArrival);
                    cmd.Parameters.AddWithValue("@conname", txtConName.Text);
                    cmd.Parameters.AddWithValue("@conphone", txtConPhone.Text);
                    int clientID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return clientID;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            int clientID = AddClient();
            int success = 0;

            try
            {                
                using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
                { 
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.ClientName(ClientID,ClientName) VALUES(@id,@name)",con))
                    {
                        string clientName = txtLastName.Text + " ," + txtFirstName.Text + " " + clientID;

                        con.Open();
                        cmd.Parameters.AddWithValue("@id", clientID);
                        cmd.Parameters.AddWithValue("@name", clientName);
                        success = cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    if (success != 0)
                    {
                        MessageBox.Show("Client Saved");
                        NewClient click = this;
                        click.Close();
                    }
                    else
                        MessageBox.Show("Upload Failed");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientInformation client = new ClientInformation();
            client.Show();
        }
    }
}


/* '" +Convert.ToString(firstArrival)+ "',
*/