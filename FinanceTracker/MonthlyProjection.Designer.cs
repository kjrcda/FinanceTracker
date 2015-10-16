using System.ComponentModel;
using System.Windows.Forms;

namespace FinanceTracker
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
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(118, 203);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(49, 18);
            this.lblOther.TabIndex = 99;
            this.lblOther.Text = "Other:";
            // 
            // lblEatOut
            // 
            this.lblEatOut.AutoSize = true;
            this.lblEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOut.Location = new System.Drawing.Point(86, 176);
            this.lblEatOut.Name = "lblEatOut";
            this.lblEatOut.Size = new System.Drawing.Size(81, 18);
            this.lblEatOut.TabIndex = 99;
            this.lblEatOut.Text = "Eating Out:";
            // 
            // lblTransportation
            // 
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportation.Location = new System.Drawing.Point(59, 149);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(108, 18);
            this.lblTransportation.TabIndex = 99;
            this.lblTransportation.Text = "Transportation:";
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.Location = new System.Drawing.Point(101, 122);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(66, 18);
            this.lblGrocery.TabIndex = 99;
            this.lblGrocery.Text = "Grocery:";
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainment.Location = new System.Drawing.Point(64, 95);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(103, 18);
            this.lblEntertainment.TabIndex = 99;
            this.lblEntertainment.Text = "Entertainment:";
            // 
            // lblPhoneBill
            // 
            this.lblPhoneBill.AutoSize = true;
            this.lblPhoneBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBill.Location = new System.Drawing.Point(89, 68);
            this.lblPhoneBill.Name = "lblPhoneBill";
            this.lblPhoneBill.Size = new System.Drawing.Size(78, 18);
            this.lblPhoneBill.TabIndex = 99;
            this.lblPhoneBill.Text = "Phone Bill:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(124, 41);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(43, 18);
            this.lblRent.TabIndex = 99;
            this.lblRent.Text = "Rent:";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(173, 39);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(132, 20);
            this.txtRent.TabIndex = 0;
            this.txtRent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtRent.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtPhoneBill
            // 
            this.txtPhoneBill.Location = new System.Drawing.Point(173, 69);
            this.txtPhoneBill.Name = "txtPhoneBill";
            this.txtPhoneBill.Size = new System.Drawing.Size(132, 20);
            this.txtPhoneBill.TabIndex = 1;
            this.txtPhoneBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtPhoneBill.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtEntertainment
            // 
            this.txtEntertainment.Location = new System.Drawing.Point(173, 96);
            this.txtEntertainment.Name = "txtEntertainment";
            this.txtEntertainment.Size = new System.Drawing.Size(132, 20);
            this.txtEntertainment.TabIndex = 2;
            this.txtEntertainment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtEntertainment.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtGrocery
            // 
            this.txtGrocery.Location = new System.Drawing.Point(173, 123);
            this.txtGrocery.Name = "txtGrocery";
            this.txtGrocery.Size = new System.Drawing.Size(132, 20);
            this.txtGrocery.TabIndex = 3;
            this.txtGrocery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtGrocery.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtTransportation
            // 
            this.txtTransportation.Location = new System.Drawing.Point(173, 150);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(132, 20);
            this.txtTransportation.TabIndex = 4;
            this.txtTransportation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtTransportation.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtEatOut
            // 
            this.txtEatOut.Location = new System.Drawing.Point(173, 178);
            this.txtEatOut.Name = "txtEatOut";
            this.txtEatOut.Size = new System.Drawing.Size(132, 20);
            this.txtEatOut.TabIndex = 5;
            this.txtEatOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtEatOut.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(173, 204);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(132, 20);
            this.txtOther.TabIndex = 6;
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            this.txtOther.LostFocus += new System.EventHandler(this.UpdateTotal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 2);
            this.label2.TabIndex = 99;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(173, 239);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 18);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "$0.00";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(Utilities.CloseWindow);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(292, 389);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 37);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MonthlyProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 438);
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
            this.Icon = global::FinanceTracker.Properties.Resources.icon;
            this.MaximumSize = new System.Drawing.Size(427, 477);
            this.MinimumSize = new System.Drawing.Size(427, 477);
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