﻿namespace GendeneCatCare
{
    partial class VeterinarianForm
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
            this.lstVeterinarians = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVeterinarian = new System.Windows.Forms.Button();
            this.btnUpdateVeterinarian = new System.Windows.Forms.Button();
            this.btnDeleteVeterinarian = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblVeterinarianNo = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.pnlVeterinarian = new System.Windows.Forms.Panel();
            this.btnPnlSaveVet = new System.Windows.Forms.Button();
            this.btnPnlCancel = new System.Windows.Forms.Button();
            this.txtPnlRate = new System.Windows.Forms.TextBox();
            this.txtPnlFirstName = new System.Windows.Forms.TextBox();
            this.txtPnlLastName = new System.Windows.Forms.TextBox();
            this.lblPnlRate = new System.Windows.Forms.Label();
            this.lblPnlFirstName = new System.Windows.Forms.Label();
            this.lblPnlLastName = new System.Windows.Forms.Label();
            this.lblPnlVeterinarianID = new System.Windows.Forms.Label();
            this.lblPnlVeterinarianNo = new System.Windows.Forms.Label();
            this.pnlVeterinarian.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVeterinarians
            // 
            this.lstVeterinarians.FormattingEnabled = true;
            this.lstVeterinarians.ItemHeight = 20;
            this.lstVeterinarians.Location = new System.Drawing.Point(59, 70);
            this.lstVeterinarians.Name = "lstVeterinarians";
            this.lstVeterinarians.Size = new System.Drawing.Size(175, 264);
            this.lstVeterinarians.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(59, 367);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 46);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(153, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVeterinarian
            // 
            this.btnAddVeterinarian.Location = new System.Drawing.Point(248, 367);
            this.btnAddVeterinarian.Name = "btnAddVeterinarian";
            this.btnAddVeterinarian.Size = new System.Drawing.Size(180, 46);
            this.btnAddVeterinarian.TabIndex = 3;
            this.btnAddVeterinarian.Text = "Add Veterinarian";
            this.btnAddVeterinarian.UseVisualStyleBackColor = true;
            this.btnAddVeterinarian.Click += new System.EventHandler(this.btnAddVeterinarian_Click);
            // 
            // btnUpdateVeterinarian
            // 
            this.btnUpdateVeterinarian.Location = new System.Drawing.Point(444, 367);
            this.btnUpdateVeterinarian.Name = "btnUpdateVeterinarian";
            this.btnUpdateVeterinarian.Size = new System.Drawing.Size(180, 46);
            this.btnUpdateVeterinarian.TabIndex = 4;
            this.btnUpdateVeterinarian.Text = "Update Veterinarian";
            this.btnUpdateVeterinarian.UseVisualStyleBackColor = true;
            this.btnUpdateVeterinarian.Click += new System.EventHandler(this.btnUpdateVeterinarian_Click);
            // 
            // btnDeleteVeterinarian
            // 
            this.btnDeleteVeterinarian.Location = new System.Drawing.Point(640, 367);
            this.btnDeleteVeterinarian.Name = "btnDeleteVeterinarian";
            this.btnDeleteVeterinarian.Size = new System.Drawing.Size(180, 46);
            this.btnDeleteVeterinarian.TabIndex = 5;
            this.btnDeleteVeterinarian.Text = "Delete Veterinarian";
            this.btnDeleteVeterinarian.UseVisualStyleBackColor = true;
            this.btnDeleteVeterinarian.Click += new System.EventHandler(this.btnDeleteVeterinarian_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(640, 465);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 46);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblVeterinarianNo
            // 
            this.lblVeterinarianNo.AutoSize = true;
            this.lblVeterinarianNo.Location = new System.Drawing.Point(276, 70);
            this.lblVeterinarianNo.Name = "lblVeterinarianNo";
            this.lblVeterinarianNo.Size = new System.Drawing.Size(120, 20);
            this.lblVeterinarianNo.TabIndex = 7;
            this.lblVeterinarianNo.Text = "Veterinarian ID:";
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(402, 70);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(33, 20);
            this.lblVeterinarianID.TabIndex = 8;
            this.lblVeterinarianID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(306, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(306, 173);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(348, 220);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 20);
            this.lblRate.TabIndex = 11;
            this.lblRate.Text = "Rate:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(406, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(406, 170);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(406, 217);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(70, 26);
            this.txtRate.TabIndex = 14;
            // 
            // pnlVeterinarian
            // 
            this.pnlVeterinarian.Controls.Add(this.btnPnlSaveVet);
            this.pnlVeterinarian.Controls.Add(this.btnPnlCancel);
            this.pnlVeterinarian.Controls.Add(this.txtPnlRate);
            this.pnlVeterinarian.Controls.Add(this.txtPnlFirstName);
            this.pnlVeterinarian.Controls.Add(this.txtPnlLastName);
            this.pnlVeterinarian.Controls.Add(this.lblPnlRate);
            this.pnlVeterinarian.Controls.Add(this.lblPnlFirstName);
            this.pnlVeterinarian.Controls.Add(this.lblPnlLastName);
            this.pnlVeterinarian.Controls.Add(this.lblPnlVeterinarianID);
            this.pnlVeterinarian.Controls.Add(this.lblPnlVeterinarianNo);
            this.pnlVeterinarian.Location = new System.Drawing.Point(187, 61);
            this.pnlVeterinarian.Name = "pnlVeterinarian";
            this.pnlVeterinarian.Size = new System.Drawing.Size(447, 257);
            this.pnlVeterinarian.TabIndex = 15;
            this.pnlVeterinarian.Visible = false;
            // 
            // btnPnlSaveVet
            // 
            this.btnPnlSaveVet.Location = new System.Drawing.Point(234, 211);
            this.btnPnlSaveVet.Name = "btnPnlSaveVet";
            this.btnPnlSaveVet.Size = new System.Drawing.Size(152, 33);
            this.btnPnlSaveVet.TabIndex = 9;
            this.btnPnlSaveVet.Text = "Save Veterinarian";
            this.btnPnlSaveVet.UseVisualStyleBackColor = true;
            this.btnPnlSaveVet.Click += new System.EventHandler(this.btnPnlSaveVet_Click);
            // 
            // btnPnlCancel
            // 
            this.btnPnlCancel.Location = new System.Drawing.Point(62, 211);
            this.btnPnlCancel.Name = "btnPnlCancel";
            this.btnPnlCancel.Size = new System.Drawing.Size(152, 33);
            this.btnPnlCancel.TabIndex = 8;
            this.btnPnlCancel.Text = "Cancel";
            this.btnPnlCancel.UseVisualStyleBackColor = true;
            this.btnPnlCancel.Click += new System.EventHandler(this.btnPnlCancel_Click);
            // 
            // txtPnlRate
            // 
            this.txtPnlRate.Location = new System.Drawing.Point(188, 163);
            this.txtPnlRate.Name = "txtPnlRate";
            this.txtPnlRate.Size = new System.Drawing.Size(100, 26);
            this.txtPnlRate.TabIndex = 7;
            // 
            // txtPnlFirstName
            // 
            this.txtPnlFirstName.Location = new System.Drawing.Point(188, 120);
            this.txtPnlFirstName.Name = "txtPnlFirstName";
            this.txtPnlFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtPnlFirstName.TabIndex = 6;
            // 
            // txtPnlLastName
            // 
            this.txtPnlLastName.Location = new System.Drawing.Point(188, 67);
            this.txtPnlLastName.Name = "txtPnlLastName";
            this.txtPnlLastName.Size = new System.Drawing.Size(100, 26);
            this.txtPnlLastName.TabIndex = 5;
            // 
            // lblPnlRate
            // 
            this.lblPnlRate.AutoSize = true;
            this.lblPnlRate.Location = new System.Drawing.Point(134, 174);
            this.lblPnlRate.Name = "lblPnlRate";
            this.lblPnlRate.Size = new System.Drawing.Size(48, 20);
            this.lblPnlRate.TabIndex = 4;
            this.lblPnlRate.Text = "Rate:";
            // 
            // lblPnlFirstName
            // 
            this.lblPnlFirstName.AutoSize = true;
            this.lblPnlFirstName.Location = new System.Drawing.Point(92, 122);
            this.lblPnlFirstName.Name = "lblPnlFirstName";
            this.lblPnlFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblPnlFirstName.TabIndex = 3;
            this.lblPnlFirstName.Text = "First Name:";
            // 
            // lblPnlLastName
            // 
            this.lblPnlLastName.AutoSize = true;
            this.lblPnlLastName.Location = new System.Drawing.Point(92, 70);
            this.lblPnlLastName.Name = "lblPnlLastName";
            this.lblPnlLastName.Size = new System.Drawing.Size(90, 20);
            this.lblPnlLastName.TabIndex = 2;
            this.lblPnlLastName.Text = "Last Name:";
            // 
            // lblPnlVeterinarianID
            // 
            this.lblPnlVeterinarianID.AutoSize = true;
            this.lblPnlVeterinarianID.Location = new System.Drawing.Point(184, 18);
            this.lblPnlVeterinarianID.Name = "lblPnlVeterinarianID";
            this.lblPnlVeterinarianID.Size = new System.Drawing.Size(33, 20);
            this.lblPnlVeterinarianID.TabIndex = 1;
            this.lblPnlVeterinarianID.Text = "null";
            // 
            // lblPnlVeterinarianNo
            // 
            this.lblPnlVeterinarianNo.AutoSize = true;
            this.lblPnlVeterinarianNo.Location = new System.Drawing.Point(62, 18);
            this.lblPnlVeterinarianNo.Name = "lblPnlVeterinarianNo";
            this.lblPnlVeterinarianNo.Size = new System.Drawing.Size(120, 20);
            this.lblPnlVeterinarianNo.TabIndex = 0;
            this.lblPnlVeterinarianNo.Text = "Veterinarian ID:";
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 547);
            this.Controls.Add(this.pnlVeterinarian);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblVeterinarianNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVeterinarian);
            this.Controls.Add(this.btnUpdateVeterinarian);
            this.Controls.Add(this.btnAddVeterinarian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstVeterinarians);
            this.Name = "VeterinarianForm";
            this.Text = "Veterinarian Maintenance";
            this.pnlVeterinarian.ResumeLayout(false);
            this.pnlVeterinarian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeterinarians;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVeterinarian;
        private System.Windows.Forms.Button btnUpdateVeterinarian;
        private System.Windows.Forms.Button btnDeleteVeterinarian;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblVeterinarianNo;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Panel pnlVeterinarian;
        private System.Windows.Forms.Button btnPnlSaveVet;
        private System.Windows.Forms.Button btnPnlCancel;
        private System.Windows.Forms.TextBox txtPnlRate;
        private System.Windows.Forms.TextBox txtPnlFirstName;
        private System.Windows.Forms.TextBox txtPnlLastName;
        private System.Windows.Forms.Label lblPnlRate;
        private System.Windows.Forms.Label lblPnlFirstName;
        private System.Windows.Forms.Label lblPnlLastName;
        private System.Windows.Forms.Label lblPnlVeterinarianID;
        private System.Windows.Forms.Label lblPnlVeterinarianNo;
    }
}