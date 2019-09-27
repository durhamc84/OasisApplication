namespace OasisApplication_v1._0
{
    partial class Services
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chrisTestDatabaseDataSet = new OasisApplication_v1._0.ChrisTestDatabaseDataSet();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMailSetDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLockerNum = new System.Windows.Forms.TextBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clientInformationTableAdapter = new OasisApplication_v1._0.ChrisTestDatabaseDataSetTableAdapters.ClientInformationTableAdapter();
            this.chrisTestDatabaseDataSet1 = new OasisApplication_v1._0.ChrisTestDatabaseDataSet1();
            this.chrisTestDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientNameTableAdapter = new OasisApplication_v1._0.ChrisTestDatabaseDataSet1TableAdapters.ClientNameTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.linkLabel4);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(318, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 100);
            this.panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientInformationBindingSource, "ClientID", true));
            this.comboBox1.DataSource = this.clientNameBindingSource;
            this.comboBox1.DisplayMember = "ClientName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ClientID";
            // 
            // clientInformationBindingSource
            // 
            this.clientInformationBindingSource.DataMember = "ClientInformation";
            this.clientInformationBindingSource.DataSource = this.chrisTestDatabaseDataSet;
            // 
            // chrisTestDatabaseDataSet
            // 
            this.chrisTestDatabaseDataSet.DataSetName = "ChrisTestDatabaseDataSet";
            this.chrisTestDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(276, 44);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(56, 19);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Reports";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(213, 44);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(57, 19);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Services";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(84, 44);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 19);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Needs Assessment";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(3, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Client";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Oasis Day Center";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.txtMailSetDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.checkBox23);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtLockerNum);
            this.panel3.Controls.Add(this.checkBox22);
            this.panel3.Controls.Add(this.checkBox21);
            this.panel3.Controls.Add(this.checkBox20);
            this.panel3.Controls.Add(this.checkBox19);
            this.panel3.Controls.Add(this.checkBox18);
            this.panel3.Controls.Add(this.checkBox17);
            this.panel3.Controls.Add(this.checkBox16);
            this.panel3.Controls.Add(this.checkBox15);
            this.panel3.Controls.Add(this.checkBox14);
            this.panel3.Controls.Add(this.checkBox13);
            this.panel3.Controls.Add(this.checkBox12);
            this.panel3.Controls.Add(this.checkBox11);
            this.panel3.Controls.Add(this.checkBox10);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 511);
            this.panel3.TabIndex = 4;
            // 
            // txtMailSetDate
            // 
            this.txtMailSetDate.Location = new System.Drawing.Point(402, 94);
            this.txtMailSetDate.Mask = "00/00/0000";
            this.txtMailSetDate.Name = "txtMailSetDate";
            this.txtMailSetDate.Size = new System.Drawing.Size(99, 20);
            this.txtMailSetDate.TabIndex = 50;
            this.txtMailSetDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mail Set-up Date";
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.Location = new System.Drawing.Point(5, 150);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(157, 29);
            this.checkBox23.TabIndex = 47;
            this.checkBox23.Text = "Transportation";
            this.checkBox23.UseVisualStyleBackColor = true;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.CheckBox23_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Locker Number";
            // 
            // txtLockerNum
            // 
            this.txtLockerNum.Location = new System.Drawing.Point(425, 29);
            this.txtLockerNum.Name = "txtLockerNum";
            this.txtLockerNum.Size = new System.Drawing.Size(90, 20);
            this.txtLockerNum.TabIndex = 44;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.Location = new System.Drawing.Point(611, 410);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(251, 29);
            this.checkBox22.TabIndex = 43;
            this.checkBox22.Text = "Assessment and Support";
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.CheckBox22_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Location = new System.Drawing.Point(611, 345);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(141, 29);
            this.checkBox21.TabIndex = 42;
            this.checkBox21.Text = "Nourishment";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.CheckBox21_CheckedChanged);
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(611, 280);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(117, 29);
            this.checkBox20.TabIndex = 41;
            this.checkBox20.Text = "Computer";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.CheckBox20_CheckedChanged);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(611, 215);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(114, 29);
            this.checkBox19.TabIndex = 40;
            this.checkBox19.Text = "Seasonal";
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.CheckBox19_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(611, 150);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(110, 29);
            this.checkBox18.TabIndex = 39;
            this.checkBox18.Text = "Toiletries";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.CheckBox18_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(611, 85);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(94, 29);
            this.checkBox17.TabIndex = 38;
            this.checkBox17.Text = "MCMH";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.CheckBox17_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.Location = new System.Drawing.Point(611, 20);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(119, 29);
            this.checkBox16.TabIndex = 37;
            this.checkBox16.Text = "Crossings";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.CheckBox16_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(329, 470);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(108, 29);
            this.checkBox15.TabIndex = 36;
            this.checkBox15.Text = "Activities";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.CheckBox15_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(329, 410);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(113, 29);
            this.checkBox14.TabIndex = 35;
            this.checkBox14.Text = "Recovery";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.CheckBox14_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(329, 345);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(186, 29);
            this.checkBox13.TabIndex = 34;
            this.checkBox13.Text = "Spititual Wellness";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.CheckBox13_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(329, 280);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(173, 29);
            this.checkBox12.TabIndex = 33;
            this.checkBox12.Text = "Health Wellness";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.CheckBox12_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(329, 215);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(103, 29);
            this.checkBox11.TabIndex = 32;
            this.checkBox11.Text = "Housing";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.CheckBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(329, 150);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(103, 29);
            this.checkBox10.TabIndex = 31;
            this.checkBox10.Text = "Clothing";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.CheckBox10_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(329, 85);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(67, 29);
            this.checkBox9.TabIndex = 30;
            this.checkBox9.Text = "Mail";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.CheckBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(329, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(90, 29);
            this.checkBox8.TabIndex = 29;
            this.checkBox8.Text = "Locker";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(5, 410);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(139, 29);
            this.checkBox7.TabIndex = 28;
            this.checkBox7.Text = "Employment";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(5, 470);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(88, 29);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.Text = "Phone";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(5, 345);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(102, 29);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "Hair Cut";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(5, 280);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(63, 29);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "IPS";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(5, 215);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 29);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "ISST";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(5, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(173, 29);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Vital Documents";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(5, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 29);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Identification";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // clientInformationTableAdapter
            // 
            this.clientInformationTableAdapter.ClearBeforeFill = true;
            // 
            // chrisTestDatabaseDataSet1
            // 
            this.chrisTestDatabaseDataSet1.DataSetName = "ChrisTestDatabaseDataSet1";
            this.chrisTestDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chrisTestDatabaseDataSet1BindingSource
            // 
            this.chrisTestDatabaseDataSet1BindingSource.DataSource = this.chrisTestDatabaseDataSet1;
            this.chrisTestDatabaseDataSet1BindingSource.Position = 0;
            // 
            // clientNameBindingSource
            // 
            this.clientNameBindingSource.DataMember = "ClientName";
            this.clientNameBindingSource.DataSource = this.chrisTestDatabaseDataSet1BindingSource;
            // 
            // clientNameTableAdapter
            // 
            this.clientNameTableAdapter.ClearBeforeFill = true;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrisTestDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLockerNum;
        private System.Windows.Forms.ComboBox comboBox1;
        private ChrisTestDatabaseDataSet chrisTestDatabaseDataSet;
        private System.Windows.Forms.BindingSource clientInformationBindingSource;
        private ChrisTestDatabaseDataSetTableAdapters.ClientInformationTableAdapter clientInformationTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.MaskedTextBox txtMailSetDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource chrisTestDatabaseDataSet1BindingSource;
        private ChrisTestDatabaseDataSet1 chrisTestDatabaseDataSet1;
        private System.Windows.Forms.BindingSource clientNameBindingSource;
        private ChrisTestDatabaseDataSet1TableAdapters.ClientNameTableAdapter clientNameTableAdapter;
    }
}