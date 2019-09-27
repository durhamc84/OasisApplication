using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace OasisApplication_v1._0
{
    public partial class OasisDashboard : Form
    {
        public OasisDashboard()
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

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NeedsAssessment Click = new NeedsAssessment();
            Click.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadAttendence()
        {
            List<string> clientName = new List<string>();
            DataTable dt = new DataTable();            
            string date = DateTime.Today.ToString("yyyy-MM-dd");

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT ClientName FROM dbo.ClientName cn 
                    JOIN dbo.AttendenceLog al on al.ClientID = cn.ClientID
                    WHERE cn.ClientID IN (
                    SELECT ClientID FROM dbo.AttendenceLog WHERE SwipeDate = @date and ClientTimeOut = '00:00:00'
                    )
                    and SwipeDate = @date and ClientTimeOut = '00:00:00'", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@date", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        clientName.Add(reader["ClientName"].ToString());
                    }
                    con.Close();
                }

            }

            dt.Columns.Add("Client Name");

            foreach (string name in clientName)
            {
                dt.Rows.Add(name);
            }

            dataGridView3.DataSource = dt;
            label3.Text = clientName.Count.ToString();
        }

        private void LoadLaundry()
        {
            List<string> laundryName = new List<string>();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT ClientName FROM dbo.ClientName cn 
                    JOIN dbo.LaundryLog ll on ll.ClientID = cn.ClientID
                    WHERE cn.ClientID IN (
                    SELECT ClientID FROM dbo.LaundryLog WHERE LaundryDate = @date and ClientTimeOut = '00:00:00'
                    )
                    and LaundryDate = @date and ClientTimeOut = '00:00:00'", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@date", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        laundryName.Add(reader["ClientName"].ToString());
                    }
                    con.Close();
                }

            }

            dt.Columns.Add("Client Name");

            foreach (string name in laundryName)
            {
                dt.Rows.Add(name);
            }

            dataGridView1.DataSource = dt;
        }

        private void LoadShower()
        {
            List<string> showerName = new List<string>();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT ClientName FROM dbo.ClientName cn 
                    JOIN dbo.ShowerLog sl on sl.ClientID = cn.ClientID
                    WHERE cn.ClientID IN (
                    SELECT ClientID FROM dbo.ShowerLog WHERE ShowerDate = @date and ClientTimeOut = '00:00:00'
                    )
                    and ShowerDate = @date and ClientTimeOut = '00:00:00'", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@date", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        showerName.Add(reader["ClientName"].ToString());
                    }
                    con.Close();
                }

            }

            dt.Columns.Add("Client Name");

            foreach (string name in showerName)
            {
                dt.Rows.Add(name);
            }

            dataGridView2.DataSource = dt;
        }

        private void AddAttendence()
        {
            try
            {
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToShortTimeString();
                string falseOut = "00:00:00";
                int success = 0;
                int check = 0;

                using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM dbo.AttendenceLog WHERE ClientID = @client and SwipeDate = @date and ClientTimeOut = @time", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@client", txtAttendence.Text);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", falseOut);
                        check = (int)cmd.ExecuteScalar();
                        con.Close();
                    }

                    if (check > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE dbo.AttendenceLog SET ClientTimeOut = @time WHERE ClientID = @client and SwipeDate = @date and ClientTimeOut = @falseTime", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@time", time);
                            cmd.Parameters.AddWithValue("@client", txtAttendence.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@FalseTime", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.AttendenceLog(ClientID,SwipeDate,TimeIn,ClientTimeOut) VALUES(@client,@date,@in,@out)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@client", txtAttendence.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@in", time);
                            cmd.Parameters.AddWithValue("@out", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                if (success != 0)
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("Upload Failed");
                txtAttendence.Clear();
                LoadAttendence();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Card");
                txtAttendence.Clear();
            }
        }

        private void AddLaundry()
        {
            try
            {
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToShortTimeString();
                string falseOut = "00:00:00";
                int success = 0;
                int check = 0;

                using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM dbo.LaundryLog WHERE ClientID = @client and LaundryDate = @date and ClientTimeOut = @time", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@client", txtLaundrySwipe.Text);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", falseOut);
                        check = (int)cmd.ExecuteScalar();
                        con.Close();
                    }

                    if (check > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE dbo.LaundryLog SET ClientTimeOut = @time WHERE ClientID = @client and LaundryDate = @date and ClientTimeOut = @falseTime", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@time", time);
                            cmd.Parameters.AddWithValue("@client", txtLaundrySwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@FalseTime", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.LaundryLog(ClientID,LaundryDate,TimeIn,ClientTimeOut) VALUES(@client,@date,@in,@out)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@client", txtLaundrySwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@in", time);
                            cmd.Parameters.AddWithValue("@out", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                if (success != 0)
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("Upload Failed");
                txtLaundrySwipe.Clear();
                LoadLaundry();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Card");
                txtLaundrySwipe.Clear();
            }
        }

        private void AddShower()
        {
            try
            {
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToShortTimeString();
                string falseOut = "00:00:00";
                int success = 0;
                int check = 0;

                using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM dbo.ShowerLog WHERE ClientID = @client and ShowerDate = @date and ClientTimeOut = @time", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@client", txtShowerSwipe.Text);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", falseOut);
                        check = (int)cmd.ExecuteScalar();
                        con.Close();
                    }

                    if (check > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE dbo.ShowerLog SET ClientTimeOut = @time WHERE ClientID = @client and ShowerDate = @date and ClientTimeOut = @falseTime", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@time", time);
                            cmd.Parameters.AddWithValue("@client", txtShowerSwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@FalseTime", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.ShowerLog(ClientID,ShowerDate,TimeIn,ClientTimeOut) VALUES(@client,@date,@in,@out)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@client", txtShowerSwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@in", time);
                            cmd.Parameters.AddWithValue("@out", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                if (success != 0)
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("Upload Failed");
                txtShowerSwipe.Clear();
                LoadShower();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Card");
                txtShowerSwipe.Clear();
            }
        }



        private void OasisDashboard_Load(object sender, EventArgs e)
        {
           
            LoadAttendence();
            LoadLaundry();
            LoadShower();
            Timer timer = new Timer
            {
                Interval = 3000
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            laundryLabel.Visible = true;
            txtLaundrySwipe.Focus();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            showerLabel.Visible = true;
            txtShowerSwipe.Focus();            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            attendLabel.Visible = true;
            txtAttendence.Focus();                       
        }       
               
        private void Button6_Click(object sender, EventArgs e)
        {
            attendLabel.Visible = false;
            AddAttendence();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            laundryLabel.Visible = false;
            AddLaundry();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            showerLabel.Visible = false;
            AddShower();
        }

        private void LinkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientInformation client = new ClientInformation();
            client.Show();
        }

        private void TxtAttendence_TextChanged(object sender, EventArgs e)
        {
            if (txtAttendence.TextLength == 4)
            {
                button6.PerformClick();
            }
        }

        private void TxtLaundrySwipe_TextChanged(object sender, EventArgs e)
        {
            if (txtLaundrySwipe.TextLength == 4)
            {
                button7.PerformClick();
            }
        }

        private void TxtShowerSwipe_TextChanged(object sender, EventArgs e)
        {
            if (txtShowerSwipe.TextLength == 4)
            {
                button8.PerformClick();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadAttendence();
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwipeScreen click = new SwipeScreen();
            click.Show();
        }
    }

        
}

