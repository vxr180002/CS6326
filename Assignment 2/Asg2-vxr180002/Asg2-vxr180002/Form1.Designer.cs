namespace Asg2_vxr180002
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
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtAddressLine1 = new System.Windows.Forms.RichTextBox();
            this.rtxtAddressLine2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPickerDateReceived = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.rdBtnYes = new System.Windows.Forms.RadioButton();
            this.rdBtnNo = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errPName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_End_Time = new System.Windows.Forms.TextBox();
            this.txtBackspace = new System.Windows.Forms.TextBox();
            this.txt_Start_Time = new System.Windows.Forms.TextBox();
            this.errPPhoneNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPPhoneNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 70);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(302, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(36, 70);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(36, 107);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 105);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(105, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(294, 105);
            this.txtMI.Margin = new System.Windows.Forms.Padding(2);
            this.txtMI.MaxLength = 1;
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(105, 20);
            this.txtMI.TabIndex = 5;
            this.txtMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Middle Initial";
            // 
            // rtxtAddressLine1
            // 
            this.rtxtAddressLine1.Location = new System.Drawing.Point(98, 145);
            this.rtxtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtAddressLine1.MaxLength = 35;
            this.rtxtAddressLine1.Name = "rtxtAddressLine1";
            this.rtxtAddressLine1.Size = new System.Drawing.Size(302, 41);
            this.rtxtAddressLine1.TabIndex = 9;
            this.rtxtAddressLine1.Text = "";
            this.rtxtAddressLine1.TextChanged += new System.EventHandler(this.rtxtAddressLine1_TextChanged);
            this.rtxtAddressLine1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtAddressLine1_KeyPress);
            // 
            // rtxtAddressLine2
            // 
            this.rtxtAddressLine2.Location = new System.Drawing.Point(98, 208);
            this.rtxtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtAddressLine2.MaxLength = 35;
            this.rtxtAddressLine2.Name = "rtxtAddressLine2";
            this.rtxtAddressLine2.Size = new System.Drawing.Size(302, 41);
            this.rtxtAddressLine2.TabIndex = 10;
            this.rtxtAddressLine2.Text = "";
            this.rtxtAddressLine2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtAddressLine2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address Line 2";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(98, 271);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(105, 20);
            this.txtCity.TabIndex = 13;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(294, 271);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(105, 20);
            this.txtState.TabIndex = 14;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "City";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(98, 314);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipCode.MaxLength = 9;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(105, 20);
            this.txtZipCode.TabIndex = 17;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGender.Location = new System.Drawing.Point(294, 314);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbGender.MaxLength = 1;
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(105, 21);
            this.cbGender.TabIndex = 19;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Zip Code";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(98, 363);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.MaxLength = 21;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(302, 20);
            this.txtPhoneNumber.TabIndex = 21;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Phone Number";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(98, 411);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.MaxLength = 60;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(302, 20);
            this.txtEmailAddress.TabIndex = 23;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.txtEmailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailAddress_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 411);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Proof of Purchase attached";
            // 
            // dtPickerDateReceived
            // 
            this.dtPickerDateReceived.Location = new System.Drawing.Point(98, 488);
            this.dtPickerDateReceived.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerDateReceived.MaxDate = new System.DateTime(2099, 2, 10, 0, 0, 0, 0);
            this.dtPickerDateReceived.Name = "dtPickerDateReceived";
            this.dtPickerDateReceived.Size = new System.Drawing.Size(97, 20);
            this.dtPickerDateReceived.TabIndex = 28;
            this.dtPickerDateReceived.Value = new System.DateTime(2019, 2, 10, 0, 0, 0, 0);
            this.dtPickerDateReceived.ValueChanged += new System.EventHandler(this.dtPickerDateReceived_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 488);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Date Received";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 522);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 28);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 522);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 28);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 522);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 28);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 317);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Gender";
            // 
            // lstDisplay
            // 
            this.lstDisplay.Location = new System.Drawing.Point(463, 70);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(328, 494);
            this.lstDisplay.TabIndex = 35;
            this.lstDisplay.UseCompatibleStateImageBehavior = false;
            this.lstDisplay.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstDisplay_ColumnClick);
            this.lstDisplay.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstDisplay_ItemSelectionChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(360, 28);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(114, 20);
            this.lblHeading.TabIndex = 35;
            this.lblHeading.Text = "Rebate Form";
            // 
            // rdBtnYes
            // 
            this.rdBtnYes.AutoSize = true;
            this.rdBtnYes.Location = new System.Drawing.Point(172, 453);
            this.rdBtnYes.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnYes.Name = "rdBtnYes";
            this.rdBtnYes.Size = new System.Drawing.Size(43, 17);
            this.rdBtnYes.TabIndex = 26;
            this.rdBtnYes.TabStop = true;
            this.rdBtnYes.Text = "Yes";
            this.rdBtnYes.UseVisualStyleBackColor = true;
            this.rdBtnYes.CheckedChanged += new System.EventHandler(this.rdBtnYes_CheckedChanged);
            // 
            // rdBtnNo
            // 
            this.rdBtnNo.AutoSize = true;
            this.rdBtnNo.Location = new System.Drawing.Point(228, 453);
            this.rdBtnNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnNo.Name = "rdBtnNo";
            this.rdBtnNo.Size = new System.Drawing.Size(39, 17);
            this.rdBtnNo.TabIndex = 27;
            this.rdBtnNo.TabStop = true;
            this.rdBtnNo.Text = "No";
            this.rdBtnNo.UseVisualStyleBackColor = true;
            this.rdBtnNo.CheckedChanged += new System.EventHandler(this.rdBtnNo_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "NewData";
            // 
            // errPName
            // 
            this.errPName.ContainerControl = this;
            // 
            // txt_End_Time
            // 
            this.txt_End_Time.Location = new System.Drawing.Point(268, 488);
            this.txt_End_Time.Margin = new System.Windows.Forms.Padding(2);
            this.txt_End_Time.Name = "txt_End_Time";
            this.txt_End_Time.Size = new System.Drawing.Size(36, 20);
            this.txt_End_Time.TabIndex = 30;
            this.txt_End_Time.Visible = false;
            // 
            // txtBackspace
            // 
            this.txtBackspace.Location = new System.Drawing.Point(326, 488);
            this.txtBackspace.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackspace.Name = "txtBackspace";
            this.txtBackspace.Size = new System.Drawing.Size(33, 20);
            this.txtBackspace.TabIndex = 31;
            this.txtBackspace.Visible = false;
            // 
            // txt_Start_Time
            // 
            this.txt_Start_Time.Location = new System.Drawing.Point(214, 488);
            this.txt_Start_Time.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Start_Time.Name = "txt_Start_Time";
            this.txt_Start_Time.Size = new System.Drawing.Size(34, 20);
            this.txt_Start_Time.TabIndex = 29;
            this.txt_Start_Time.Visible = false;
            // 
            // errPPhoneNo
            // 
            this.errPPhoneNo.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 598);
            this.Controls.Add(this.txt_Start_Time);
            this.Controls.Add(this.txtBackspace);
            this.Controls.Add(this.txt_End_Time);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rdBtnNo);
            this.Controls.Add(this.rdBtnYes);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtPickerDateReceived);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtAddressLine2);
            this.Controls.Add(this.rtxtAddressLine1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPPhoneNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtAddressLine1;
        private System.Windows.Forms.RichTextBox rtxtAddressLine2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtPickerDateReceived;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lstDisplay;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RadioButton rdBtnYes;
        private System.Windows.Forms.RadioButton rdBtnNo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errPName;
        private System.Windows.Forms.TextBox txtBackspace;
        private System.Windows.Forms.TextBox txt_End_Time;
        private System.Windows.Forms.TextBox txt_Start_Time;
        private System.Windows.Forms.ErrorProvider errPPhoneNo;
    }
}

