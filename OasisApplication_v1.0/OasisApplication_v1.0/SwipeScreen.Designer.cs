namespace OasisApplication_v1._0
{
    partial class SwipeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwipeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFailed = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelReady = new System.Windows.Forms.Label();
            this.txtSwipe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Oasis Day Center";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 131);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.labelFailed);
            this.panel2.Controls.Add(this.labelSuccess);
            this.panel2.Controls.Add(this.labelReady);
            this.panel2.Controls.Add(this.txtSwipe);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 480);
            this.panel2.TabIndex = 10;
            // 
            // labelFailed
            // 
            this.labelFailed.AutoSize = true;
            this.labelFailed.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFailed.ForeColor = System.Drawing.Color.Red;
            this.labelFailed.Location = new System.Drawing.Point(270, 313);
            this.labelFailed.Name = "labelFailed";
            this.labelFailed.Size = new System.Drawing.Size(319, 128);
            this.labelFailed.TabIndex = 5;
            this.labelFailed.Text = "Failed";
            this.labelFailed.Visible = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.ForeColor = System.Drawing.Color.Green;
            this.labelSuccess.Location = new System.Drawing.Point(237, 22);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(395, 128);
            this.labelSuccess.TabIndex = 3;
            this.labelSuccess.Text = "Success";
            this.labelSuccess.Visible = false;
            // 
            // labelReady
            // 
            this.labelReady.AutoSize = true;
            this.labelReady.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReady.ForeColor = System.Drawing.Color.Blue;
            this.labelReady.Location = new System.Drawing.Point(263, 164);
            this.labelReady.Name = "labelReady";
            this.labelReady.Size = new System.Drawing.Size(331, 128);
            this.labelReady.TabIndex = 2;
            this.labelReady.Text = "Ready";
            // 
            // txtSwipe
            // 
            this.txtSwipe.Location = new System.Drawing.Point(3, 457);
            this.txtSwipe.Name = "txtSwipe";
            this.txtSwipe.Size = new System.Drawing.Size(0, 20);
            this.txtSwipe.TabIndex = 1;
            this.txtSwipe.TextChanged += new System.EventHandler(this.TxtSwipe_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SwipeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SwipeScreen";
            this.Text = "Swipe Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSwipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelReady;
        private System.Windows.Forms.Label labelFailed;
        private System.Windows.Forms.Label labelSuccess;
    }
}