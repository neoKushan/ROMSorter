﻿namespace RomSorter5WinForms
{
    partial class Form2
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
            this.btnDetectDupes = new System.Windows.Forms.Button();
            this.txtDatPath = new System.Windows.Forms.TextBox();
            this.btnDatFolderSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRomPath = new System.Windows.Forms.TextBox();
            this.btnRomFolderSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUnzipAll = new System.Windows.Forms.Button();
            this.btnZipAllFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetectDupes
            // 
            this.btnDetectDupes.Location = new System.Drawing.Point(12, 92);
            this.btnDetectDupes.Name = "btnDetectDupes";
            this.btnDetectDupes.Size = new System.Drawing.Size(111, 66);
            this.btnDetectDupes.TabIndex = 0;
            this.btnDetectDupes.Text = "Detect Duplicate Files (incomplete)";
            this.btnDetectDupes.UseVisualStyleBackColor = true;
            this.btnDetectDupes.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDatPath
            // 
            this.txtDatPath.Location = new System.Drawing.Point(195, 8);
            this.txtDatPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDatPath.Name = "txtDatPath";
            this.txtDatPath.Size = new System.Drawing.Size(227, 23);
            this.txtDatPath.TabIndex = 15;
            // 
            // btnDatFolderSelect
            // 
            this.btnDatFolderSelect.Location = new System.Drawing.Point(112, 5);
            this.btnDatFolderSelect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDatFolderSelect.Name = "btnDatFolderSelect";
            this.btnDatFolderSelect.Size = new System.Drawing.Size(55, 24);
            this.btnDatFolderSelect.TabIndex = 14;
            this.btnDatFolderSelect.Text = "Select";
            this.btnDatFolderSelect.UseVisualStyleBackColor = true;
            this.btnDatFolderSelect.Click += new System.EventHandler(this.btnDatFolderSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dat File:";
            // 
            // txtRomPath
            // 
            this.txtRomPath.Location = new System.Drawing.Point(195, 34);
            this.txtRomPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRomPath.Name = "txtRomPath";
            this.txtRomPath.Size = new System.Drawing.Size(227, 23);
            this.txtRomPath.TabIndex = 18;
            // 
            // btnRomFolderSelect
            // 
            this.btnRomFolderSelect.Location = new System.Drawing.Point(112, 31);
            this.btnRomFolderSelect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRomFolderSelect.Name = "btnRomFolderSelect";
            this.btnRomFolderSelect.Size = new System.Drawing.Size(55, 24);
            this.btnRomFolderSelect.TabIndex = 17;
            this.btnRomFolderSelect.Text = "Select";
            this.btnRomFolderSelect.UseVisualStyleBackColor = true;
            this.btnRomFolderSelect.Click += new System.EventHandler(this.btnRomFolderSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Folder:";
            // 
            // ofd1
            // 
            this.ofd1.CheckFileExists = false;
            this.ofd1.FileName = "Folder Selection";
            this.ofd1.ValidateNames = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(7, 404);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 31);
            this.progressBar1.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 450);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 15);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Idle";
            // 
            // btnUnzipAll
            // 
            this.btnUnzipAll.Location = new System.Drawing.Point(129, 92);
            this.btnUnzipAll.Name = "btnUnzipAll";
            this.btnUnzipAll.Size = new System.Drawing.Size(111, 66);
            this.btnUnzipAll.TabIndex = 21;
            this.btnUnzipAll.Text = "Unzip All Files";
            this.btnUnzipAll.UseVisualStyleBackColor = true;
            this.btnUnzipAll.Click += new System.EventHandler(this.btnUnzipAll_Click);
            // 
            // btnZipAllFiles
            // 
            this.btnZipAllFiles.Location = new System.Drawing.Point(246, 92);
            this.btnZipAllFiles.Name = "btnZipAllFiles";
            this.btnZipAllFiles.Size = new System.Drawing.Size(111, 66);
            this.btnZipAllFiles.TabIndex = 22;
            this.btnZipAllFiles.Text = "Zip All Files";
            this.btnZipAllFiles.UseVisualStyleBackColor = true;
            this.btnZipAllFiles.Click += new System.EventHandler(this.btnZipAllFiles_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 474);
            this.Controls.Add(this.btnZipAllFiles);
            this.Controls.Add(this.btnUnzipAll);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtRomPath);
            this.Controls.Add(this.btnRomFolderSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatPath);
            this.Controls.Add(this.btnDatFolderSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetectDupes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetectDupes;
        private System.Windows.Forms.TextBox txtDatPath;
        private System.Windows.Forms.Button btnDatFolderSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRomPath;
        private System.Windows.Forms.Button btnRomFolderSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnUnzipAll;
        private System.Windows.Forms.Button btnZipAllFiles;
    }
}