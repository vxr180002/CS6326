namespace Asg3_vxr180002
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
            this.lblEvaluateRebate = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblClickEvaluate = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblMinEntryT = new System.Windows.Forms.Label();
            this.lblMaxEntryT = new System.Windows.Forms.Label();
            this.lblAvgEntryT = new System.Windows.Forms.Label();
            this.lblMinInterRT = new System.Windows.Forms.Label();
            this.lblMaxInterRT = new System.Windows.Forms.Label();
            this.lblAvgInterRT = new System.Windows.Forms.Label();
            this.lblBackspaceCount = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.txtMinInterT = new System.Windows.Forms.TextBox();
            this.txtAvgInterT = new System.Windows.Forms.TextBox();
            this.txtMaxInterT = new System.Windows.Forms.TextBox();
            this.txtAvgEntryT = new System.Windows.Forms.TextBox();
            this.txtMaxEntryT = new System.Windows.Forms.TextBox();
            this.txtMinEntryT = new System.Windows.Forms.TextBox();
            this.txtNoOfRecords = new System.Windows.Forms.TextBox();
            this.txtBackspaceCount = new System.Windows.Forms.TextBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListView();
            this.colHFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHTimeTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvaluateRebate
            // 
            this.lblEvaluateRebate.AutoSize = true;
            this.lblEvaluateRebate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluateRebate.Location = new System.Drawing.Point(219, 20);
            this.lblEvaluateRebate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvaluateRebate.Name = "lblEvaluateRebate";
            this.lblEvaluateRebate.Size = new System.Drawing.Size(214, 20);
            this.lblEvaluateRebate.TabIndex = 0;
            this.lblEvaluateRebate.Text = "Rebate Form - Evaluation";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(22, 78);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(82, 13);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "Enter File Path :";
            this.lblStep1.Click += new System.EventHandler(this.lblStep1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(108, 75);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(398, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(527, 72);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // lblClickEvaluate
            // 
            this.lblClickEvaluate.AutoSize = true;
            this.lblClickEvaluate.Location = new System.Drawing.Point(22, 115);
            this.lblClickEvaluate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClickEvaluate.Name = "lblClickEvaluate";
            this.lblClickEvaluate.Size = new System.Drawing.Size(123, 13);
            this.lblClickEvaluate.TabIndex = 5;
            this.lblClickEvaluate.Text = "Click button to Evaluate:";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(170, 115);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(222, 22);
            this.btnEvaluate.TabIndex = 6;
            this.btnEvaluate.Text = "Evaluate Rebate Form";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(22, 168);
            this.lblNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(103, 13);
            this.lblNr.TabIndex = 7;
            this.lblNr.Text = "Number of records : ";
            this.lblNr.Click += new System.EventHandler(this.lblNr_Click);
            // 
            // lblMinEntryT
            // 
            this.lblMinEntryT.AutoSize = true;
            this.lblMinEntryT.Location = new System.Drawing.Point(22, 192);
            this.lblMinEntryT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinEntryT.Name = "lblMinEntryT";
            this.lblMinEntryT.Size = new System.Drawing.Size(102, 13);
            this.lblMinEntryT.TabIndex = 8;
            this.lblMinEntryT.Text = "Minimum entry time :";
            // 
            // lblMaxEntryT
            // 
            this.lblMaxEntryT.AutoSize = true;
            this.lblMaxEntryT.Location = new System.Drawing.Point(22, 218);
            this.lblMaxEntryT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxEntryT.Name = "lblMaxEntryT";
            this.lblMaxEntryT.Size = new System.Drawing.Size(108, 13);
            this.lblMaxEntryT.TabIndex = 9;
            this.lblMaxEntryT.Text = "Maximum entry time : ";
            // 
            // lblAvgEntryT
            // 
            this.lblAvgEntryT.AutoSize = true;
            this.lblAvgEntryT.Location = new System.Drawing.Point(22, 249);
            this.lblAvgEntryT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgEntryT.Name = "lblAvgEntryT";
            this.lblAvgEntryT.Size = new System.Drawing.Size(101, 13);
            this.lblAvgEntryT.TabIndex = 10;
            this.lblAvgEntryT.Text = "Average entry time :";
            // 
            // lblMinInterRT
            // 
            this.lblMinInterRT.AutoSize = true;
            this.lblMinInterRT.Location = new System.Drawing.Point(22, 279);
            this.lblMinInterRT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinInterRT.Name = "lblMinInterRT";
            this.lblMinInterRT.Size = new System.Drawing.Size(135, 13);
            this.lblMinInterRT.TabIndex = 11;
            this.lblMinInterRT.Text = "Minimum inter-record time : ";
            // 
            // lblMaxInterRT
            // 
            this.lblMaxInterRT.AutoSize = true;
            this.lblMaxInterRT.Location = new System.Drawing.Point(22, 308);
            this.lblMaxInterRT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxInterRT.Name = "lblMaxInterRT";
            this.lblMaxInterRT.Size = new System.Drawing.Size(135, 13);
            this.lblMaxInterRT.TabIndex = 12;
            this.lblMaxInterRT.Text = "Maximum inter-record time :";
            // 
            // lblAvgInterRT
            // 
            this.lblAvgInterRT.AutoSize = true;
            this.lblAvgInterRT.Location = new System.Drawing.Point(22, 335);
            this.lblAvgInterRT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgInterRT.Name = "lblAvgInterRT";
            this.lblAvgInterRT.Size = new System.Drawing.Size(134, 13);
            this.lblAvgInterRT.TabIndex = 13;
            this.lblAvgInterRT.Text = "Average inter-record time : ";
            // 
            // lblBackspaceCount
            // 
            this.lblBackspaceCount.AutoSize = true;
            this.lblBackspaceCount.Location = new System.Drawing.Point(22, 396);
            this.lblBackspaceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackspaceCount.Name = "lblBackspaceCount";
            this.lblBackspaceCount.Size = new System.Drawing.Size(100, 13);
            this.lblBackspaceCount.TabIndex = 14;
            this.lblBackspaceCount.Text = "Backspace count : ";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(22, 366);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(62, 13);
            this.lblTotalTime.TabIndex = 15;
            this.lblTotalTime.Text = "Total time : ";
            // 
            // txtMinInterT
            // 
            this.txtMinInterT.Enabled = false;
            this.txtMinInterT.Location = new System.Drawing.Point(158, 276);
            this.txtMinInterT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinInterT.Name = "txtMinInterT";
            this.txtMinInterT.Size = new System.Drawing.Size(44, 20);
            this.txtMinInterT.TabIndex = 16;
            // 
            // txtAvgInterT
            // 
            this.txtAvgInterT.Enabled = false;
            this.txtAvgInterT.Location = new System.Drawing.Point(158, 335);
            this.txtAvgInterT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvgInterT.Name = "txtAvgInterT";
            this.txtAvgInterT.Size = new System.Drawing.Size(44, 20);
            this.txtAvgInterT.TabIndex = 17;
            // 
            // txtMaxInterT
            // 
            this.txtMaxInterT.Enabled = false;
            this.txtMaxInterT.Location = new System.Drawing.Point(158, 308);
            this.txtMaxInterT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxInterT.Name = "txtMaxInterT";
            this.txtMaxInterT.Size = new System.Drawing.Size(44, 20);
            this.txtMaxInterT.TabIndex = 18;
            // 
            // txtAvgEntryT
            // 
            this.txtAvgEntryT.Enabled = false;
            this.txtAvgEntryT.Location = new System.Drawing.Point(158, 249);
            this.txtAvgEntryT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvgEntryT.Name = "txtAvgEntryT";
            this.txtAvgEntryT.Size = new System.Drawing.Size(44, 20);
            this.txtAvgEntryT.TabIndex = 19;
            // 
            // txtMaxEntryT
            // 
            this.txtMaxEntryT.Enabled = false;
            this.txtMaxEntryT.Location = new System.Drawing.Point(158, 218);
            this.txtMaxEntryT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxEntryT.Name = "txtMaxEntryT";
            this.txtMaxEntryT.Size = new System.Drawing.Size(44, 20);
            this.txtMaxEntryT.TabIndex = 20;
            // 
            // txtMinEntryT
            // 
            this.txtMinEntryT.Enabled = false;
            this.txtMinEntryT.Location = new System.Drawing.Point(158, 192);
            this.txtMinEntryT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinEntryT.Name = "txtMinEntryT";
            this.txtMinEntryT.Size = new System.Drawing.Size(44, 20);
            this.txtMinEntryT.TabIndex = 21;
            // 
            // txtNoOfRecords
            // 
            this.txtNoOfRecords.Enabled = false;
            this.txtNoOfRecords.Location = new System.Drawing.Point(158, 168);
            this.txtNoOfRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoOfRecords.Name = "txtNoOfRecords";
            this.txtNoOfRecords.Size = new System.Drawing.Size(44, 20);
            this.txtNoOfRecords.TabIndex = 22;
            // 
            // txtBackspaceCount
            // 
            this.txtBackspaceCount.Enabled = false;
            this.txtBackspaceCount.Location = new System.Drawing.Point(158, 393);
            this.txtBackspaceCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBackspaceCount.Name = "txtBackspaceCount";
            this.txtBackspaceCount.Size = new System.Drawing.Size(44, 20);
            this.txtBackspaceCount.TabIndex = 23;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Enabled = false;
            this.txtTotalTime.Location = new System.Drawing.Point(158, 364);
            this.txtTotalTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(44, 20);
            this.txtTotalTime.TabIndex = 24;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHFullName,
            this.colHTimeTaken});
            this.lstDisplay.Location = new System.Drawing.Point(310, 168);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(299, 244);
            this.lstDisplay.TabIndex = 25;
            this.lstDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // colHFullName
            // 
            this.colHFullName.Text = "Full Name";
            // 
            // colHTimeTaken
            // 
            this.colHTimeTaken.Text = "Total Time Taken";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(527, 427);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 27);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 480);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.txtBackspaceCount);
            this.Controls.Add(this.txtNoOfRecords);
            this.Controls.Add(this.txtMinEntryT);
            this.Controls.Add(this.txtMaxEntryT);
            this.Controls.Add(this.txtAvgEntryT);
            this.Controls.Add(this.txtMaxInterT);
            this.Controls.Add(this.txtAvgInterT);
            this.Controls.Add(this.txtMinInterT);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblBackspaceCount);
            this.Controls.Add(this.lblAvgInterRT);
            this.Controls.Add(this.lblMaxInterRT);
            this.Controls.Add(this.lblMinInterRT);
            this.Controls.Add(this.lblAvgEntryT);
            this.Controls.Add(this.lblMaxEntryT);
            this.Controls.Add(this.lblMinEntryT);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblClickEvaluate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblEvaluateRebate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvaluateRebate;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblClickEvaluate;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblMinEntryT;
        private System.Windows.Forms.Label lblMaxEntryT;
        private System.Windows.Forms.Label lblAvgEntryT;
        private System.Windows.Forms.Label lblMinInterRT;
        private System.Windows.Forms.Label lblMaxInterRT;
        private System.Windows.Forms.Label lblAvgInterRT;
        private System.Windows.Forms.Label lblBackspaceCount;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TextBox txtMinInterT;
        private System.Windows.Forms.TextBox txtAvgInterT;
        private System.Windows.Forms.TextBox txtMaxInterT;
        private System.Windows.Forms.TextBox txtAvgEntryT;
        private System.Windows.Forms.TextBox txtMaxEntryT;
        private System.Windows.Forms.TextBox txtMinEntryT;
        private System.Windows.Forms.TextBox txtNoOfRecords;
        private System.Windows.Forms.TextBox txtBackspaceCount;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.ListView lstDisplay;
        private System.Windows.Forms.ColumnHeader colHFullName;
        private System.Windows.Forms.ColumnHeader colHTimeTaken;
        private System.Windows.Forms.Button btnClear;
    }
}

