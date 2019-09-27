using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OasisApplication_v1._0
{
    public partial class Services : Form
    {

        char identification = 'N';
        char vitalDoc = 'N';
        char transportation = 'N';
        char ISST = 'N';
        char IPS = 'N';
        char hairCut = 'N';
        char phone = 'N';
        char employement = 'N';
        char locker = 'N';
        char mail = 'N';
        char clothing = 'N';
        char housing = 'N';
        char health = 'N';
        char spirit = 'N';
        char recovery = 'N';
        char activities = 'N';
        char crossings = 'N';
        char MCMH = 'N';
        char toiletries = 'N';
        char seasonal = 'N';
        char computer = 'N';
        char nourishment = 'N';
        char assessment = 'N';

        public Services()
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                identification = 'Y';
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                vitalDoc = 'Y';
            }
        }

        private void CheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                transportation = 'Y';
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                ISST = 'Y';
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                IPS = 'Y';
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                hairCut = 'Y';
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                phone = 'Y';
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                employement = 'Y';
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                locker = 'Y';
            }
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                mail = 'Y';
            }
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                clothing = 'Y';
            }
        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                housing = 'Y';
            }
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                health = 'Y';
            }
        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                spirit = 'Y';
            }
        }

        private void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                recovery = 'Y';
            }
        }

        private void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                activities = 'Y';
            }
        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                crossings = 'Y';
            }
        }

        private void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                MCMH = 'Y';
            }
        }

        private void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                toiletries = 'Y';
            }
        }

        private void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                seasonal = 'Y';
            }
        }

        private void CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                computer = 'Y';
            }
        }

        private void CheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                nourishment = 'Y';
            }
        }

        private void CheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                assessment = 'Y';
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet1.ClientName' table. You can move, or remove it, as needed.
            this.clientNameTableAdapter.Fill(this.chrisTestDatabaseDataSet1.ClientName);
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet.ClientInformation' table. You can move, or remove it, as needed.
            this.clientInformationTableAdapter.Fill(this.chrisTestDatabaseDataSet.ClientInformation);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int selectedClient = Convert.ToInt32(comboBox1.SelectedValue);
            int result;

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;User ID = sa; Password = "))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Services(ClientID, Identification, VitalDocuments, Transportation, ISST, IPS, HairCut, Phone, Employment, Locker, Mail, Clothing, Housing, HealthWellness, SpiritualWellness, Recovery, Activities, Crossings, MCMH, Toiletries, Seasonal, Computer, Nourishment, AssessmentAndSupport, DateAdded)" +
                    "VALUES(@clientID, @identification, @vital, @trans, @isst, @ips, @hair, @phone, @employement, @locker, @mail, @clothing, @housing, @health, @spiritual, @recovery, @activities, @crossings, @mcmh, @toiletries, @seasonal, @computer, @nourishment, @assess, @date)", con))
                {
                    cmd.Parameters.AddWithValue("@clientID", selectedClient);
                    cmd.Parameters.AddWithValue("@identification", identification);
                    cmd.Parameters.AddWithValue("@vital", vitalDoc);
                    cmd.Parameters.AddWithValue("@trans", transportation);
                    cmd.Parameters.AddWithValue("@isst", ISST);
                    cmd.Parameters.AddWithValue("@ips", IPS);
                    cmd.Parameters.AddWithValue("@hair", hairCut);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@employement", employement);
                    cmd.Parameters.AddWithValue("@locker", locker);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@clothing", clothing);
                    cmd.Parameters.AddWithValue("@housing", housing);
                    cmd.Parameters.AddWithValue("@health", health);
                    cmd.Parameters.AddWithValue("@spiritual", spirit);
                    cmd.Parameters.AddWithValue("@recovery", recovery);
                    cmd.Parameters.AddWithValue("@activities", activities);
                    cmd.Parameters.AddWithValue("@crossings", crossings);
                    cmd.Parameters.AddWithValue("@mcmh", MCMH);
                    cmd.Parameters.AddWithValue("@toiletries", toiletries);
                    cmd.Parameters.AddWithValue("@seasonal", seasonal);
                    cmd.Parameters.AddWithValue("@computer", computer);
                    cmd.Parameters.AddWithValue("@nourishment", nourishment);
                    cmd.Parameters.AddWithValue("@assess", assessment);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    con.Open();
                    result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Error inserting data into Services!");
                    else
                        MessageBox.Show("Services Saved");
                    con.Close();

                }

                if (txtLockerNum.TextLength != 0)
                {

                    using (SqlCommand command = new SqlCommand("UPDATE dbo.ClientInformation SET LockerAssigned = @locker WHERE ClientID = @clientid", con))
                    {
                        command.Parameters.AddWithValue("@locker", txtLockerNum.Text);                        
                        command.Parameters.AddWithValue("@clientID", selectedClient);

                        con.Open();
                        result = command.ExecuteNonQuery();

                        if (result < 0)
                            MessageBox.Show("Error inserting data into Client Information!");
                        else
                            MessageBox.Show("Client Information Saved");
                        con.Close();

                    }
                }

                if (txtMailSetDate.MaskFull)
                {
                    using (SqlCommand command = new SqlCommand("UPDATE dbo.ClientInformation SET MailSetupDate = @maildate WHERE ClientID = @clientid", con))
                    {
                        command.Parameters.AddWithValue("@maildate", txtMailSetDate.Text);
                        command.Parameters.AddWithValue("@clientID", selectedClient);

                        con.Open();
                        result = command.ExecuteNonQuery();

                        if (result < 0)
                            MessageBox.Show("Error inserting data into Client Information!");
                        else
                            MessageBox.Show("Client Information Saved");
                        con.Close();
                    }
                }
            }

            if (result > 0)
            {
                Services click = this;
                click.Close();
            }
        }        
    }
}
