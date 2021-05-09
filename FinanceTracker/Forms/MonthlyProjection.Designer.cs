using System.ComponentModel;
using System.Windows.Forms;

namespace FinanceTracker.Forms
{
    partial class MonthlyProjection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyProjection));
            this.lblOther = new System.Windows.Forms.Label();
            this.lblEatOut = new System.Windows.Forms.Label();
            this.lblTransportation = new System.Windows.Forms.Label();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.lblEntertainment = new System.Windows.Forms.Label();
            this.lblPhoneBill = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.txtPhoneBill = new System.Windows.Forms.TextBox();
            this.txtEntertainment = new System.Windows.Forms.TextBox();
            this.txtGrocery = new System.Windows.Forms.TextBox();
            this.txtTransportation = new System.Windows.Forms.TextBox();
            this.txtEatOut = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOther.Location = new System.Drawing.Point(138, 234);
            this.lblOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(49, 18);
            this.lblOther.TabIndex = 99;
            this.lblOther.Text = "Other:";
            // 
            // lblEatOut
            // 
            this.lblEatOut.AutoSize = true;
            this.lblEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEatOut.Location = new System.Drawing.Point(100, 203);
            this.lblEatOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEatOut.Name = "lblEatOut";
            this.lblEatOut.Size = new System.Drawing.Size(81, 18);
            this.lblEatOut.TabIndex = 99;
            this.lblEatOut.Text = "Eating Out:";
            // 
            // lblTransportation
            // 
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransportation.Location = new System.Drawing.Point(69, 172);
            this.lblTransportation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(108, 18);
            this.lblTransportation.TabIndex = 99;
            this.lblTransportation.Text = "Transportation:";
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrocery.Location = new System.Drawing.Point(118, 141);
            this.lblGrocery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(66, 18);
            this.lblGrocery.TabIndex = 99;
            this.lblGrocery.Text = "Grocery:";
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntertainment.Location = new System.Drawing.Point(75, 110);
            this.lblEntertainment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(103, 18);
            this.lblEntertainment.TabIndex = 99;
            this.lblEntertainment.Text = "Entertainment:";
            // 
            // lblPhoneBill
            // 
            this.lblPhoneBill.AutoSize = true;
            this.lblPhoneBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneBill.Location = new System.Drawing.Point(104, 78);
            this.lblPhoneBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneBill.Name = "lblPhoneBill";
            this.lblPhoneBill.Size = new System.Drawing.Size(78, 18);
            this.lblPhoneBill.TabIndex = 99;
            this.lblPhoneBill.Text = "Phone Bill:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRent.Location = new System.Drawing.Point(145, 47);
            this.lblRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(43, 18);
            this.lblRent.TabIndex = 99;
            this.lblRent.Text = "Rent:";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(202, 45);
            this.txtRent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(153, 23);
            this.txtRent.TabIndex = 0;
            this.txtRent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtRent.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtPhoneBill
            // 
            this.txtPhoneBill.Location = new System.Drawing.Point(202, 80);
            this.txtPhoneBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneBill.Name = "txtPhoneBill";
            this.txtPhoneBill.Size = new System.Drawing.Size(153, 23);
            this.txtPhoneBill.TabIndex = 1;
            this.txtPhoneBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtPhoneBill.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtEntertainment
            // 
            this.txtEntertainment.Location = new System.Drawing.Point(202, 111);
            this.txtEntertainment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEntertainment.Name = "txtEntertainment";
            this.txtEntertainment.Size = new System.Drawing.Size(153, 23);
            this.txtEntertainment.TabIndex = 2;
            this.txtEntertainment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtEntertainment.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtGrocery
            // 
            this.txtGrocery.Location = new System.Drawing.Point(202, 142);
            this.txtGrocery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGrocery.Name = "txtGrocery";
            this.txtGrocery.Size = new System.Drawing.Size(153, 23);
            this.txtGrocery.TabIndex = 3;
            this.txtGrocery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtGrocery.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtTransportation
            // 
            this.txtTransportation.Location = new System.Drawing.Point(202, 173);
            this.txtTransportation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(153, 23);
            this.txtTransportation.TabIndex = 4;
            this.txtTransportation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtTransportation.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtEatOut
            // 
            this.txtEatOut.Location = new System.Drawing.Point(202, 205);
            this.txtEatOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEatOut.Name = "txtEatOut";
            this.txtEatOut.Size = new System.Drawing.Size(153, 23);
            this.txtEatOut.TabIndex = 5;
            this.txtEatOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtEatOut.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(202, 235);
            this.txtOther.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(153, 23);
            this.txtOther.TabIndex = 6;
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPressAction);
            this.txtOther.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 2);
            this.label2.TabIndex = 99;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(202, 276);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 18);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "$0.00";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 449);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(341, 449);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 43);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MonthlyProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 505);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtEatOut);
            this.Controls.Add(this.txtTransportation);
            this.Controls.Add(this.txtGrocery);
            this.Controls.Add(this.txtEntertainment);
            this.Controls.Add(this.txtPhoneBill);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblEatOut);
            this.Controls.Add(this.lblTransportation);
            this.Controls.Add(this.lblGrocery);
            this.Controls.Add(this.lblEntertainment);
            this.Controls.Add(this.lblPhoneBill);
            this.Controls.Add(this.lblRent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(495, 544);
            this.MinimumSize = new System.Drawing.Size(495, 544);
            this.Name = "MonthlyProjection";
            this.Text = "Monthly Projection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOther;
        private Label lblEatOut;
        private Label lblTransportation;
        private Label lblGrocery;
        private Label lblEntertainment;
        private Label lblPhoneBill;
        private Label lblRent;
        private TextBox txtRent;
        private TextBox txtPhoneBill;
        private TextBox txtEntertainment;
        private TextBox txtGrocery;
        private TextBox txtTransportation;
        private TextBox txtEatOut;
        private TextBox txtOther;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private Button btnCancel;
        private Button btnOK;
    }
}