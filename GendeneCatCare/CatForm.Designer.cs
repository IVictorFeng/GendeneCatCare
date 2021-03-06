﻿namespace GendeneCatCare
{
    partial class CatForm
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
            this.lstCats = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCatNo = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.txtNeutered = new System.Windows.Forms.TextBox();
            this.lblOnwerID = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlCat = new System.Windows.Forms.Panel();
            this.lblPnlCatNo = new System.Windows.Forms.Label();
            this.lblPnlCatID = new System.Windows.Forms.Label();
            this.lblPnlCatName = new System.Windows.Forms.Label();
            this.lblPnlBreed = new System.Windows.Forms.Label();
            this.lblPnlGender = new System.Windows.Forms.Label();
            this.lblPnlDOB = new System.Windows.Forms.Label();
            this.lblPnlNeutered = new System.Windows.Forms.Label();
            this.lblPnlOwnerID = new System.Windows.Forms.Label();
            this.txtPnlCatName = new System.Windows.Forms.TextBox();
            this.txtPnlBreed = new System.Windows.Forms.TextBox();
            this.txtPnlGender = new System.Windows.Forms.TextBox();
            this.txtPnlDOB = new System.Windows.Forms.TextBox();
            this.txtPnlNeutered = new System.Windows.Forms.TextBox();
            this.txtPnlOwnerID = new System.Windows.Forms.TextBox();
            this.btnPnlCancel = new System.Windows.Forms.Button();
            this.btnPnlSaveCat = new System.Windows.Forms.Button();
            this.pnlCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.ItemHeight = 20;
            this.lstCats.Location = new System.Drawing.Point(91, 76);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(233, 304);
            this.lstCats.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(91, 423);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 38);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(226, 423);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCatNo
            // 
            this.lblCatNo.AutoSize = true;
            this.lblCatNo.Location = new System.Drawing.Point(402, 76);
            this.lblCatNo.Name = "lblCatNo";
            this.lblCatNo.Size = new System.Drawing.Size(59, 20);
            this.lblCatNo.TabIndex = 3;
            this.lblCatNo.Text = "Cat ID:";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(472, 76);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(33, 20);
            this.lblCatID.TabIndex = 4;
            this.lblCatID.Text = "null";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(377, 120);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(84, 20);
            this.lblCatName.TabIndex = 5;
            this.lblCatName.Text = "Cat Name:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(476, 118);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(155, 26);
            this.txtCatName.TabIndex = 6;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(405, 164);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(56, 20);
            this.lblBreed.TabIndex = 7;
            this.lblBreed.Text = "Breed:";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(476, 158);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 26);
            this.txtBreed.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(394, 208);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(476, 205);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 26);
            this.txtGender.TabIndex = 10;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(355, 252);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(106, 20);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(476, 249);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(155, 26);
            this.txtDateOfBirth.TabIndex = 12;
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(382, 296);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(79, 20);
            this.lblNeutered.TabIndex = 13;
            this.lblNeutered.Text = "Neutered:";
            // 
            // txtNeutered
            // 
            this.txtNeutered.Location = new System.Drawing.Point(476, 296);
            this.txtNeutered.Name = "txtNeutered";
            this.txtNeutered.Size = new System.Drawing.Size(100, 26);
            this.txtNeutered.TabIndex = 14;
            // 
            // lblOnwerID
            // 
            this.lblOnwerID.AutoSize = true;
            this.lblOnwerID.Location = new System.Drawing.Point(381, 340);
            this.lblOnwerID.Name = "lblOnwerID";
            this.lblOnwerID.Size = new System.Drawing.Size(80, 20);
            this.lblOnwerID.TabIndex = 15;
            this.lblOnwerID.Text = "Onwer ID:";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(476, 334);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(100, 26);
            this.txtOwnerID.TabIndex = 16;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(382, 423);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(112, 38);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(519, 423);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(112, 38);
            this.btnUpdateCat.TabIndex = 18;
            this.btnUpdateCat.Text = "Update Cat";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(657, 423);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(112, 38);
            this.btnDeleteCat.TabIndex = 19;
            this.btnDeleteCat.Text = "Delete Cat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(657, 490);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlCat
            // 
            this.pnlCat.Controls.Add(this.btnPnlSaveCat);
            this.pnlCat.Controls.Add(this.btnPnlCancel);
            this.pnlCat.Controls.Add(this.txtPnlOwnerID);
            this.pnlCat.Controls.Add(this.txtPnlNeutered);
            this.pnlCat.Controls.Add(this.txtPnlDOB);
            this.pnlCat.Controls.Add(this.txtPnlGender);
            this.pnlCat.Controls.Add(this.txtPnlBreed);
            this.pnlCat.Controls.Add(this.txtPnlCatName);
            this.pnlCat.Controls.Add(this.lblPnlOwnerID);
            this.pnlCat.Controls.Add(this.lblPnlNeutered);
            this.pnlCat.Controls.Add(this.lblPnlDOB);
            this.pnlCat.Controls.Add(this.lblPnlGender);
            this.pnlCat.Controls.Add(this.lblPnlBreed);
            this.pnlCat.Controls.Add(this.lblPnlCatName);
            this.pnlCat.Controls.Add(this.lblPnlCatID);
            this.pnlCat.Controls.Add(this.lblPnlCatNo);
            this.pnlCat.Location = new System.Drawing.Point(140, 32);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(491, 373);
            this.pnlCat.TabIndex = 21;
            this.pnlCat.Visible = false;
            // 
            // lblPnlCatNo
            // 
            this.lblPnlCatNo.AutoSize = true;
            this.lblPnlCatNo.Location = new System.Drawing.Point(159, 10);
            this.lblPnlCatNo.Name = "lblPnlCatNo";
            this.lblPnlCatNo.Size = new System.Drawing.Size(59, 20);
            this.lblPnlCatNo.TabIndex = 0;
            this.lblPnlCatNo.Text = "Cat ID:";
            // 
            // lblPnlCatID
            // 
            this.lblPnlCatID.AutoSize = true;
            this.lblPnlCatID.Location = new System.Drawing.Point(220, 10);
            this.lblPnlCatID.Name = "lblPnlCatID";
            this.lblPnlCatID.Size = new System.Drawing.Size(33, 20);
            this.lblPnlCatID.TabIndex = 1;
            this.lblPnlCatID.Text = "null";
            // 
            // lblPnlCatName
            // 
            this.lblPnlCatName.AutoSize = true;
            this.lblPnlCatName.Location = new System.Drawing.Point(134, 54);
            this.lblPnlCatName.Name = "lblPnlCatName";
            this.lblPnlCatName.Size = new System.Drawing.Size(84, 20);
            this.lblPnlCatName.TabIndex = 2;
            this.lblPnlCatName.Text = "Cat Name:";
            // 
            // lblPnlBreed
            // 
            this.lblPnlBreed.AutoSize = true;
            this.lblPnlBreed.Location = new System.Drawing.Point(162, 98);
            this.lblPnlBreed.Name = "lblPnlBreed";
            this.lblPnlBreed.Size = new System.Drawing.Size(56, 20);
            this.lblPnlBreed.TabIndex = 3;
            this.lblPnlBreed.Text = "Breed:";
            // 
            // lblPnlGender
            // 
            this.lblPnlGender.AutoSize = true;
            this.lblPnlGender.Location = new System.Drawing.Point(151, 142);
            this.lblPnlGender.Name = "lblPnlGender";
            this.lblPnlGender.Size = new System.Drawing.Size(67, 20);
            this.lblPnlGender.TabIndex = 4;
            this.lblPnlGender.Text = "Gender:";
            // 
            // lblPnlDOB
            // 
            this.lblPnlDOB.AutoSize = true;
            this.lblPnlDOB.Location = new System.Drawing.Point(112, 186);
            this.lblPnlDOB.Name = "lblPnlDOB";
            this.lblPnlDOB.Size = new System.Drawing.Size(106, 20);
            this.lblPnlDOB.TabIndex = 5;
            this.lblPnlDOB.Text = "Date Of Birth:";
            // 
            // lblPnlNeutered
            // 
            this.lblPnlNeutered.AutoSize = true;
            this.lblPnlNeutered.Location = new System.Drawing.Point(139, 230);
            this.lblPnlNeutered.Name = "lblPnlNeutered";
            this.lblPnlNeutered.Size = new System.Drawing.Size(79, 20);
            this.lblPnlNeutered.TabIndex = 6;
            this.lblPnlNeutered.Text = "Neutered:";
            // 
            // lblPnlOwnerID
            // 
            this.lblPnlOwnerID.AutoSize = true;
            this.lblPnlOwnerID.Location = new System.Drawing.Point(138, 274);
            this.lblPnlOwnerID.Name = "lblPnlOwnerID";
            this.lblPnlOwnerID.Size = new System.Drawing.Size(80, 20);
            this.lblPnlOwnerID.TabIndex = 7;
            this.lblPnlOwnerID.Text = "Owner ID:";
            // 
            // txtPnlCatName
            // 
            this.txtPnlCatName.Location = new System.Drawing.Point(224, 51);
            this.txtPnlCatName.Name = "txtPnlCatName";
            this.txtPnlCatName.Size = new System.Drawing.Size(164, 26);
            this.txtPnlCatName.TabIndex = 8;
            // 
            // txtPnlBreed
            // 
            this.txtPnlBreed.Location = new System.Drawing.Point(224, 95);
            this.txtPnlBreed.Name = "txtPnlBreed";
            this.txtPnlBreed.Size = new System.Drawing.Size(100, 26);
            this.txtPnlBreed.TabIndex = 9;
            // 
            // txtPnlGender
            // 
            this.txtPnlGender.Location = new System.Drawing.Point(224, 139);
            this.txtPnlGender.Name = "txtPnlGender";
            this.txtPnlGender.Size = new System.Drawing.Size(100, 26);
            this.txtPnlGender.TabIndex = 10;
            // 
            // txtPnlDOB
            // 
            this.txtPnlDOB.Location = new System.Drawing.Point(224, 183);
            this.txtPnlDOB.Name = "txtPnlDOB";
            this.txtPnlDOB.Size = new System.Drawing.Size(164, 26);
            this.txtPnlDOB.TabIndex = 11;
            // 
            // txtPnlNeutered
            // 
            this.txtPnlNeutered.Location = new System.Drawing.Point(224, 227);
            this.txtPnlNeutered.Name = "txtPnlNeutered";
            this.txtPnlNeutered.Size = new System.Drawing.Size(100, 26);
            this.txtPnlNeutered.TabIndex = 12;
            // 
            // txtPnlOwnerID
            // 
            this.txtPnlOwnerID.Location = new System.Drawing.Point(224, 271);
            this.txtPnlOwnerID.Name = "txtPnlOwnerID";
            this.txtPnlOwnerID.Size = new System.Drawing.Size(100, 26);
            this.txtPnlOwnerID.TabIndex = 13;
            // 
            // btnPnlCancel
            // 
            this.btnPnlCancel.Location = new System.Drawing.Point(116, 318);
            this.btnPnlCancel.Name = "btnPnlCancel";
            this.btnPnlCancel.Size = new System.Drawing.Size(119, 36);
            this.btnPnlCancel.TabIndex = 14;
            this.btnPnlCancel.Text = "Cancel";
            this.btnPnlCancel.UseVisualStyleBackColor = true;
            this.btnPnlCancel.Click += new System.EventHandler(this.btnPnlCancel_Click);
            // 
            // btnPnlSaveCat
            // 
            this.btnPnlSaveCat.Location = new System.Drawing.Point(269, 318);
            this.btnPnlSaveCat.Name = "btnPnlSaveCat";
            this.btnPnlSaveCat.Size = new System.Drawing.Size(119, 36);
            this.btnPnlSaveCat.TabIndex = 15;
            this.btnPnlSaveCat.Text = "Save Cat";
            this.btnPnlSaveCat.UseVisualStyleBackColor = true;
            this.btnPnlSaveCat.Click += new System.EventHandler(this.btnPnlSaveCat_Click);
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 558);
            this.Controls.Add(this.pnlCat);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.lblOnwerID);
            this.Controls.Add(this.txtNeutered);
            this.Controls.Add(this.lblNeutered);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblCatNo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstCats);
            this.Name = "CatForm";
            this.Text = "Cat Maintenance";
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCatNo;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.TextBox txtNeutered;
        private System.Windows.Forms.Label lblOnwerID;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlCat;
        private System.Windows.Forms.Button btnPnlSaveCat;
        private System.Windows.Forms.Button btnPnlCancel;
        private System.Windows.Forms.TextBox txtPnlOwnerID;
        private System.Windows.Forms.TextBox txtPnlNeutered;
        private System.Windows.Forms.TextBox txtPnlDOB;
        private System.Windows.Forms.TextBox txtPnlGender;
        private System.Windows.Forms.TextBox txtPnlBreed;
        private System.Windows.Forms.TextBox txtPnlCatName;
        private System.Windows.Forms.Label lblPnlOwnerID;
        private System.Windows.Forms.Label lblPnlNeutered;
        private System.Windows.Forms.Label lblPnlDOB;
        private System.Windows.Forms.Label lblPnlGender;
        private System.Windows.Forms.Label lblPnlBreed;
        private System.Windows.Forms.Label lblPnlCatName;
        private System.Windows.Forms.Label lblPnlCatID;
        private System.Windows.Forms.Label lblPnlCatNo;
    }
}