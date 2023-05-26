namespace User_Registration
{
    partial class Form1
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
            this.FirstName = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.textlastname = new System.Windows.Forms.TextBox();
            this.textcontact = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.Label();
            this.textconfirmpassword = new System.Windows.Forms.TextBox();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(456, 38);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(69, 16);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "Firstname";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(554, 34);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(301, 26);
            this.txtfirstname.TabIndex = 1;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // textlastname
            // 
            this.textlastname.Location = new System.Drawing.Point(554, 89);
            this.textlastname.Margin = new System.Windows.Forms.Padding(4);
            this.textlastname.Name = "textlastname";
            this.textlastname.Size = new System.Drawing.Size(301, 26);
            this.textlastname.TabIndex = 1;
            // 
            // textcontact
            // 
            this.textcontact.Location = new System.Drawing.Point(554, 145);
            this.textcontact.Margin = new System.Windows.Forms.Padding(4);
            this.textcontact.Name = "textcontact";
            this.textcontact.Size = new System.Drawing.Size(301, 26);
            this.textcontact.TabIndex = 1;
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(554, 188);
            this.textaddress.Margin = new System.Windows.Forms.Padding(4);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(301, 68);
            this.textaddress.TabIndex = 1;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(554, 286);
            this.textusername.Margin = new System.Windows.Forms.Padding(4);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(301, 26);
            this.textusername.TabIndex = 1;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(554, 343);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(301, 26);
            this.textpassword.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(456, 89);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(68, 16);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "Lastname";
            this.LastName.Click += new System.EventHandler(this.lable2_Click);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(456, 154);
            this.contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(56, 16);
            this.contact.TabIndex = 0;
            this.contact.Text = "Contact";
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adress";
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Location = new System.Drawing.Point(456, 286);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(71, 16);
            this.txtusername.TabIndex = 0;
            this.txtusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Location = new System.Drawing.Point(456, 347);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(68, 16);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.Text = "Password";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(434, 260);
            this.line.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(602, 16);
            this.line.TabIndex = 0;
            this.line.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnsubmit.Location = new System.Drawing.Point(592, 447);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(156, 36);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.AutoSize = true;
            this.txtconfirmpassword.Location = new System.Drawing.Point(408, 404);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(125, 16);
            this.txtconfirmpassword.TabIndex = 0;
            this.txtconfirmpassword.Text = "Confirm Password";
            this.txtconfirmpassword.Click += new System.EventHandler(this.label8_Click);
            // 
            // textconfirmpassword
            // 
            this.textconfirmpassword.Location = new System.Drawing.Point(554, 400);
            this.textconfirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(301, 26);
            this.textconfirmpassword.TabIndex = 1;
            this.textconfirmpassword.TextChanged += new System.EventHandler(this.textconfirmpassword_TextChanged);
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(863, 289);
            this.warning1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(15, 16);
            this.warning1.TabIndex = 0;
            this.warning1.Text = "*";
            this.warning1.Click += new System.EventHandler(this.warning1_Click);
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(863, 347);
            this.warning2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(15, 16);
            this.warning2.TabIndex = 0;
            this.warning2.Text = "*";
            this.warning2.Click += new System.EventHandler(this.warning2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.textconfirmpassword);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textcontact);
            this.Controls.Add(this.textlastname);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "UserRegistration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox textlastname;
        private System.Windows.Forms.TextBox textcontact;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label txtconfirmpassword;
        private System.Windows.Forms.TextBox textconfirmpassword;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning2;
    }
}

