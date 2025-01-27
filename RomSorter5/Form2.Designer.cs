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
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //base.Dispose(disposing);
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
            this.btnIdentifyAndZip = new System.Windows.Forms.Button();
            this.chkMoveUnidentified = new System.Windows.Forms.CheckBox();
            this.chkUseIDOffsets = new System.Windows.Forms.CheckBox();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnRenameMultiFile = new System.Windows.Forms.Button();
            this.btnCreateChds = new System.Windows.Forms.Button();
            this.btnExtractChds = new System.Windows.Forms.Button();
            this.btnMakeDat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkZipInsteadOfFolders = new System.Windows.Forms.CheckBox();
            this.btn1G1R = new System.Windows.Forms.Button();
            this.btnEverdrive = new System.Windows.Forms.Button();
            this.btnCreateM3uPlaylists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetectDupes
            // 
            this.btnDetectDupes.Location = new System.Drawing.Point(185, 153);
            this.btnDetectDupes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDetectDupes.Name = "btnDetectDupes";
            this.btnDetectDupes.Size = new System.Drawing.Size(158, 110);
            this.btnDetectDupes.TabIndex = 0;
            this.btnDetectDupes.Text = "Detect Duplicate (Unzipped) Files";
            this.btnDetectDupes.UseVisualStyleBackColor = true;
            this.btnDetectDupes.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDatPath
            // 
            this.txtDatPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatPath.Location = new System.Drawing.Point(278, 13);
            this.txtDatPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatPath.Name = "txtDatPath";
            this.txtDatPath.Size = new System.Drawing.Size(399, 31);
            this.txtDatPath.TabIndex = 15;
            // 
            // btnDatFolderSelect
            // 
            this.btnDatFolderSelect.Location = new System.Drawing.Point(195, 7);
            this.btnDatFolderSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatFolderSelect.Name = "btnDatFolderSelect";
            this.btnDatFolderSelect.Size = new System.Drawing.Size(78, 40);
            this.btnDatFolderSelect.TabIndex = 14;
            this.btnDatFolderSelect.Text = "Select";
            this.btnDatFolderSelect.UseVisualStyleBackColor = true;
            this.btnDatFolderSelect.Click += new System.EventHandler(this.btnDatFolderSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dat File: (Optional)";
            // 
            // txtRomPath
            // 
            this.txtRomPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRomPath.Location = new System.Drawing.Point(278, 57);
            this.txtRomPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRomPath.Name = "txtRomPath";
            this.txtRomPath.Size = new System.Drawing.Size(399, 31);
            this.txtRomPath.TabIndex = 18;
            // 
            // btnRomFolderSelect
            // 
            this.btnRomFolderSelect.Location = new System.Drawing.Point(195, 50);
            this.btnRomFolderSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRomFolderSelect.Name = "btnRomFolderSelect";
            this.btnRomFolderSelect.Size = new System.Drawing.Size(78, 40);
            this.btnRomFolderSelect.TabIndex = 17;
            this.btnRomFolderSelect.Text = "Select";
            this.btnRomFolderSelect.UseVisualStyleBackColor = true;
            this.btnRomFolderSelect.Click += new System.EventHandler(this.btnRomFolderSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
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
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 648);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(668, 52);
            this.progressBar1.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 716);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 25);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Idle";
            // 
            // btnUnzipAll
            // 
            this.btnUnzipAll.Location = new System.Drawing.Point(352, 153);
            this.btnUnzipAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUnzipAll.Name = "btnUnzipAll";
            this.btnUnzipAll.Size = new System.Drawing.Size(158, 110);
            this.btnUnzipAll.TabIndex = 21;
            this.btnUnzipAll.Text = "Unzip All Files";
            this.btnUnzipAll.UseVisualStyleBackColor = true;
            this.btnUnzipAll.Click += new System.EventHandler(this.btnUnzipAll_Click);
            // 
            // btnZipAllFiles
            // 
            this.btnZipAllFiles.Location = new System.Drawing.Point(17, 153);
            this.btnZipAllFiles.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnZipAllFiles.Name = "btnZipAllFiles";
            this.btnZipAllFiles.Size = new System.Drawing.Size(158, 110);
            this.btnZipAllFiles.TabIndex = 22;
            this.btnZipAllFiles.Text = "Zip (or Convert) All Files";
            this.btnZipAllFiles.UseVisualStyleBackColor = true;
            this.btnZipAllFiles.Click += new System.EventHandler(this.btnZipAllFiles_Click);
            // 
            // btnIdentifyAndZip
            // 
            this.btnIdentifyAndZip.Location = new System.Drawing.Point(17, 393);
            this.btnIdentifyAndZip.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIdentifyAndZip.Name = "btnIdentifyAndZip";
            this.btnIdentifyAndZip.Size = new System.Drawing.Size(158, 110);
            this.btnIdentifyAndZip.TabIndex = 23;
            this.btnIdentifyAndZip.Text = "Rename Single-File Games";
            this.btnIdentifyAndZip.UseVisualStyleBackColor = true;
            this.btnIdentifyAndZip.Click += new System.EventHandler(this.btnIdentifyAndZip_Click);
            // 
            // chkMoveUnidentified
            // 
            this.chkMoveUnidentified.AutoSize = true;
            this.chkMoveUnidentified.Location = new System.Drawing.Point(17, 102);
            this.chkMoveUnidentified.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkMoveUnidentified.Name = "chkMoveUnidentified";
            this.chkMoveUnidentified.Size = new System.Drawing.Size(453, 29);
            this.chkMoveUnidentified.TabIndex = 25;
            this.chkMoveUnidentified.Text = "Move unidentified files to sub-folder during Rename";
            this.chkMoveUnidentified.UseVisualStyleBackColor = true;
            // 
            // chkUseIDOffsets
            // 
            this.chkUseIDOffsets.AutoSize = true;
            this.chkUseIDOffsets.Location = new System.Drawing.Point(538, 409);
            this.chkUseIDOffsets.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkUseIDOffsets.Name = "chkUseIDOffsets";
            this.chkUseIDOffsets.Size = new System.Drawing.Size(240, 29);
            this.chkUseIDOffsets.TabIndex = 26;
            this.chkUseIDOffsets.Text = "TODO Use No-Intro DATs";
            this.chkUseIDOffsets.UseVisualStyleBackColor = true;
            this.chkUseIDOffsets.Visible = false;
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(17, 273);
            this.btnCatalog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(158, 110);
            this.btnCatalog.TabIndex = 27;
            this.btnCatalog.Text = "Catalog Files";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(185, 273);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(158, 110);
            this.btnVerify.TabIndex = 28;
            this.btnVerify.Text = "Verify Catalog";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnRenameMultiFile
            // 
            this.btnRenameMultiFile.Location = new System.Drawing.Point(551, 505);
            this.btnRenameMultiFile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRenameMultiFile.Name = "btnRenameMultiFile";
            this.btnRenameMultiFile.Size = new System.Drawing.Size(158, 110);
            this.btnRenameMultiFile.TabIndex = 29;
            this.btnRenameMultiFile.Text = "Rename Multi-File Games (Incomplete)";
            this.btnRenameMultiFile.UseVisualStyleBackColor = true;
            this.btnRenameMultiFile.Visible = false;
            this.btnRenameMultiFile.Click += new System.EventHandler(this.btnRenameMultiFile_Click);
            // 
            // btnCreateChds
            // 
            this.btnCreateChds.Location = new System.Drawing.Point(17, 513);
            this.btnCreateChds.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateChds.Name = "btnCreateChds";
            this.btnCreateChds.Size = new System.Drawing.Size(158, 110);
            this.btnCreateChds.TabIndex = 30;
            this.btnCreateChds.Text = "Create CHD Files";
            this.btnCreateChds.UseVisualStyleBackColor = true;
            this.btnCreateChds.Click += new System.EventHandler(this.btnCreateChds_Click);
            // 
            // btnExtractChds
            // 
            this.btnExtractChds.Location = new System.Drawing.Point(185, 513);
            this.btnExtractChds.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExtractChds.Name = "btnExtractChds";
            this.btnExtractChds.Size = new System.Drawing.Size(158, 110);
            this.btnExtractChds.TabIndex = 31;
            this.btnExtractChds.Text = "Extract CHD Files";
            this.btnExtractChds.UseVisualStyleBackColor = true;
            this.btnExtractChds.Click += new System.EventHandler(this.btnExtractChds_Click);
            // 
            // btnMakeDat
            // 
            this.btnMakeDat.Location = new System.Drawing.Point(352, 273);
            this.btnMakeDat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMakeDat.Name = "btnMakeDat";
            this.btnMakeDat.Size = new System.Drawing.Size(158, 110);
            this.btnMakeDat.TabIndex = 32;
            this.btnMakeDat.Text = "Make DAT File for Folder";
            this.btnMakeDat.UseVisualStyleBackColor = true;
            this.btnMakeDat.Click += new System.EventHandler(this.btnMakeDat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1712, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nothing over here, sorry.";
            // 
            // chkZipInsteadOfFolders
            // 
            this.chkZipInsteadOfFolders.AutoSize = true;
            this.chkZipInsteadOfFolders.Location = new System.Drawing.Point(538, 450);
            this.chkZipInsteadOfFolders.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkZipInsteadOfFolders.Name = "chkZipInsteadOfFolders";
            this.chkZipInsteadOfFolders.Size = new System.Drawing.Size(306, 29);
            this.chkZipInsteadOfFolders.TabIndex = 34;
            this.chkZipInsteadOfFolders.Text = "TODO Use Zips instead of Folders";
            this.chkZipInsteadOfFolders.UseVisualStyleBackColor = true;
            this.chkZipInsteadOfFolders.Visible = false;
            // 
            // btn1G1R
            // 
            this.btn1G1R.Location = new System.Drawing.Point(185, 393);
            this.btn1G1R.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn1G1R.Name = "btn1G1R";
            this.btn1G1R.Size = new System.Drawing.Size(158, 110);
            this.btn1G1R.TabIndex = 35;
            this.btn1G1R.Text = "Make 1G1R Set";
            this.btn1G1R.UseVisualStyleBackColor = true;
            this.btn1G1R.Click += new System.EventHandler(this.btn1G1R_Click);
            // 
            // btnEverdrive
            // 
            this.btnEverdrive.Location = new System.Drawing.Point(352, 393);
            this.btnEverdrive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEverdrive.Name = "btnEverdrive";
            this.btnEverdrive.Size = new System.Drawing.Size(158, 110);
            this.btnEverdrive.TabIndex = 36;
            this.btnEverdrive.Text = "Everdrive Sort";
            this.btnEverdrive.UseVisualStyleBackColor = true;
            this.btnEverdrive.Click += new System.EventHandler(this.btnEverdrive_Click);
            // 
            // btnCreateM3uPlaylists
            // 
            this.btnCreateM3uPlaylists.Location = new System.Drawing.Point(352, 513);
            this.btnCreateM3uPlaylists.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateM3uPlaylists.Name = "btnCreateM3uPlaylists";
            this.btnCreateM3uPlaylists.Size = new System.Drawing.Size(158, 110);
            this.btnCreateM3uPlaylists.TabIndex = 37;
            this.btnCreateM3uPlaylists.Text = "Create m3u playlists";
            this.btnCreateM3uPlaylists.UseVisualStyleBackColor = true;
            this.btnCreateM3uPlaylists.Click += new System.EventHandler(this.btnCreateM3uPlaylists_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 757);
            this.Controls.Add(this.btnCreateM3uPlaylists);
            this.Controls.Add(this.btnEverdrive);
            this.Controls.Add(this.btn1G1R);
            this.Controls.Add(this.chkZipInsteadOfFolders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMakeDat);
            this.Controls.Add(this.btnExtractChds);
            this.Controls.Add(this.btnCreateChds);
            this.Controls.Add(this.btnRenameMultiFile);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.chkUseIDOffsets);
            this.Controls.Add(this.chkMoveUnidentified);
            this.Controls.Add(this.btnIdentifyAndZip);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "ROMSorter (Release 4)";
            this.Shown += new System.EventHandler(this.Form2_Shown);
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
        private System.Windows.Forms.Button btnIdentifyAndZip;
        private System.Windows.Forms.CheckBox chkMoveUnidentified;
        private System.Windows.Forms.CheckBox chkUseIDOffsets;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnRenameMultiFile;
        private System.Windows.Forms.Button btnCreateChds;
        private System.Windows.Forms.Button btnExtractChds;
        private System.Windows.Forms.Button btnMakeDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkZipInsteadOfFolders;
        private System.Windows.Forms.Button btn1G1R;
        private System.Windows.Forms.Button btnEverdrive;
        private System.Windows.Forms.Button btnCreateM3uPlaylists;
    }
}