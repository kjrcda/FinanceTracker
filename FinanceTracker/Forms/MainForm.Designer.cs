using System.ComponentModel;
using System.Windows.Forms;

namespace FinanceTracker.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabSpent = new System.Windows.Forms.TabPage();
            this.lstItems = new System.Windows.Forms.ListView();
            this.hdrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProjection = new System.Windows.Forms.Button();
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
            this.tabOwed = new System.Windows.Forms.TabPage();
            this.lstPayments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.strpMainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalsAcrossMonthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlspCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPages.SuspendLayout();
            this.tabSpent.SuspendLayout();
            this.tabOwed.SuspendLayout();
            this.strpMainMenu.SuspendLayout();
            this.lstViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(12, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(556, 582);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 32);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabPages
            // 
            this.tabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPages.Controls.Add(this.tabSpent);
            this.tabPages.Controls.Add(this.tabOwed);
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages.Location = new System.Drawing.Point(12, 39);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(660, 537);
            this.tabPages.TabIndex = 3;
            this.tabPages.TabStop = false;
            // 
            // tabSpent
            // 
            this.tabSpent.Controls.Add(this.lstItems);
            this.tabSpent.Controls.Add(this.btnProjection);
            this.tabSpent.Controls.Add(this.lblOtherAmt);
            this.tabSpent.Controls.Add(this.lblEatOutAmt);
            this.tabSpent.Controls.Add(this.lblTransportationAmt);
            this.tabSpent.Controls.Add(this.lblGroceryAmt);
            this.tabSpent.Controls.Add(this.lblEntertainmentAmt);
            this.tabSpent.Controls.Add(this.lblPhoneBillAmt);
            this.tabSpent.Controls.Add(this.lblRentAmt);
            this.tabSpent.Controls.Add(this.lblOther);
            this.tabSpent.Controls.Add(this.lblEatOut);
            this.tabSpent.Controls.Add(this.lblTransportation);
            this.tabSpent.Controls.Add(this.lblGrocery);
            this.tabSpent.Controls.Add(this.lblEntertainment);
            this.tabSpent.Controls.Add(this.lblPhoneBill);
            this.tabSpent.Controls.Add(this.lblRent);
            this.tabSpent.Location = new System.Drawing.Point(4, 25);
            this.tabSpent.Name = "tabSpent";
            this.tabSpent.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpent.Size = new System.Drawing.Size(652, 508);
            this.tabSpent.TabIndex = 0;
            this.tabSpent.Text = "Money Spent";
            this.tabSpent.UseVisualStyleBackColor = true;
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
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.Location = new System.Drawing.Point(6, 115);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(640, 387);
            this.lstItems.TabIndex = 15;
            this.lstItems.TabStop = false;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstItems_ColumnSort);
            this.lstItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstItems_Click);
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
            // btnProjection
            // 
            this.btnProjection.Location = new System.Drawing.Point(438, 66);
            this.btnProjection.Name = "btnProjection";
            this.btnProjection.Size = new System.Drawing.Size(116, 32);
            this.btnProjection.TabIndex = 0;
            this.btnProjection.Text = "Projection";
            this.btnProjection.UseVisualStyleBackColor = true;
            this.btnProjection.Click += new System.EventHandler(this.btnProjection_Click);
            // 
            // lblOtherAmt
            // 
            this.lblOtherAmt.AutoSize = true;
            this.lblOtherAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAmt.Location = new System.Drawing.Point(490, 26);
            this.lblOtherAmt.Name = "lblOtherAmt";
            this.lblOtherAmt.Size = new System.Drawing.Size(34, 18);
            this.lblOtherAmt.TabIndex = 99;
            this.lblOtherAmt.Text = "Amt";
            // 
            // lblEatOutAmt
            // 
            this.lblEatOutAmt.AutoSize = true;
            this.lblEatOutAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOutAmt.Location = new System.Drawing.Point(332, 80);
            this.lblEatOutAmt.Name = "lblEatOutAmt";
            this.lblEatOutAmt.Size = new System.Drawing.Size(34, 18);
            this.lblEatOutAmt.TabIndex = 99;
            this.lblEatOutAmt.Text = "Amt";
            // 
            // lblTransportationAmt
            // 
            this.lblTransportationAmt.AutoSize = true;
            this.lblTransportationAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationAmt.Location = new System.Drawing.Point(332, 53);
            this.lblTransportationAmt.Name = "lblTransportationAmt";
            this.lblTransportationAmt.Size = new System.Drawing.Size(34, 18);
            this.lblTransportationAmt.TabIndex = 99;
            this.lblTransportationAmt.Text = "Amt";
            // 
            // lblGroceryAmt
            // 
            this.lblGroceryAmt.AutoSize = true;
            this.lblGroceryAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroceryAmt.Location = new System.Drawing.Point(332, 26);
            this.lblGroceryAmt.Name = "lblGroceryAmt";
            this.lblGroceryAmt.Size = new System.Drawing.Size(34, 18);
            this.lblGroceryAmt.TabIndex = 99;
            this.lblGroceryAmt.Text = "Amt";
            // 
            // lblEntertainmentAmt
            // 
            this.lblEntertainmentAmt.AutoSize = true;
            this.lblEntertainmentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainmentAmt.Location = new System.Drawing.Point(118, 80);
            this.lblEntertainmentAmt.Name = "lblEntertainmentAmt";
            this.lblEntertainmentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblEntertainmentAmt.TabIndex = 99;
            this.lblEntertainmentAmt.Text = "Amt";
            // 
            // lblPhoneBillAmt
            // 
            this.lblPhoneBillAmt.AutoSize = true;
            this.lblPhoneBillAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBillAmt.Location = new System.Drawing.Point(118, 53);
            this.lblPhoneBillAmt.Name = "lblPhoneBillAmt";
            this.lblPhoneBillAmt.Size = new System.Drawing.Size(34, 18);
            this.lblPhoneBillAmt.TabIndex = 99;
            this.lblPhoneBillAmt.Text = "Amt";
            // 
            // lblRentAmt
            // 
            this.lblRentAmt.AutoSize = true;
            this.lblRentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentAmt.Location = new System.Drawing.Point(118, 26);
            this.lblRentAmt.Name = "lblRentAmt";
            this.lblRentAmt.Size = new System.Drawing.Size(34, 18);
            this.lblRentAmt.TabIndex = 99;
            this.lblRentAmt.Text = "Amt";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(435, 26);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(49, 18);
            this.lblOther.TabIndex = 99;
            this.lblOther.Text = "Other:";
            // 
            // lblEatOut
            // 
            this.lblEatOut.AutoSize = true;
            this.lblEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOut.Location = new System.Drawing.Point(245, 80);
            this.lblEatOut.Name = "lblEatOut";
            this.lblEatOut.Size = new System.Drawing.Size(81, 18);
            this.lblEatOut.TabIndex = 99;
            this.lblEatOut.Text = "Eating Out:";
            // 
            // lblTransportation
            // 
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportation.Location = new System.Drawing.Point(218, 53);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(108, 18);
            this.lblTransportation.TabIndex = 99;
            this.lblTransportation.Text = "Transportation:";
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.Location = new System.Drawing.Point(260, 26);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(66, 18);
            this.lblGrocery.TabIndex = 99;
            this.lblGrocery.Text = "Grocery:";
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainment.Location = new System.Drawing.Point(9, 80);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(103, 18);
            this.lblEntertainment.TabIndex = 99;
            this.lblEntertainment.Text = "Entertainment:";
            // 
            // lblPhoneBill
            // 
            this.lblPhoneBill.AutoSize = true;
            this.lblPhoneBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBill.Location = new System.Drawing.Point(34, 53);
            this.lblPhoneBill.Name = "lblPhoneBill";
            this.lblPhoneBill.Size = new System.Drawing.Size(78, 18);
            this.lblPhoneBill.TabIndex = 99;
            this.lblPhoneBill.Text = "Phone Bill:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(69, 26);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(43, 18);
            this.lblRent.TabIndex = 99;
            this.lblRent.Text = "Rent:";
            // 
            // tabOwed
            // 
            this.tabOwed.Controls.Add(this.lstPayments);
            this.tabOwed.Location = new System.Drawing.Point(4, 25);
            this.tabOwed.Name = "tabOwed";
            this.tabOwed.Padding = new System.Windows.Forms.Padding(3);
            this.tabOwed.Size = new System.Drawing.Size(652, 508);
            this.tabOwed.TabIndex = 1;
            this.tabOwed.Text = "Money Made";
            this.tabOwed.UseVisualStyleBackColor = true;
            this.tabOwed.Click += new System.EventHandler(this.TabClicked);
            // 
            // lstPayments
            // 
            this.lstPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPayments.FullRowSelect = true;
            this.lstPayments.GridLines = true;
            this.lstPayments.Location = new System.Drawing.Point(6, 115);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(640, 387);
            this.lstPayments.TabIndex = 16;
            this.lstPayments.TabStop = false;
            this.lstPayments.UseCompatibleStateImageBehavior = false;
            this.lstPayments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Recieved From";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 381;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(312, 582);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(434, 582);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 32);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // strpMainMenu
            // 
            this.strpMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.strpMainMenu.Location = new System.Drawing.Point(0, 0);
            this.strpMainMenu.Name = "strpMainMenu";
            this.strpMainMenu.Size = new System.Drawing.Size(684, 24);
            this.strpMainMenu.TabIndex = 6;
            this.strpMainMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.optionsToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMonthToolStripMenuItem,
            this.archiveMonthToolStripMenuItem,
            this.totalsAcrossMonthsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importToolStripMenuItem.Text = "Restore As...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToolStripMenuItem.Text = "Backup";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // viewMonthToolStripMenuItem
            // 
            this.viewMonthToolStripMenuItem.Name = "viewMonthToolStripMenuItem";
            this.viewMonthToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewMonthToolStripMenuItem.Text = "View Archive";
            this.viewMonthToolStripMenuItem.Click += new System.EventHandler(this.viewArchiveToolStripMenuItem_Click);
            // 
            // archiveMonthToolStripMenuItem
            // 
            this.archiveMonthToolStripMenuItem.Name = "archiveMonthToolStripMenuItem";
            this.archiveMonthToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.archiveMonthToolStripMenuItem.Text = "Archive Month";
            this.archiveMonthToolStripMenuItem.Click += new System.EventHandler(this.archiveMonthToolStripMenuItem_Click);
            // 
            // totalsAcrossMonthsToolStripMenuItem
            // 
            this.totalsAcrossMonthsToolStripMenuItem.Name = "totalsAcrossMonthsToolStripMenuItem";
            this.totalsAcrossMonthsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.totalsAcrossMonthsToolStripMenuItem.Text = "Totals Across Months";
            this.totalsAcrossMonthsToolStripMenuItem.Click += new System.EventHandler(this.totalsAcrossMonthsToolStripMenuItem_Click);
            // 
            // lstViewContextMenu
            // 
            this.lstViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlspCopy});
            this.lstViewContextMenu.Name = "contextMenuStrip1";
            this.lstViewContextMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // tlspCopy
            // 
            this.tlspCopy.Name = "tlspCopy";
            this.tlspCopy.Size = new System.Drawing.Size(102, 22);
            this.tlspCopy.Text = "Copy";
            this.tlspCopy.Click += new System.EventHandler(this.tlspCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 626);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.strpMainMenu);
            this.Icon = global::FinanceTracker.Properties.Resources.icon;
            this.MainMenuStrip = this.strpMainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "Finance Tracker";
            this.tabPages.ResumeLayout(false);
            this.tabSpent.ResumeLayout(false);
            this.tabSpent.PerformLayout();
            this.tabOwed.ResumeLayout(false);
            this.strpMainMenu.ResumeLayout(false);
            this.strpMainMenu.PerformLayout();
            this.lstViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProjection;
        private Button btnExit;
        private Button btnNew;
        private TabControl tabPages;
        private TabPage tabSpent;
        private TabPage tabOwed;
        private Label lblOther;
        private Label lblEatOut;
        private Label lblTransportation;
        private Label lblGrocery;
        private Label lblEntertainment;
        private Label lblPhoneBill;
        private Label lblRent;
        private Label lblOtherAmt;
        private Label lblEatOutAmt;
        private Label lblTransportationAmt;
        private Label lblGroceryAmt;
        private Label lblEntertainmentAmt;
        private Label lblPhoneBillAmt;
        private Label lblRentAmt;
        private ListView lstItems;
        private ColumnHeader hdrID;
        private ColumnHeader hdrAmount;
        private ColumnHeader hdrCategory;
        private ColumnHeader hdrPlace;
        private Button btnDelete;
        private ColumnHeader hdrDescription;
        private Button btnEdit;
        private MenuStrip strpMainMenu;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem1;
        private ToolStripMenuItem archiveMonthToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem viewMonthToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem totalsAcrossMonthsToolStripMenuItem;
        private ContextMenuStrip lstViewContextMenu;
        private ToolStripMenuItem tlspCopy;
        private ListView lstPayments;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}

