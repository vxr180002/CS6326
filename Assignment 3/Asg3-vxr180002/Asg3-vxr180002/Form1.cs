/*
    Written by Vishal Chandar Ramachandran for CS6326.001 Spring 19
    For Assignment 3 - Rebate form evaluation program starting February 24, 2019.
    Netid: vxr180002
    Available on Github@:  https://github.com/vxr180002/CS6326
    
    This program is a analysis/evaluation program. It analyzes the output of Rebate entry form. 
    It takes information from the data file from rebate entry app and analyzes it to give a few metrics. 

    Input:
    Data file output of the rebate entry form.
    
    Output:
    Displays the following information on the screen and also writes it to a file.
    File name: CS6326Asg3.txt

        Number of record
	    Minimum entry time
	    Maximum entry time
	    Average entry time
        Minimum inter-record time
	    Maximum inter-record time
	    Average inter-record time
	    Total time
	    Backspace count

*/

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Asg3_vxr180002
{
    public partial class Form1 : Form
    {
        // variables to hold the calculated values
        double min_entry_time = 0;
        double max_entry_time = 0;
        double min_interRecord_time = 0;
        double max_interRecord_time = 0;

        double avg_entry_time = 0;
        double avg_interRecord_time = 0;
        double total_time_taken = 0;
        double backspace_count = 0;
        int totalRecords;

        double[] time_spent_per_record = new double[10];
        double[] difference_time = new double[9];
        DateTime[] start_time_per_record = new DateTime[10];
        DateTime[] end_time_per_record = new DateTime[10];
        
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Grid lines for list view
            lstDisplay.View = View.Details;
            lstDisplay.GridLines = true;
        }

        // Function for selecting the file via browsing the directories
        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = @"C:\"; //By default to C: folder
            // Allows only text files
            openfileDialog.Title = "SELECT ANY .txt File";           
            openfileDialog.Filter = "TEXT Files|*.txt"; 
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;
            if (openfileDialog.ShowDialog() == DialogResult.OK)            
                txtFileName.Text = openfileDialog.FileName;                      
        }

        // To display the file - with the absolute file path
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtFileName.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        // Click to evaluate the fields
        // Handle evaluation of the data file
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            ResetFields();
            ReadData(txtFileName.Text);
            TimeTaken_Individual_Record();
            TimeTaken_Inter_Record();
            Display_List(txtFileName.Text);
            Display_Details_txtBox();
            Write_To_File();
        }
        
        //Resets form values
        private void ResetFields()
        {
            Array.Clear(time_spent_per_record, 0, time_spent_per_record.Length);
            Array.Clear(difference_time, 0, difference_time.Length);
            Array.Clear(start_time_per_record, 0, start_time_per_record.Length);
            Array.Clear(end_time_per_record, 0, end_time_per_record.Length);

            lstDisplay.Items.Clear();
            
            min_entry_time = 0;
            max_entry_time = 0;
            min_interRecord_time = 0;
            max_interRecord_time = 0;
            avg_entry_time = 0;
            avg_interRecord_time = 0;
            total_time_taken = 0;          
            backspace_count = 0;
            totalRecords = 0;

        }

        // Simple function to compute sum
        double ComputeSum(double[] time)
        {
            double s = 0;
            for (int i = 0; i < time.Length; i++)            
                s = s + time[i];            
            return s;
        }
        // Simple function to compute average
        double ComputeAvg(double[] time)
        {
            double s = ComputeSum(time);
            double result = s / time.Length;
            return result;
        }
        
        // Calculate time taken for individual record
        void TimeTaken_Individual_Record()
        {
            int i = 0;
            while ((i<totalRecords) && (i < start_time_per_record.Length))
            {
                time_spent_per_record[i] = end_time_per_record[i].Subtract(start_time_per_record[i]).TotalSeconds;
                total_time_taken += time_spent_per_record[i];
                i++;
            }
            max_entry_time = time_spent_per_record.Max();
            min_entry_time = time_spent_per_record.Min();
            avg_entry_time = ComputeAvg(time_spent_per_record);
        }

        // Calculate time taken for inter record
        void TimeTaken_Inter_Record()
        {
            int i = 0;

            while ((i<totalRecords) && (i < (start_time_per_record.Length - 1)))
            {
                difference_time[i] = start_time_per_record[i + 1].Subtract(end_time_per_record[i]).TotalSeconds;
                total_time_taken += difference_time[i]; 
                i++;
            }
            max_interRecord_time = difference_time.Max();
            min_interRecord_time = difference_time.Min();
            avg_interRecord_time = ComputeAvg(difference_time);
        }

        // Read the data from file
        private void ReadData(string fileName)
        {
            try
            {
                StreamReader read_file = new StreamReader(fileName, true);
                string data;
                int index = 0;
                while ((data = read_file.ReadLine()) != null)
                {
                    string[] items = data.Split('\t');
                    DateTime start_time = DateTime.ParseExact(items[14], "HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime end_time = DateTime.ParseExact(items[15], "HH:mm:ss", CultureInfo.InvariantCulture);
                    start_time_per_record[index] = start_time;
                    end_time_per_record[index] = end_time;
                    backspace_count += Convert.ToInt32(items[16]);
                    index++;
                }
                read_file.Close();
                totalRecords = index;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Populate the text boxes to display on screen
        private  void Display_Details_txtBox()
        {          
            txtNoOfRecords.Text = Convert.ToString(totalRecords);
            txtBackspaceCount.Text = Convert.ToString(backspace_count);        
            txtMinEntryT.Text = TimeSpan.FromSeconds(min_entry_time).ToString(@"mm\:ss"); 
            txtMaxEntryT.Text = TimeSpan.FromSeconds(max_entry_time).ToString(@"mm\:ss"); 
            txtMinInterT.Text = TimeSpan.FromSeconds(min_interRecord_time).ToString(@"mm\:ss");            
            txtMaxInterT.Text = TimeSpan.FromSeconds(max_interRecord_time).ToString(@"mm\:ss");           
            txtAvgEntryT.Text = TimeSpan.FromSeconds(avg_entry_time).ToString(@"mm\:ss");               
            txtAvgInterT.Text = TimeSpan.FromSeconds(avg_interRecord_time).ToString(@"mm\:ss");             
            txtTotalTime.Text = TimeSpan.FromSeconds(total_time_taken).ToString(@"mm\:ss"); 
        }

        // Populate full name and total time taken in a list view
        private void Display_List(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader fileData = new StreamReader(fileName, true);
                string data;
                int i = 0;

                while ((data = fileData.ReadLine()) != null)
                {
                    try
                    {
                        string[] split_line_item = data.Split('\t');
                        string[] displayList = new string[2];                      
                        displayList[0] = split_line_item[1] + " "+ split_line_item[3] +" " + split_line_item[2];
                        displayList[1] = TimeSpan.FromSeconds(time_spent_per_record[i]).ToString(@"mm\:ss");
                        ListViewItem li = new ListViewItem(displayList);
                        li.Tag = split_line_item[0];
                        lstDisplay.Items.Add(li);
                        i++;
                    }
                    catch (Exception e)
                    {
                        fileData.Close();
                        MessageBox.Show(e.Message);
                        return;
                    }
                }
                fileData.Close();
            }
        }

        // Function to write the analysis results to the file
        private void Write_To_File()
        {         
            StreamWriter writeFile = new System.IO.StreamWriter("CS6326Asg3.txt", false);           
            writeFile.WriteLine("Number of records : " + txtNoOfRecords.Text);
            writeFile.WriteLine("Minimum entry time : " + txtMinEntryT.Text);           
            writeFile.WriteLine("Maximum entry time : " + txtMaxEntryT.Text);           
            writeFile.WriteLine("Average entry time : " + txtAvgEntryT.Text);           
            writeFile.WriteLine("Minimum inter-record time : " + txtMinInterT.Text);          
            writeFile.WriteLine("Maximum inter-record time : " + txtMaxInterT.Text);           
            writeFile.WriteLine("Average inter-record time : " + txtAvgInterT.Text);            
            writeFile.WriteLine("Total time : " + txtTotalTime.Text);
            writeFile.WriteLine("Backspace Count : " + txtBackspaceCount.Text);
            writeFile.Close();
        }

        private void Clear_Form(Control control)
        {
            foreach (Control con in control.Controls)
            {
                if (con is TextBox)
                    ((TextBox)con).Clear();               
                else
                    Clear_Form(con);
            }           
        }

        // Clear the form on button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Form(this);
            ResetFields();
        }

        private void lblNr_Click(object sender, EventArgs e)
        {

        }

        private void lblStep1_Click(object sender, EventArgs e)
        {

        }
    }
}
