﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace GendeneCatCare
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertPageBreak()
        {
            //txtInvoices.Selection.Text = "\f";
            //System.Drawing.Point ScrollPosition = new Point(0, txtInvoices..InputPosition.Location.Y);
            //txtInvoices.ScrollLocation = ScrollPosition;
            txtInvoices.Focus();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            string visitText = "";
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];

            txtInvoices.Text = "";

            foreach (DataRow drVisit in DM.dtVisit.Rows)
            {
                string visitStatus = drVisit["Status"].ToString();
                if (visitStatus.Equals("Pending") == true)
                {
                    // get the cat record matching the cat ID from the visit record
                    int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
                    cmCat.Position = DM.catView.Find(aCatID);
                    DataRow drCat = DM.dtCat.Rows[cmCat.Position];

                    // get the owner record matching the owner ID from the cat record
                    int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(aCatID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    visitText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    visitText += drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    visitText += drOwner["StreetAddress"] + "\r\n";
                    visitText += drOwner["Suburb"] + "\r\n\r\n\r\n";
                    visitText += "Cat Name: " + drCat["Name"] + " Visit ID: " + drVisit["VisitID"] +
                                " Visit Date: " + drVisit["VisitDate"] + "\r\n\r\n\r\n";

                    // get the veterinarian record matching the veterinarian ID from the visit record
                    int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
                    cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
                    DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

                    visitText += drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"] + "\r\n";
                    visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

                    DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

                    if (drTreatments.Length > 0)
                    {
                        txtInvoices.Text += visitText;
                        foreach (DataRow drVisitTreatment in drTreatments)
                        {
                            string treatmentText = "";
                            int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                            cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                            DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];

                            double treatmentCost;

                            treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                                            Convert.ToDouble(drTreatment["Cost"]);
                            visitTotal += treatmentCost;
                            treatmentText = "\tTreatment Description: " + drTreatment["Description"]
                                        + "\tQuantity: " + drVisitTreatment["Quantity"]
                                        + "\tTreatment Cost: " + Convert.ToString(String.Format("Order Total: {0:C}", treatmentCost))
                                        + "\r\n";
                            txtInvoices.Text += treatmentText;
                        }

                        txtInvoices.Text += "\r\n";
                        txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(String.Format("Order Total: {0:C}",visitTotal));
                        txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    }
                    visitText = "";
                    visitTotal = 0;
                }
            }

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "VisitID";

            invoicesForPrint = DM.DSGlendene.Tables["VISIT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;

            PreviewDlg.Document = prDoc;
            PreviewDlg.ShowDialog();
        }

        private void prDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 20;

            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            DataRow drVisit = invoicesForPrint[amountOfInvoicesPrinted];

            // get the cat record matching the cat ID from the visit record
            int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
            cmCat.Position = DM.catView.Find(aCatID);
            DataRow drCat = DM.dtCat.Rows[cmCat.Position];

            // get the owner record matching the owner ID from the cat record
            int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
            cmOwner.Position = DM.ownerView.Find(aCatID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
                    
                
            g.DrawString("Owner ID: " + drOwner["OwnerID"], headingFont, brush, headingLeftMargin, topMargin);
            linesSoFarHeading++;

            g.DrawString(drOwner["LastName"] + ", " + drOwner["FirstName"], headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drOwner["StreetAddress"].ToString(), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drOwner["Suburb"].ToString(), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Cat Name: " + drCat["Name"] + " Visit ID: " + drVisit["VisitID"] +
                        " Visit Date: " + drVisit["VisitDate"], headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            
            // get the veterinarian record matching the veterinarian ID from the visit record
            int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
            cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
            DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

            g.DrawString(drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"], headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
                
            visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

            DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

            if (drTreatments.Length > 0)
            {
                        
                foreach (DataRow drVisitTreatment in drTreatments)
                {
                    string treatmentText = "";
                    int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                    cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                    DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];

                    double treatmentCost;

                    treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                                    Convert.ToDouble(drTreatment["Cost"]);
                    visitTotal += treatmentCost;
                    treatmentText = "\tTreatment Description: " + drTreatment["Description"]
                                + "\tQuantity: " + drVisitTreatment["Quantity"]
                                + "\tTreatment Cost: " + Convert.ToString(String.Format("Order Total: {0:C}", treatmentCost));
                    linesSoFarHeading++;
                    g.DrawString(treatmentText, headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                }

                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                g.DrawString("\tGross Due: " + Convert.ToString(String.Format("Order Total: {0:C}", visitTotal)), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            visitTotal = 0;
            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                MessageBox.Show(amountOfInvoicesPrinted.ToString());
                e.HasMorePages = true;
            }
            else
            {
                amountOfInvoicesPrinted = 0;
            }
        }        
    }
}
