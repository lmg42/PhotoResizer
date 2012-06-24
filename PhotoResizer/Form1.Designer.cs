namespace PhotoResizer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srcFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.srcFolderPath = new System.Windows.Forms.TextBox();
            this.destFolderPath = new System.Windows.Forms.TextBox();
            this.srcSelectFolder = new System.Windows.Forms.Button();
            this.destSelectFolder = new System.Windows.Forms.Button();
            this.longSideLbl = new System.Windows.Forms.Label();
            this.longSize = new System.Windows.Forms.TextBox();
            this.fullSizeUnits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thumbSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alt = new System.Windows.Forms.TextBox();
            this.htmlCodeTxt = new System.Windows.Forms.TextBox();
            this.workingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Folder:";
            // 
            // srcFolderPath
            // 
            this.srcFolderPath.Location = new System.Drawing.Point(114, 8);
            this.srcFolderPath.Name = "srcFolderPath";
            this.srcFolderPath.Size = new System.Drawing.Size(276, 20);
            this.srcFolderPath.TabIndex = 2;
            // 
            // destFolderPath
            // 
            this.destFolderPath.Location = new System.Drawing.Point(113, 36);
            this.destFolderPath.Name = "destFolderPath";
            this.destFolderPath.Size = new System.Drawing.Size(275, 20);
            this.destFolderPath.TabIndex = 3;
            // 
            // srcSelectFolder
            // 
            this.srcSelectFolder.Location = new System.Drawing.Point(394, 8);
            this.srcSelectFolder.Name = "srcSelectFolder";
            this.srcSelectFolder.Size = new System.Drawing.Size(27, 23);
            this.srcSelectFolder.TabIndex = 4;
            this.srcSelectFolder.Text = "...";
            this.srcSelectFolder.UseVisualStyleBackColor = true;
            this.srcSelectFolder.Click += new System.EventHandler(this.srcSelectFolder_Click);
            // 
            // destSelectFolder
            // 
            this.destSelectFolder.Location = new System.Drawing.Point(394, 36);
            this.destSelectFolder.Name = "destSelectFolder";
            this.destSelectFolder.Size = new System.Drawing.Size(27, 23);
            this.destSelectFolder.TabIndex = 5;
            this.destSelectFolder.Text = "...";
            this.destSelectFolder.UseVisualStyleBackColor = true;
            this.destSelectFolder.Click += new System.EventHandler(this.destSelectFolder_Click);
            // 
            // longSideLbl
            // 
            this.longSideLbl.AutoSize = true;
            this.longSideLbl.Location = new System.Drawing.Point(13, 146);
            this.longSideLbl.Name = "longSideLbl";
            this.longSideLbl.Size = new System.Drawing.Size(78, 13);
            this.longSideLbl.TabIndex = 6;
            this.longSideLbl.Text = "Full Size (long):";
            // 
            // longSize
            // 
            this.longSize.Location = new System.Drawing.Point(114, 143);
            this.longSize.Name = "longSize";
            this.longSize.Size = new System.Drawing.Size(100, 20);
            this.longSize.TabIndex = 7;
            this.longSize.Text = "500";
            // 
            // fullSizeUnits
            // 
            this.fullSizeUnits.AutoSize = true;
            this.fullSizeUnits.Location = new System.Drawing.Point(219, 147);
            this.fullSizeUnits.Name = "fullSizeUnits";
            this.fullSizeUnits.Size = new System.Drawing.Size(18, 13);
            this.fullSizeUnits.TabIndex = 8;
            this.fullSizeUnits.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thumb (long):";
            // 
            // thumbSize
            // 
            this.thumbSize.Location = new System.Drawing.Point(114, 165);
            this.thumbSize.Name = "thumbSize";
            this.thumbSize.Size = new System.Drawing.Size(100, 20);
            this.thumbSize.TabIndex = 10;
            this.thumbSize.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "px";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Name:";
            // 
            // userFileName
            // 
            this.userFileName.Location = new System.Drawing.Point(113, 76);
            this.userFileName.Name = "userFileName";
            this.userFileName.Size = new System.Drawing.Size(100, 20);
            this.userFileName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Alt Text:";
            // 
            // alt
            // 
            this.alt.Location = new System.Drawing.Point(113, 102);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(100, 20);
            this.alt.TabIndex = 16;
            // 
            // htmlCodeTxt
            // 
            this.htmlCodeTxt.Location = new System.Drawing.Point(12, 230);
            this.htmlCodeTxt.Multiline = true;
            this.htmlCodeTxt.Name = "htmlCodeTxt";
            this.htmlCodeTxt.ReadOnly = true;
            this.htmlCodeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlCodeTxt.Size = new System.Drawing.Size(409, 92);
            this.htmlCodeTxt.TabIndex = 17;
            this.htmlCodeTxt.Click += new System.EventHandler(this.htmlCodeTxt_Click);
            // 
            // workingLbl
            // 
            this.workingLbl.AutoSize = true;
            this.workingLbl.Location = new System.Drawing.Point(93, 200);
            this.workingLbl.Name = "workingLbl";
            this.workingLbl.Size = new System.Drawing.Size(56, 13);
            this.workingLbl.TabIndex = 18;
            this.workingLbl.Text = "Working...";
            this.workingLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 334);
            this.Controls.Add(this.workingLbl);
            this.Controls.Add(this.htmlCodeTxt);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thumbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullSizeUnits);
            this.Controls.Add(this.longSize);
            this.Controls.Add(this.longSideLbl);
            this.Controls.Add(this.destSelectFolder);
            this.Controls.Add(this.srcSelectFolder);
            this.Controls.Add(this.destFolderPath);
            this.Controls.Add(this.srcFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Photo Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog srcFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderBrowserDialog;
        private System.Windows.Forms.TextBox srcFolderPath;
        private System.Windows.Forms.TextBox destFolderPath;
        private System.Windows.Forms.Button srcSelectFolder;
        private System.Windows.Forms.Button destSelectFolder;
        private System.Windows.Forms.Label longSideLbl;
        private System.Windows.Forms.TextBox longSize;
        private System.Windows.Forms.Label fullSizeUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thumbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alt;
        private System.Windows.Forms.TextBox htmlCodeTxt;
        private System.Windows.Forms.Label workingLbl;
    }
}

