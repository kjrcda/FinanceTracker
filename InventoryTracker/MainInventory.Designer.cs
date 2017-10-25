namespace InventoryTracker
{
    partial class InventoryTracker
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListView();
            this.hdrPhoneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrLowestPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(12, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(366, 526);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrPhoneModel,
            this.hdrColor,
            this.hdrStock,
            this.hdrLowestPrice});
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.Location = new System.Drawing.Point(12, 75);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(470, 429);
            this.lstItems.TabIndex = 23;
            this.lstItems.TabStop = false;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            // 
            // hdrPhoneModel
            // 
            this.hdrPhoneModel.Text = "Phone Model";
            this.hdrPhoneModel.Width = 144;
            // 
            // hdrStock
            // 
            this.hdrStock.Text = "Stock";
            this.hdrStock.Width = 80;
            // 
            // hdrLowestPrice
            // 
            this.hdrLowestPrice.Text = "Lowest Price";
            this.hdrLowestPrice.Width = 120;
            // 
            // hdrColor
            // 
            this.hdrColor.Text = "Color";
            this.hdrColor.Width = 118;
            // 
            // InventoryTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 570);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Name = "InventoryTracker";
            this.Text = "Inventory Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader hdrPhoneModel;
        private System.Windows.Forms.ColumnHeader hdrStock;
        private System.Windows.Forms.ColumnHeader hdrLowestPrice;
        private System.Windows.Forms.ColumnHeader hdrColor;

    }
}

