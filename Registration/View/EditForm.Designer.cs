namespace Registration.View
{
    partial class EditForm
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
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.lPesel = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(14, 16);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(104, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(104, 42);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(180, 20);
            this.tbSurname.TabIndex = 3;
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(14, 42);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(49, 13);
            this.lSurname.TabIndex = 2;
            this.lSurname.Text = "Surname";
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(104, 68);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(180, 20);
            this.tbPesel.TabIndex = 5;
            this.tbPesel.Validating += new System.ComponentModel.CancelEventHandler(this.tbPesel_Validating);
            // 
            // lPesel
            // 
            this.lPesel.AutoSize = true;
            this.lPesel.Location = new System.Drawing.Point(14, 68);
            this.lPesel.Name = "lPesel";
            this.lPesel.Size = new System.Drawing.Size(33, 13);
            this.lPesel.TabIndex = 4;
            this.lPesel.Text = "Pesel";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(104, 94);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.tbPhoneNumber.TabIndex = 7;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(14, 94);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(75, 13);
            this.lPhoneNumber.TabIndex = 6;
            this.lPhoneNumber.Text = "PhoneNumber";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(104, 120);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 20);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(14, 120);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(26, 13);
            this.lEmail.TabIndex = 8;
            this.lEmail.Text = "Mail";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(104, 146);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(180, 20);
            this.tbAddress.TabIndex = 11;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(14, 146);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 10;
            this.lAddress.Text = "Address";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(209, 183);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 12;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 220);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lPhoneNumber);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.lPesel);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.Text = "New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label lPesel;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Button bSave;
    }
}