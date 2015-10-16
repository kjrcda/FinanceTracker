using System.ComponentModel;
using System.Windows.Forms;

namespace FinanceTracker
{
    partial class ArchiveViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnFinish = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListView();
            this.hdrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblOtherAmt = new System.Windows.Forms.Label();
            this.lblEatOutAmt = new System.Windows.Forms.Label();
            this.lblTransportationAmt = new System.Windows.Forms.Label();
            this.lblGroceryAmt = new System.Windows.Forms.Label();
            this.lblEntertainmentAmt = new System.Windows.Forms.Label();
            this.lblPhoneBillAmt = new System.Windows.Forms.Label();
            this.lblRentAmt = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblEatOut = new System.Windows.Forms.Label();
            this.lblTransportation = new System.Windows.Forms.Label();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.lblEntertainment = new System.Windows.Forms.Label();
            this.lblPhoneBill = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblPOtherAmt = new System.Windows.Forms.Label();
            this.lblPEatingAmt = new System.Windows.Forms.Label();
            this.lblPTransportationAmt = new System.Windows.Forms.Label();
            this.lblPGroceryAmt = new System.Windows.Forms.Label();
            this.lblPEntertainmentAmt = new System.Windows.Forms.Label();
            this.lblPPhoneAmt = new System.Windows.Forms.Label();
            this.lblPRentAmt = new System.Windows.Forms.Label();
            this.lblCOtherAmt = new System.Windows.Forms.Label();
            this.lblCEatingAmt = new System.Windows.Forms.Label();
            this.lblCTransportationAmt = new System.Windows.Forms.Label();
            this.lblCGroceryAmt = new System.Windows.Forms.Label();
            this.lblCEntertainmentAmt = new System.Windows.Forms.Label();
            this.lblCPhoneAmt = new System.Windows.Forms.Label();
            this.lblCRentAmt = new System.Windows.Forms.Label();
            this.lblCTotalAmt = new System.Windows.Forms.Label();
            this.lblPTotalAmt = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(521, 542);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(116, 32);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEscape);
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrID,
            this.hdrCategory,
            this.hdrAmount,
            this.hdrPlace,
            this.hdrDescription});
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.Location = new System.Drawing.Point(12, 78);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(640, 226);
            this.lstItems.TabIndex = 17;
            this.lstItems.TabStop = false;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstItems_ColumnSort);
            this.lstItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEscape);
            // 
            // hdrID
            // 
            this.hdrID.Tag = "";
            this.hdrID.Text = "ID";
            this.hdrID.Width = 30;
            // 
            // hdrCategory
            // 
            this.hdrCategory.Text = "Category";
            this.hdrCategory.Width = 110;
            // 
            // hdrAmount
            // 
            this.hdrAmount.Text = "Amount";
            this.hdrAmount.Width = 80;
            // 
            // hdrPlace
            // 
            this.hdrPlace.Text = "Place";
            this.hdrPlace.Width = 120;
            // 
            // hdrDescription
            // 
            this.hdrDescription.Text = "Description";
            this.hdrDescription.Width = 275;
            // 
            // cboSelector
            // 
            this.cboSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Location = new System.Drawing.Point(266, 22);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(225, 26);
            this.cboSelector.Sorted = true;
            this.cboSelector.TabIndex = 18;
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            this.cboSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEscape);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(162, 25);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(98, 18);
            this.lblEntry.TabIndex = 19;
            this.lblEntry.Text = "Archive Entry:";
            // 
            // lblOtherAmt
            // 
            this.lblOtherAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOtherAmt.AutoSize = true;
            this.lblOtherAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAmt.Location = new System.Drawing.Point(352, 498);
            this.lblOtherAmt.Name = "lblOtherAmt";
            this.lblOtherAmt.Size = new System.Drawing.Size(34, 18);
            this.lblOtherAmt.TabIndex = 33;
            this.lblOtherAmt.Text = "Amt";
            // 
            // lblEatOutAmt
            // 
            this.lblEatOutAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEatOutAmt.AutoSize = true;
            this.lblEatOutAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOutAmt.Location = new System.Drawing.Point(352, 472);
            this.lblEatOutAmt.Name = "lblEatOutAmt";
            this.lblEatOutAmt.Size = new System.Drawing.Size(34, 18);
            this.lblEatOutAmt.TabIndex = 32;
            this.lblEatOutAmt.Text = "Amt";
            // 
            // lblTransportationAmt
            // 
            this.lblTransportationAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTransportationAmt.AutoSize = true;
            this.lblTransportationAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationAmt.Location = new System.Drawing.Point(352, 446);
            this.lblTransportationAmt.Name = "lblTransportationAmt";
            this.lblTransportationAmt.Size = new System.Drawing.Size(34, 18);
            this.lblTransportationAmt.TabIndex = 31;
            this.lblTransportationAmt.Text = "Amt";
            // 
            // lblGroceryAmt
            // 
            this.lblGroceryAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroceryAmt.AutoSize = true;
            this.lblGroceryAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroceryAmt.Location = new System.Drawing.Point(352, 420);
            this.lblGroceryAmt.Name = "lblGroceryAmt";
            this.lblGroceryAmt.Size = new System.Drawing.Size(34, 18);
            this.lblGroceryAmt.TabIndex = 30;
            this.lblGroceryAmt.Text = "Amt";
            // 
            // lblEntertainmentAmt
            // 
            this.lblEntertainmentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEntertainmentAmt.AutoSize = true;
            this.lblEntertainmentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainmentAmt.Location = new System.Drawing.Point(352, 394);
            this.lblEntertainmentAmt.Name = "lblEntertainmentAmt";
            this.lblEntertainmentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblEntertainmentAmt.TabIndex = 29;
            this.lblEntertainmentAmt.Text = "Amt";
            // 
            // lblPhoneBillAmt
            // 
            this.lblPhoneBillAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhoneBillAmt.AutoSize = true;
            this.lblPhoneBillAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBillAmt.Location = new System.Drawing.Point(352, 368);
            this.lblPhoneBillAmt.Name = "lblPhoneBillAmt";
            this.lblPhoneBillAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPhoneBillAmt.TabIndex = 28;
            this.lblPhoneBillAmt.Text = "Amt";
            // 
            // lblRentAmt
            // 
            this.lblRentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRentAmt.AutoSize = true;
            this.lblRentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentAmt.Location = new System.Drawing.Point(352, 342);
            this.lblRentAmt.Name = "lblRentAmt";
            this.lblRentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblRentAmt.TabIndex = 27;
            this.lblRentAmt.Text = "Amt";
            // 
            // lblOther
            // 
            this.lblOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(125, 498);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(49, 18);
            this.lblOther.TabIndex = 26;
            this.lblOther.Text = "Other:";
            // 
            // lblEatOut
            // 
            this.lblEatOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEatOut.AutoSize = true;
            this.lblEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOut.Location = new System.Drawing.Point(93, 472);
            this.lblEatOut.Name = "lblEatOut";
            this.lblEatOut.Size = new System.Drawing.Size(81, 18);
            this.lblEatOut.TabIndex = 25;
            this.lblEatOut.Text = "Eating Out:";
            // 
            // lblTransportation
            // 
            this.lblTransportation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportation.Location = new System.Drawing.Point(66, 446);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(108, 18);
            this.lblTransportation.TabIndex = 24;
            this.lblTransportation.Text = "Transportation:";
            // 
            // lblGrocery
            // 
            this.lblGrocery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.Location = new System.Drawing.Point(108, 420);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(66, 18);
            this.lblGrocery.TabIndex = 23;
            this.lblGrocery.Text = "Grocery:";
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainment.Location = new System.Drawing.Point(71, 394);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(103, 18);
            this.lblEntertainment.TabIndex = 22;
            this.lblEntertainment.Text = "Entertainment:";
            // 
            // lblPhoneBill
            // 
            this.lblPhoneBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhoneBill.AutoSize = true;
            this.lblPhoneBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBill.Location = new System.Drawing.Point(96, 368);
            this.lblPhoneBill.Name = "lblPhoneBill";
            this.lblPhoneBill.Size = new System.Drawing.Size(78, 18);
            this.lblPhoneBill.TabIndex = 21;
            this.lblPhoneBill.Text = "Phone Bill:";
            // 
            // lblRent
            // 
            this.lblRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(131, 342);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(43, 18);
            this.lblRent.TabIndex = 20;
            this.lblRent.Text = "Rent:";
            // 
            // lblPOtherAmt
            // 
            this.lblPOtherAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPOtherAmt.AutoSize = true;
            this.lblPOtherAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOtherAmt.Location = new System.Drawing.Point(180, 498);
            this.lblPOtherAmt.Name = "lblPOtherAmt";
            this.lblPOtherAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPOtherAmt.TabIndex = 40;
            this.lblPOtherAmt.Text = "Amt";
            // 
            // lblPEatingAmt
            // 
            this.lblPEatingAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPEatingAmt.AutoSize = true;
            this.lblPEatingAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEatingAmt.Location = new System.Drawing.Point(180, 472);
            this.lblPEatingAmt.Name = "lblPEatingAmt";
            this.lblPEatingAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPEatingAmt.TabIndex = 39;
            this.lblPEatingAmt.Text = "Amt";
            // 
            // lblPTransportationAmt
            // 
            this.lblPTransportationAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPTransportationAmt.AutoSize = true;
            this.lblPTransportationAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTransportationAmt.Location = new System.Drawing.Point(180, 446);
            this.lblPTransportationAmt.Name = "lblPTransportationAmt";
            this.lblPTransportationAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPTransportationAmt.TabIndex = 38;
            this.lblPTransportationAmt.Text = "Amt";
            // 
            // lblPGroceryAmt
            // 
            this.lblPGroceryAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPGroceryAmt.AutoSize = true;
            this.lblPGroceryAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGroceryAmt.Location = new System.Drawing.Point(180, 420);
            this.lblPGroceryAmt.Name = "lblPGroceryAmt";
            this.lblPGroceryAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPGroceryAmt.TabIndex = 37;
            this.lblPGroceryAmt.Text = "Amt";
            // 
            // lblPEntertainmentAmt
            // 
            this.lblPEntertainmentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPEntertainmentAmt.AutoSize = true;
            this.lblPEntertainmentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEntertainmentAmt.Location = new System.Drawing.Point(180, 394);
            this.lblPEntertainmentAmt.Name = "lblPEntertainmentAmt";
            this.lblPEntertainmentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPEntertainmentAmt.TabIndex = 36;
            this.lblPEntertainmentAmt.Text = "Amt";
            // 
            // lblPPhoneAmt
            // 
            this.lblPPhoneAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPPhoneAmt.AutoSize = true;
            this.lblPPhoneAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPhoneAmt.Location = new System.Drawing.Point(180, 368);
            this.lblPPhoneAmt.Name = "lblPPhoneAmt";
            this.lblPPhoneAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPPhoneAmt.TabIndex = 35;
            this.lblPPhoneAmt.Text = "Amt";
            // 
            // lblPRentAmt
            // 
            this.lblPRentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPRentAmt.AutoSize = true;
            this.lblPRentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRentAmt.Location = new System.Drawing.Point(180, 342);
            this.lblPRentAmt.Name = "lblPRentAmt";
            this.lblPRentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPRentAmt.TabIndex = 34;
            this.lblPRentAmt.Text = "Amt";
            // 
            // lblCOtherAmt
            // 
            this.lblCOtherAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCOtherAmt.AutoSize = true;
            this.lblCOtherAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOtherAmt.Location = new System.Drawing.Point(266, 498);
            this.lblCOtherAmt.Name = "lblCOtherAmt";
            this.lblCOtherAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCOtherAmt.TabIndex = 47;
            this.lblCOtherAmt.Text = "Amt";
            // 
            // lblCEatingAmt
            // 
            this.lblCEatingAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCEatingAmt.AutoSize = true;
            this.lblCEatingAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEatingAmt.Location = new System.Drawing.Point(266, 472);
            this.lblCEatingAmt.Name = "lblCEatingAmt";
            this.lblCEatingAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCEatingAmt.TabIndex = 46;
            this.lblCEatingAmt.Text = "Amt";
            // 
            // lblCTransportationAmt
            // 
            this.lblCTransportationAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCTransportationAmt.AutoSize = true;
            this.lblCTransportationAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTransportationAmt.Location = new System.Drawing.Point(266, 446);
            this.lblCTransportationAmt.Name = "lblCTransportationAmt";
            this.lblCTransportationAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCTransportationAmt.TabIndex = 45;
            this.lblCTransportationAmt.Text = "Amt";
            // 
            // lblCGroceryAmt
            // 
            this.lblCGroceryAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCGroceryAmt.AutoSize = true;
            this.lblCGroceryAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGroceryAmt.Location = new System.Drawing.Point(266, 420);
            this.lblCGroceryAmt.Name = "lblCGroceryAmt";
            this.lblCGroceryAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCGroceryAmt.TabIndex = 44;
            this.lblCGroceryAmt.Text = "Amt";
            // 
            // lblCEntertainmentAmt
            // 
            this.lblCEntertainmentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCEntertainmentAmt.AutoSize = true;
            this.lblCEntertainmentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEntertainmentAmt.Location = new System.Drawing.Point(266, 394);
            this.lblCEntertainmentAmt.Name = "lblCEntertainmentAmt";
            this.lblCEntertainmentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCEntertainmentAmt.TabIndex = 43;
            this.lblCEntertainmentAmt.Text = "Amt";
            // 
            // lblCPhoneAmt
            // 
            this.lblCPhoneAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPhoneAmt.AutoSize = true;
            this.lblCPhoneAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhoneAmt.Location = new System.Drawing.Point(266, 368);
            this.lblCPhoneAmt.Name = "lblCPhoneAmt";
            this.lblCPhoneAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCPhoneAmt.TabIndex = 42;
            this.lblCPhoneAmt.Text = "Amt";
            // 
            // lblCRentAmt
            // 
            this.lblCRentAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCRentAmt.AutoSize = true;
            this.lblCRentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRentAmt.Location = new System.Drawing.Point(266, 342);
            this.lblCRentAmt.Name = "lblCRentAmt";
            this.lblCRentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCRentAmt.TabIndex = 41;
            this.lblCRentAmt.Text = "Amt";
            // 
            // lblCTotalAmt
            // 
            this.lblCTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCTotalAmt.AutoSize = true;
            this.lblCTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTotalAmt.Location = new System.Drawing.Point(266, 533);
            this.lblCTotalAmt.Name = "lblCTotalAmt";
            this.lblCTotalAmt.Size = new System.Drawing.Size(34, 18);
            this.lblCTotalAmt.TabIndex = 51;
            this.lblCTotalAmt.Text = "Amt";
            // 
            // lblPTotalAmt
            // 
            this.lblPTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPTotalAmt.AutoSize = true;
            this.lblPTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotalAmt.Location = new System.Drawing.Point(180, 533);
            this.lblPTotalAmt.Name = "lblPTotalAmt";
            this.lblPTotalAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPTotalAmt.TabIndex = 50;
            this.lblPTotalAmt.Text = "Amt";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.Location = new System.Drawing.Point(352, 533);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(34, 18);
            this.lblTotalAmt.TabIndex = 49;
            this.lblTotalAmt.Text = "Amt";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(125, 533);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 18);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(332, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 18);
            this.label12.TabIndex = 64;
            this.label12.Text = "=";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(332, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 62;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(332, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(332, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 18);
            this.label16.TabIndex = 60;
            this.label16.Text = "=";
            // 
            // ArchiveViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCTotalAmt);
            this.Controls.Add(this.lblPTotalAmt);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCOtherAmt);
            this.Controls.Add(this.lblCEatingAmt);
            this.Controls.Add(this.lblCTransportationAmt);
            this.Controls.Add(this.lblCGroceryAmt);
            this.Controls.Add(this.lblCEntertainmentAmt);
            this.Controls.Add(this.lblCPhoneAmt);
            this.Controls.Add(this.lblCRentAmt);
            this.Controls.Add(this.lblPOtherAmt);
            this.Controls.Add(this.lblPEatingAmt);
            this.Controls.Add(this.lblPTransportationAmt);
            this.Controls.Add(this.lblPGroceryAmt);
            this.Controls.Add(this.lblPEntertainmentAmt);
            this.Controls.Add(this.lblPPhoneAmt);
            this.Controls.Add(this.lblPRentAmt);
            this.Controls.Add(this.lblOtherAmt);
            this.Controls.Add(this.lblEatOutAmt);
            this.Controls.Add(this.lblTransportationAmt);
            this.Controls.Add(this.lblGroceryAmt);
            this.Controls.Add(this.lblEntertainmentAmt);
            this.Controls.Add(this.lblPhoneBillAmt);
            this.Controls.Add(this.lblRentAmt);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblEatOut);
            this.Controls.Add(this.lblTransportation);
            this.Controls.Add(this.lblGrocery);
            this.Controls.Add(this.lblEntertainment);
            this.Controls.Add(this.lblPhoneBill);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.cboSelector);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lstItems);
            this.Icon = global::FinanceTracker.Properties.Resources.icon;
            this.MinimumSize = new System.Drawing.Size(680, 625);
            this.Name = "ArchiveViewer";
            this.Text = "Archives";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFinish;
        private ListView lstItems;
        private ColumnHeader hdrID;
        private ColumnHeader hdrCategory;
        private ColumnHeader hdrAmount;
        private ColumnHeader hdrPlace;
        private ColumnHeader hdrDescription;
        private ComboBox cboSelector;
        private Label lblEntry;
        private Label lblOtherAmt;
        private Label lblEatOutAmt;
        private Label lblTransportationAmt;
        private Label lblGroceryAmt;
        private Label lblEntertainmentAmt;
        private Label lblPhoneBillAmt;
        private Label lblRentAmt;
        private Label lblOther;
        private Label lblEatOut;
        private Label lblTransportation;
        private Label lblGrocery;
        private Label lblEntertainment;
        private Label lblPhoneBill;
        private Label lblRent;
        private Label lblPOtherAmt;
        private Label lblPEatingAmt;
        private Label lblPTransportationAmt;
        private Label lblPGroceryAmt;
        private Label lblPEntertainmentAmt;
        private Label lblPPhoneAmt;
        private Label lblPRentAmt;
        private Label lblCOtherAmt;
        private Label lblCEatingAmt;
        private Label lblCTransportationAmt;
        private Label lblCGroceryAmt;
        private Label lblCEntertainmentAmt;
        private Label lblCPhoneAmt;
        private Label lblCRentAmt;
        private Label lblCTotalAmt;
        private Label lblPTotalAmt;
        private Label lblTotalAmt;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;

    }
}