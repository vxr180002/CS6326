/*
    Written by Vishal Chandar Ramachandran for CS6326.001
    For Assignment 2 - Data Entry Program starting February 8, 2019.
    Netid: vxr180002
    Available on Github@:  https://github.com/vxr180002/CS6326-RebateForm

    This program is a Rebate entry form. User purchase information and contact 
    information is entered into system to claim rebate on purchased product.

    Add, update and delete are performed on the same page. 
    Added list of entries are displayed on the right side of the screen. 

    Input fields on the form are:
        First Name
        Middle Initial - optional
        Last Name
        Address Line 1
        Address Line 2 - optional
        City
        State
        Zip code
        Gender
        Phone number
        Email address
        Proof of purchase attached
        Date received

    Features and functionality:
        The program will save new data into a txt file.
        The program displays all entered data on the right side of the application screen.
        Any row can be chosen from the entered row of data and the form will load that data to edit.
        Three functionalities: Save, Delete, Clear buttons are available on the same form.
        Save button is enabled only if all the input information is valid.
        This application can be operated easily without the use of mouse!
    
    Data validations:
        Minor validations like valid phone number, email is done at the runtime before clicking save. 
        Date received is defaulted to today but it can be changed.
        Validations to prevent entering a date in the future is implemented.
        Duplicate records with same combination of first name, last name, phone number is not allowed. 
    
    Detailed comments for methods and snippets of code is provided throughout the module.
*/

using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


// namespace contains the project, its working modules and resources
namespace Asg2_vxr180002
{
   
    // this class contains the forma that we create
    public partial class Form1 : Form
    {
        int sortColumn = -1;
        int count_lines = 1; // number of lines in list
        int backspace_keyc = 0; // to save number of backspace key pressed
        public Form1()
        {
            InitializeComponent();
            
            this.Load += Form1_Load;
        }
        class ListViewItemComparer : IComparer
        {
            private int column;
            private SortOrder sortOrder;

            public ListViewItemComparer()
            {
                column = 0;
                sortOrder = SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, SortOrder order)
            {
                this.column = column;
                this.sortOrder = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal;
                returnVal = String.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
                if (sortOrder == SortOrder.Descending)
                    returnVal *= -1;
                return returnVal;

            }

        }

        // function to invoke form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //To be displayed on form load
            btnSave.Enabled = false;

            lstDisplay.View = View.Details;
            lstDisplay.GridLines = true;
            lstDisplay.FullRowSelect = true;

            lstDisplay.Columns.Add("ID", 0);
            lstDisplay.Columns.Add("Name", 100);
            lstDisplay.Columns.Add("Phone number", 100);

            // Set the Date Received Format
            dtPickerDateReceived.Format = DateTimePickerFormat.Custom;
            dtPickerDateReceived.CustomFormat = "MM/dd/yyyy";
            // Initialize the default date to today
            dtPickerDateReceived.Value = DateTime.Today;
            // Set Max Date to today. dates cannot be in the future
            dtPickerDateReceived.MaxDate = DateTime.Today;

            reset_Form();

        }

        // Validates of all required textboxes are entered
        void validateTextBoxifEmpty()
        {   
            // Regex to identify proper email 
            Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            
            // Check if all the required fields contain proper values and then enable the save button accordingly
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(rtxtAddressLine1.Text) && !string.IsNullOrEmpty(txtCity.Text) && !string.IsNullOrEmpty(txtState.Text) && !string.IsNullOrEmpty(txtZipCode.Text) && !string.IsNullOrEmpty(cbGender.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtEmailAddress.Text) && reg.IsMatch(txtEmailAddress.Text) && (rdBtnYes.Checked || rdBtnNo.Checked))
            {
                btnSave.Enabled = true;
            }
            else
                btnSave.Enabled = false;

        }

       private void txtFirstName_TextChanged(object sender, EventArgs e)
        {   
            // identify the start time from when first text is entered into the first name field
            txt_Start_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void rtxtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            // validate this text box and enable save button
            validateTextBoxifEmpty();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            // validate this field and enable save button
            validateTextBoxifEmpty();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            // validate this field and enable save button
            validateTextBoxifEmpty();
            
            //used to validate entered phone number
            Regex reg = new Regex(@"^(\+[0-9])$"); 

            // check for valid length of phone numbers
            if ((txtPhoneNumber.Text.Length > 6))
            {   // set an error next to text field until a proper phone number is entered
                if (Regex.Match(txtPhoneNumber.Text, @"^(\+?[0-9]*)$").Success)                
                    errPPhoneNo.Clear();                
                else                
                    errPPhoneNo.SetError(txtPhoneNumber, "Phone Number Invalid");               
            }
            else           
                errPPhoneNo.SetError(txtPhoneNumber, "Enter more numbers");           
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            // validate this field and enable save button
            validateTextBoxifEmpty();
        }

        private void rdBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            // validate this field and enable save button
            validateTextBoxifEmpty();
        }

        private void rdBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            // validate this field and enable save button
            validateTextBoxifEmpty();
        }

        // Keypress events for each textboxes 
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void rtxtAddressLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void rtxtAddressLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
            // Zipcode is validated to contain only Digits.
            // Can add additional check to see if it is a valid zipcode
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  this is used to identify the no of backspaces and save them to file
            if (e.KeyChar == (char)Keys.Back)
                backspace_keyc += 1;
        }

        //Handles after save button is clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            string data;
            int validate = 0;
            // Load the final data from the from into this file
            string fileName = "CS6326Asg2.txt";           

            // check if file exists 
            if (System.IO.File.Exists(fileName))
            {   
                // Open file
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                string full_name = txtFirstName.Text +" " + txtMI.Text + " "+ txtLastName.Text;
                string phone_no = txtPhoneNumber.Text;
                // iterate through the rows of data in the file
                while ((data = file.ReadLine()) != null)
                {
                    string[] items = data.Split('\t');
                    string name = items[1] + " " + items[3]+" "+ items[2];
                    string pno = items[10];
                    
                    //Invokes validate_entries
                    // this is used to identify duplicates
                    // checks for 3 fields - {first name, last name, phone number}
                    validate = validate_entries(name, full_name, pno, phone_no);
                    if (validate == 1) break;

                }
                // close file 
                file.Close();
            }

            if (validate ==1 && (toolStripStatusLabel1.Text.Equals("NewData")))
            {   // initially set button as false
                btnSave.Enabled = false;
                
            }
            //To Modify data in file
            else if ((lstDisplay.SelectedItems.Count > 0)) 
            {
                errPName.Clear();
                errPPhoneNo.Clear();
                //  this variable stores info regarding the selected row to modify
                string tagToCompare = lstDisplay.SelectedItems[0].Tag.ToString();
                // store all file info into a variable
                string[] lines = File.ReadAllLines(fileName);
                int totalNumberOfLines = lines.Length;

                // this loop processes each line of the file
                for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; ++indexOfLines)
                {
                    string lineToSplit = lines[indexOfLines];
                    string[] ArrayOfLine = lineToSplit.Split('\t');
                    // check if this row is the desired row to modify
                    if (tagToCompare == ArrayOfLine[0])
                    {
                        count_lines = Convert.ToInt32(tagToCompare);
                        modify_data(Convert.ToInt32(tagToCompare));
                    }
                }
                toolStripStatusLabel1.Text = "NewData";
                statusStrip1.Refresh();
                reset_Form();
                Clear_Form(this);
                dtPickerDateReceived.Value = DateTime.Now;

            }
            //To enter as new data
            else
            {
                errPName.Clear();
                string proof_of_purchase;
                // set proof pf purchase using radio button value
                if (rdBtnYes.Checked)
                    proof_of_purchase = "YES";
                else
                    proof_of_purchase = "NO";
                string Middle_Name = " ";
                if (!string.IsNullOrWhiteSpace(txtMI.Text))               
                    Middle_Name = txtMI.Text;
                string Address_line_2 = "null";
                if (!string.IsNullOrWhiteSpace(rtxtAddressLine2.Text))               
                    Address_line_2 = rtxtAddressLine2.Text;                
                string entered_Date = dtPickerDateReceived.Value.ToShortDateString();
                // identify the end time to store to file
                txt_End_Time.Text = DateTime.Now.ToString("HH:mm:ss tt");
                // join the values using tab delimiter
                string info = String.Join("\t", count_lines, txtFirstName.Text, txtLastName.Text, Middle_Name, rtxtAddressLine1.Text, Address_line_2, txtCity.Text, txtState.Text, txtZipCode.Text,cbGender.Text, txtPhoneNumber.Text, txtEmailAddress.Text, proof_of_purchase, entered_Date, txt_Start_Time.Text, DateTime.Now.ToString("HH:mm:ss"), backspace_keyc);
                // open file for writing
                System.IO.StreamWriter file_write = new System.IO.StreamWriter(fileName, true);
                // write to file
                file_write.WriteLine(info);
                file_write.Close();
                // set date received value to today
                dtPickerDateReceived.Value = DateTime.Today;
                reset_Form();
                Clear_Form(this);
            }
        }

        //Function to check while modifying data 
        private void modify_data(int insertLine)
        {   
            // load the existing file from disk
            string filePath = "CS6326Asg2.txt";
            string[] lines_in_file = File.ReadAllLines(filePath);
            int totalNumberOfLines = lines_in_file.Length;
            string entered_phone_no = txtPhoneNumber.Text;
            string entered_full_name = txtFirstName.Text + " " + txtMI.Text +" "+ txtLastName.Text;
            int loc = 0;
            int validate = 0;
            // this loop iterates through all lines in the file
            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; indexOfLines++)
            {
                string lineToSplit = lines_in_file[indexOfLines];
                string[] line = lineToSplit.Split('\t');
                string name = line[1] + " " + line[3] + " " + line[2];
                string pno = line[10];
                txt_Start_Time.Text = line[14];
                txt_End_Time.Text = line[15];
                backspace_keyc = Convert.ToInt32(line[16]);
                if (insertLine != Convert.ToInt32(line[0]))
                {   // validate a few of the input information
                    validate = validate_entries(name, entered_full_name, pno, entered_phone_no);
                    if (validate == 1) break;
                }
                else if (insertLine == Convert.ToInt32(line[0]))               
                    loc = indexOfLines;
            }
            if (validate == 0)
            {   // if validate is successful enable save button
                lines_in_file[loc] = ReplaceData(insertLine);
                btnSave.Enabled = true;
                errPName.Clear();
                errPPhoneNo.Clear();           
            }
            else
            {   // if validation is failed disable save button
                btnSave.Enabled = false;
                errPName.Clear();
                errPPhoneNo.Clear();
                // display the error message
                MessageBox.Show("Name or Phone No already exists");
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, false);
            // write updated information to file
            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; indexOfLines++)
            {
                string line_Split = lines_in_file[indexOfLines];
                string[] split_Line = line_Split.Split('\t');
                string lineToInsert = String.Join("\t", split_Line[0], split_Line[1], split_Line[2], split_Line[3], split_Line[4], split_Line[5], split_Line[6], split_Line[7], split_Line[8], split_Line[9], split_Line[10], split_Line[11], split_Line[12], split_Line[13], split_Line[14],split_Line[15], backspace_keyc);
                file.WriteLine(lineToInsert);
            }
            file.Close();
        }

        //To replace data in while while modying
        private string ReplaceData(int insertLine)
        {
            string proofOfPurchase;

            if (rdBtnYes.Checked)           
                proofOfPurchase = "YES";           
            else
                proofOfPurchase = "NO";
            string entered_Date = dtPickerDateReceived.Value.ToShortDateString();

            string data = String.Join("\t",count_lines, txtFirstName.Text, txtLastName.Text, txtMI.Text, rtxtAddressLine1.Text, rtxtAddressLine2.Text, txtCity.Text, txtState.Text, txtZipCode.Text,cbGender.Text,txtPhoneNumber.Text, txtEmailAddress.Text, proofOfPurchase, entered_Date, txt_Start_Time.Text, txt_End_Time.Text,backspace_keyc);
            return data;
        }

        //Clears form data
        private void Clear_Form(Control control)
        {
            foreach (Control con in control.Controls)
            {
                if (con is TextBox)
                    ((TextBox)con).Clear();
                else if (con is RichTextBox)
                    ((RichTextBox)con).Clear();
                else
                    Clear_Form(con);
            }
            cbGender.Text = " ";
            rdBtnYes.Checked = false;
            rdBtnNo.Checked = false;
            errPName.Clear();
            errPPhoneNo.Clear();
        }

        //Refreshes the data in list
        private void reset_Form()
        {
            lstDisplay.Items.Clear();
            backspace_keyc = 0;
            rdBtnYes.Checked = false;
            rdBtnNo.Checked = false;

            errPName.Clear();
            errPPhoneNo.Clear();
               
            string path = "CS6326Asg2.txt";
            count_lines = 0;
            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] items = line.Split('\t');
                    string[] items2 = { items[0], items[1] + " " + items[3] + " " + items[2], items[10] };
                    ListViewItem itm = new ListViewItem(items2);
                    itm.Tag = items[0];
                    lstDisplay.Items.Add(itm);
                    count_lines = Convert.ToInt32(items[0]);
                }
                count_lines++;
                file.Close();
            }
        }

        // clears the data in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtPickerDateReceived.Value = DateTime.Today;
            Clear_Form(this);
            errPName.Clear();
            errPPhoneNo.Clear();
            toolStripStatusLabel1.Text = "NewData";
            statusStrip1.Refresh();
        }

        // processes the delete functionality
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string line_to_Compare = lstDisplay.SelectedItems[0].Tag.ToString();
            lstDisplay.Items.RemoveAt(lstDisplay.SelectedIndices[0]);
            string path = "CS6326Asg2.txt";
            string[] lines = File.ReadAllLines(path);
            int numberOfLines = lines.Length;
            for (int index = 0; index < numberOfLines - 1; ++index)
            {
                string line_Split = lines[index];
                string[] line = line_Split.Split('\t');
                int temp = index + 1;
                if (line_to_Compare == line[0])
                {
                    int temp_add = index + 1;
                    int temp_current = index;
                    while (temp_current < numberOfLines - 1)
                    {
                        lines[temp_current] = lines[temp_add];
                        temp_add++;
                        temp_current++;
                    }
                    break;
                }
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(path, false);

            for (int index = 0; index < numberOfLines - 1; ++index)
            {
                string line_Split = lines[index];
                string[] line = line_Split.Split('\t');
                string insert_Line = String.Join("\t", line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10], line[11], line[12],line[13],txt_Start_Time.Text,txt_End_Time.Text,backspace_keyc);
                file.WriteLine(insert_Line);
            }

            file.Close();
            toolStripStatusLabel1.Text = "NewData";
            statusStrip1.Refresh();
            Clear_Form(this);
        }
        
        // Display the list of items saved in file on the right side of application
        private void lstDisplay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string path = "CS6326Asg2.txt";
            if (lstDisplay.SelectedItems.Count > 0)
            {
                toolStripStatusLabel1.Text = "ModifyData";
                statusStrip1.Refresh();
                string selectedValue;
                ListViewItem itm = lstDisplay.SelectedItems[0];
                selectedValue = Regex.Match(itm.SubItems[0].ToString(), @"\d+").Value;
                txtFirstName.Text = selectedValue;
                statusStrip1.Text = "ModifyData";
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] items = line.Split('\t');
                    if (selectedValue == items[0])
                    {
                        txtFirstName.Text = items[1];
                        txtEmailAddress.Text = items[11];
                        txtLastName.Text = items[2];
                        if (items[3] == "null")
                        {
                            txtMI.Clear();
                        }
                        else
                            txtMI.Text = items[3];
                        rtxtAddressLine1.Text = items[4];
                        if (items[5] == "null")
                        {
                            rtxtAddressLine2.Clear();
                        }
                        else
                            rtxtAddressLine2.Text = items[5];
                        txtState.Text = items[6];
                        txtCity.Text = items[7];
                        txtZipCode.Text = items[8];
                        cbGender.Text = items[9];
                        txtPhoneNumber.Text = items[10];
                        if (items[12] == "Yes")
                            rdBtnYes.Checked = true;
                        else
                            rdBtnNo.Checked = true;
                        dtPickerDateReceived.Value = DateTime.Parse(items[13]);                   
                        break;
                    }
                }

                file.Close();
            }
        }

        //To sort data on column click in the displayed list on the right
        private void lstDisplay_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                lstDisplay.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (lstDisplay.Sorting == SortOrder.Ascending)
                    lstDisplay.Sorting = SortOrder.Descending;
                else
                    lstDisplay.Sorting = SortOrder.Ascending;

            }
            lstDisplay.ListViewItemSorter = new ListViewItemComparer(e.Column, lstDisplay.Sorting);
        }

        /* To validate the entries - To check the existing entry
           this function checks and prevents duplicates of combinations 
           of first name,last name, phone number combined.  
    */
        private int validate_entries(string name,string full_Name, string entered_phno, string phone_no)
        {
            int validate = 0;
            errPName.Clear();
            errPPhoneNo.Clear();
            if ((String.Compare(name, full_Name, StringComparison.OrdinalIgnoreCase) == 0) && (String.Compare(entered_phno, phone_no, StringComparison.OrdinalIgnoreCase) == 0))
            {
                errPPhoneNo.SetError(txtPhoneNumber, "Phone Number Already Exsits");
                errPName.SetError(txtFirstName, "Name Already Exsits");
                validate = 1;
                
            }
            else if (String.Compare(entered_phno, phone_no, StringComparison.OrdinalIgnoreCase) == 0)
            {
                errPPhoneNo.SetError(txtPhoneNumber, "Phone Number Already Exsits");
                validate = 1;
            }
            return validate;
        }

        private void dtPickerDateReceived_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
