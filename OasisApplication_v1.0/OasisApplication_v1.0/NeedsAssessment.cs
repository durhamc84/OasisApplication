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
    public partial class NeedsAssessment : Form
    {
        public NeedsAssessment()
        {
            InitializeComponent();
        }        



        private void NeedsAssessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet1.ClientName' table. You can move, or remove it, as needed.
            this.clientNameTableAdapter.Fill(this.chrisTestDatabaseDataSet1.ClientName);
            // TODO: This line of code loads data into the 'chrisTestDatabaseDataSet.ClientInformation' table. You can move, or remove it, as needed.
            this.clientInformationTableAdapter.Fill(this.chrisTestDatabaseDataSet.ClientInformation);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=ECHOSQL\\ECHOSQL;Initial Catalog=ChrisTestDatabase;Integrated Security=True"))
            {
                int clientID = Convert.ToInt32(txtNASIGNclient.SelectedValue);
                DateTime date = DateTime.Today;
                int assessID = 0;
                int subID = 0;
                int medID = 0;
                int houseID = 0;
                int employeeID = 0;
                int legalID = 0;
                int chargeID = 0;
                int courtID = 0;
                int proParID = 0;
                int commServID = 0;

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMain(ClientID, AssessmentDate, StaffID) VALUES(@clientID, @date, @staff) SELECT SCOPE_IDENTITY()",con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@clientID", clientID);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@staff", txtNASIGNstaff.Text);
                    assessID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NASubstanceUse(AssessmentID, HasUsed) VALUES(@assess,@used) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assess", assessID);
                    cmd.Parameters.AddWithValue("@used", txtNASUdependence.Text);
                    subID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

                
                if (txtNASUsub1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NASubstances(SubUseID,Substance,Frequency,CleanTime) VALUES(@subID,@sub,@freq,@clean)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@subID", subID);
                        cmd.Parameters.AddWithValue("@sub", txtNASUsub1.Text);
                        cmd.Parameters.AddWithValue("@freq", txtNASUfreq1.Text);
                        cmd.Parameters.AddWithValue("@clean", txtNASUlastuse1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                if (txtNASUsub2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NASubstances(SubUseID,Substance,Frequency,CleanTime) VALUES(@subID,@sub,@freq,@clean)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@subID", subID);
                        cmd.Parameters.AddWithValue("@sub", txtNASUsub2.Text);
                        cmd.Parameters.AddWithValue("@freq", txtNASUfreq2.Text);
                        cmd.Parameters.AddWithValue("@clean", txtNASUlastuse2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                if (txtNASUsub3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NASubstances(SubUseID,Substance,Frequency,CleanTime) VALUES(@subID,@sub,@freq,@clean)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@subID", subID);
                        cmd.Parameters.AddWithValue("@sub", txtNASUsub3.Text);
                        cmd.Parameters.AddWithValue("@freq", txtNASUfreq3.Text);
                        cmd.Parameters.AddWithValue("@clean", txtNASUlastuse3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                if (txtNASUsub4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NASubstances(SubUseID,Substance,Frequency,CleanTime) VALUES(@subID,@sub,@freq,@clean)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@subID", subID);
                        cmd.Parameters.AddWithValue("@sub", txtNASUsub4.Text);
                        cmd.Parameters.AddWithValue("@freq", txtNASUfreq4.Text);
                        cmd.Parameters.AddWithValue("@clean", txtNASUlastuse4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedical(AssessmentID,HasPhysician,NeedsPhysician,PhysicianName,HasMedicalCondition,HasMentalCondition,MentalHealthProvider,HasMedications,MedicationsPay,HasDentist,DentistName,HasEyeDr,HelpSchedulingAppts)" +
                    "VALUES(@assess,@hasPhys,@needsPhys,@physName,@medCon,@menCon,@menPro,@hasMed,@medPay,@hasDent,@dentName,@hasEye,@sched) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assess", assessID);
                    cmd.Parameters.AddWithValue("@hasPhys", txtNAMEDhavephys.Text);
                    cmd.Parameters.AddWithValue("@needsPhys", txtNAMEDneedphys.Text);
                    cmd.Parameters.AddWithValue("@physName", txtNAMEDphysname.Text);
                    cmd.Parameters.AddWithValue("@medCon", txtNAMEDhavecon.Text);
                    cmd.Parameters.AddWithValue("@menCon", txtNAMEDhavemh.Text);
                    cmd.Parameters.AddWithValue("@menPro", txtNAMEDmhprovider.Text);
                    cmd.Parameters.AddWithValue("@hasMed", txtNAMEDtakemed.Text);
                    cmd.Parameters.AddWithValue("@medPay", txtNACONpay.Text);
                    cmd.Parameters.AddWithValue("@hasDent", txtNAMEDhavedent.Text);
                    cmd.Parameters.AddWithValue("@dentName", txtNAMEDdentname.Text);
                    cmd.Parameters.AddWithValue("@hasEye", txtNAMEDhaveopt.Text);
                    cmd.Parameters.AddWithValue("@sched",txtNAMEDhelpsched.Text);
                    medID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                }

                
                if (txtNACONmedcon1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon5.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon5.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon6.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon6.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon7.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon7.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon8.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon8.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedcon9.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedicalConditions(MedicalID,Condition) VALUES(@medID,@con)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@medID", medID);
                        cmd.Parameters.AddWithValue("@con", txtNACONmedcon9.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                                
                if (txtNACONmhdia1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmhdia2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmhdia3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmhdia4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmhdia5.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia5.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmhdia6.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMentalHealthCondition(MedicalID,Diagnosis) VALUES(@medID,@diagnosis)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@diagnosis", txtNACONmhdia6.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }



                if (txtNACONmedtake1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake5.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake5.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake6.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake6.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake7.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake7.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake8.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake8.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNACONmedtake9.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAMedications(MedicalID,Medication) VALUES(@medID,@meds)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("medID", medID);
                        cmd.Parameters.AddWithValue("@meds", txtNACONmedtake9.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }


                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NADocuments(AssessmentID,IDorDriversLic,SocSecCard,ProofOfIncome,InsuranceCard,BirthCert)" +
                    "VALUES(@assessID,@driver,@ssc,@proof,@insurcard,@birthcert)",con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assessID", assessID);
                    cmd.Parameters.AddWithValue("@driver", txtNADOClicense.Text);
                    cmd.Parameters.AddWithValue("@ssc", txtNADOCssc.Text);
                    cmd.Parameters.AddWithValue("@proof", txtNADOCpoi.Text);
                    cmd.Parameters.AddWithValue("@insurcard", txtNADOCinscard.Text);
                    cmd.Parameters.AddWithValue("@birthcert", txtNADOCbirthcert.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousing(AssessmentID,HousingArrangment,TimeSpentHomeless,HousingStable,HousingOptions,HUDorDHA,HUDorDHAStanding,AquirePower,PastDuePower,HasHousingHistory)" +
                    "VALUES(@assessID,@housearr,@timeLess,@houseStab,@houseOpt,@hud,@hudStand,@power,@powerPast,@househist) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assessID", assessID);
                    cmd.Parameters.AddWithValue("@housearr", txtNAHOUstay.Text);
                    cmd.Parameters.AddWithValue("@timeLess", txtNAHOUlonghome.Text);
                    cmd.Parameters.AddWithValue("@houseStab", txtNAHOUstable.Text);
                    cmd.Parameters.AddWithValue("@houseOpt", txtNAHOUaltopt.Text);
                    cmd.Parameters.AddWithValue("@hud", txtNAHOUeverhud.Text);
                    cmd.Parameters.AddWithValue("@hudStand", txtNAHOUgoodhud.Text);
                    cmd.Parameters.AddWithValue("@power", txtNAHOUgetpower.Text);
                    cmd.Parameters.AddWithValue("@powerPast", txtNAHOUduepower.Text);
                    cmd.Parameters.AddWithValue("@househist", txtNAHOUhist.Text);
                    houseID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }


                if (txtNAHOUHISTaddress1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress1.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity1.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate1.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAHOUHISTaddress2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress2.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity2.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate2.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAHOUHISTaddress3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress3.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity3.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate3.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAHOUHISTaddress4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress4.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity4.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate4.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAHOUHISTaddress5.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress5.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity5.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate5.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip5.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAHOUHISTaddress6.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAHousingHistory(HousingID,StreetAddress,City,State,Zip) VALUES(@houseID,@address,@city,@state,@zip)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@houseID", houseID);
                        cmd.Parameters.AddWithValue("@address", txtNAHOUHISTaddress6.Text);
                        cmd.Parameters.AddWithValue("@city", txtNAHOUHISTcity6.Text);
                        cmd.Parameters.AddWithValue("@state", txtNAHOUHISTstate6.Text);
                        cmd.Parameters.AddWithValue("@zip", txtNAHOUHISTzip6.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAEmployment(AssessmentID,Employed,Employer,Income,WorkInterest,WorkType,NoInterestExplain,HasRepPayee)" +
                    "VALUES(@assessID,@employed,@employer,@income,@workInt,@workType,@noInt,@payee) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assessID", assessID);
                    cmd.Parameters.AddWithValue("@employed", txtNAEMPemployed.Text);
                    cmd.Parameters.AddWithValue("@employer", txtNAEMPemployer.Text);
                    cmd.Parameters.AddWithValue("@income", txtNAEMPincome.Text);
                    cmd.Parameters.AddWithValue("@workInt", txtNAEMPjobinterest.Text);
                    cmd.Parameters.AddWithValue("@workType", txtNAEMPtypework.Text);
                    cmd.Parameters.AddWithValue("@noInt", txtNAEMPnointerest.Text);
                    cmd.Parameters.AddWithValue("@payee", txtNAPAYhavepayee.Text);
                    employeeID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }


                if (txtNAPAYpayeename.TextLength != 0 || txtNAPAYtype1.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NARepPayeeInfo(EmploymentID,RepPayeeName,RepPayeePhone,RepPayeeTypes,RepPayeeAmount,RepPayeeFrequency)" +
                    "VALUES(@empid,@repName,@repNum,@repTypes,@repAmount,@repFreq)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@repName", txtNAPAYpayeename.Text);
                        cmd.Parameters.AddWithValue("@repNum", txtNAPAYpayeenum.Text);
                        cmd.Parameters.AddWithValue("@repTypes", txtNAPAYtype1.Text);
                        cmd.Parameters.AddWithValue("@repAmount", txtNAPAYamount1.Text);
                        cmd.Parameters.AddWithValue("@repFreq", txtNAPAYfreq1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAPAYtype2.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NARepPayeeInfo(EmploymentID,RepPayeeName,RepPayeePhone,RepPayeeTypes,RepPayeeAmount,RepPayeeFrequency)" +
                    "VALUES(@empid,@repName,@repNum,@repTypes,@repAmount,@repFreq)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@repName", txtNAPAYpayeename.Text);
                        cmd.Parameters.AddWithValue("@repNum", txtNAPAYpayeenum.Text);
                        cmd.Parameters.AddWithValue("@repTypes", txtNAPAYtype2.Text);
                        cmd.Parameters.AddWithValue("@repAmount", txtNAPAYamount2.Text);
                        cmd.Parameters.AddWithValue("@repFreq", txtNAPAYfreq2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAPAYtype3.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NARepPayeeInfo(EmploymentID,RepPayeeName,RepPayeePhone,RepPayeeTypes,RepPayeeAmount,RepPayeeFrequency)" +
                    "VALUES(@empid,@repName,@repNum,@repTypes,@repAmount,@repFreq)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@repName", txtNAPAYpayeename.Text);
                        cmd.Parameters.AddWithValue("@repNum", txtNAPAYpayeenum.Text);
                        cmd.Parameters.AddWithValue("@repTypes", txtNAPAYtype3.Text);
                        cmd.Parameters.AddWithValue("@repAmount", txtNAPAYamount3.Text);
                        cmd.Parameters.AddWithValue("@repFreq", txtNAPAYfreq3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAPAYtype4.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NARepPayeeInfo(EmploymentID,RepPayeeName,RepPayeePhone,RepPayeeTypes,RepPayeeAmount,RepPayeeFrequency)" +
                    "VALUES(@empid,@repName,@repNum,@repTypes,@repAmount,@repFreq)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@repName", txtNAPAYpayeename.Text);
                        cmd.Parameters.AddWithValue("@repNum", txtNAPAYpayeenum.Text);
                        cmd.Parameters.AddWithValue("@repTypes", txtNAPAYtype4.Text);
                        cmd.Parameters.AddWithValue("@repAmount", txtNAPAYamount4.Text);
                        cmd.Parameters.AddWithValue("@repFreq", txtNAPAYfreq4.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (txtNAPAYtype5.TextLength != 0)
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NARepPayeeInfo(EmploymentID,RepPayeeName,RepPayeePhone,RepPayeeTypes,RepPayeeAmount,RepPayeeFrequency)" +
                    "VALUES(@empid,@repName,@repNum,@repTypes,@repAmount,@repFreq)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@repName", txtNAPAYpayeename.Text);
                        cmd.Parameters.AddWithValue("@repNum", txtNAPAYpayeenum.Text);
                        cmd.Parameters.AddWithValue("@repTypes", txtNAPAYtype5.Text);
                        cmd.Parameters.AddWithValue("@repAmount", txtNAPAYamount5.Text);
                        cmd.Parameters.AddWithValue("@repFreq", txtNAPAYfreq5.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NADHS(AssessmentID,Medicaid,MedicaidApplication,Medicare,RXPlan,SNAP,SNAPAmount,SNAPApplied,LINK,LINKAmount)" + 
                    "VALUES(@assessID,@medicaid,@medicaidapp,@medicare,@rx,@snap,@snapam,@snapapp,@link,@linkam)", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assessID", assessID);
                    cmd.Parameters.AddWithValue("@medicaid", txtNADHShavemedicaid.Text);
                    cmd.Parameters.AddWithValue("@medicaidapp", txtNADHSapplymedicaid.Text);
                    cmd.Parameters.AddWithValue("@medicare", txtNADHShavemedicare.Text);
                    cmd.Parameters.AddWithValue("@rx", txtNADHShavedrugplan.Text);
                    cmd.Parameters.AddWithValue("@snap", txtNADHShavesnap.Text);
                    cmd.Parameters.AddWithValue("@snapam", txtNADHSsnapamount.Text);
                    cmd.Parameters.AddWithValue("@snapapp", txtNADHSsnapapply.Text);
                    cmd.Parameters.AddWithValue("@link", txtNADHShavelink.Text);
                    cmd.Parameters.AddWithValue("@linkam", txtNADHSlinkamount.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NALegal(AssessmentID,HasLegalCharges,HasCourtDate,HasProbationParole,HasCommService)" +
                    "VALUES(@assessID,@charge,@court,@propar,@comsrv) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@assessID", assessID);
                    cmd.Parameters.AddWithValue("@charge", txtNALEGhavecharge.Text);
                    cmd.Parameters.AddWithValue("@court", txtNALEGhavecourt.Text);
                    cmd.Parameters.AddWithValue("@propar", txtNALEGhavepropar.Text);
                    cmd.Parameters.AddWithValue("@comsrv", txtNALEGhavecomser.Text);
                    legalID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NALegalCharges(LegalID,Charge) VALUES(@legalID,@charge) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@legalID", legalID);
                    cmd.Parameters.AddWithValue("@charge", txtNALEGcharge.Text);
                    chargeID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NACourtDates(ChargesID,CourtDate) VALUES(@chargeID,@court) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@chargeID", chargeID);
                    cmd.Parameters.AddWithValue("@court", txtNALEGcourtdate.Text);
                    courtID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NAProbationParole(ChargesID,County,State,ProParOfficer) VALUES(@chargeID,@county,@State,@officer) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@chargeID", chargeID);
                    cmd.Parameters.AddWithValue("@county", txtNALEGproparcounty.Text);
                    cmd.Parameters.AddWithValue("@State", txtNALEGproparstate.Text);
                    cmd.Parameters.AddWithValue("@officer", txtNALEGproparofficer.Text);
                    proParID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.NACommunityService(ChargesID,TotalHours,HoursServed) VALUES(@chargesID,@totHours,@srvHours) SELECT SCOPE_IDENTITY()", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@chargesID", chargeID);
                    cmd.Parameters.AddWithValue("@totHours", txtNALEGcomsertotalhrs.Text);
                    cmd.Parameters.AddWithValue("@srvHours", txtNALEGcomserhrserv.Text);
                    commServID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand(@"UPDATE dbo.NALegalCharges SET CourtID = @court, ProParID = @proPar, CommServeID = @comSrv Where ChargesID = @charge", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@court", courtID);
                    cmd.Parameters.AddWithValue("@proPar", proParID);
                    cmd.Parameters.AddWithValue("@comSrv", commServID);
                    cmd.Parameters.AddWithValue("@charge", chargeID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Assessment Saved!");
            this.Close();

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NeedsAssessment Click = new NeedsAssessment();
            Click.Show();
        }
    }
}
