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
    public partial class SwipeScreen : Form
    {
        public SwipeScreen()
        {
            InitializeComponent();
        }

        private void SwipeScreen_Load(object sender, EventArgs e)
        {
            txtSwipe.Focus();
            labelReady.Visible = true;            
        }
          

        private void Button1_Click(object sender, EventArgs e)
        {
            int success = AddAttendence();


            if (success != 0)
            {                
                labelFailed.Visible = false;
                labelSuccess.Visible = true;
                txtSwipe.Clear();
                txtSwipe.Focus();
            }
            else
            {
                labelSuccess.Visible = false;
                labelFailed.Visible = true;
                txtSwipe.Clear();
                txtSwipe.Focus();
            }
        }

        private int AddAttendence()
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
                        cmd.Parameters.AddWithValue("@client", txtSwipe.Text);
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
                            cmd.Parameters.AddWithValue("@client", txtSwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@FalseTime", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        return success;
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.AttendenceLog(ClientID,SwipeDate,TimeIn,ClientTimeOut) VALUES(@client,@date,@in,@out)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@client", txtSwipe.Text);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@in", time);
                            cmd.Parameters.AddWithValue("@out", falseOut);
                            success = cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        return success;
                    }
                }                                

            }
            catch (Exception)
            {                
                txtSwipe.Clear();
                txtSwipe.Focus();

                return 0;
            }
        }

        private void TxtSwipe_TextChanged(object sender, EventArgs e)
        {
            if (txtSwipe.TextLength == 4)
            {
                button1.PerformClick();
            }
        }              
    }
}
