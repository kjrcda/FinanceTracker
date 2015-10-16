﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinanceTracker
{
    public static class Utilities
    {
        private static int nextID;
        public static String[] CATEGORIES = new String[7] { "Rent", "Phone Bill", "Entertainment", "Grocery", "Transportation", "Eating Out", "Other" };
        public static String[] FILE_NAMES = new String[3] { "file.xml", "projFile.xml", "archFile.xml" };
        
        public static void LoadID(List<FinanceEntry> list)
        {
            if (list.Count == 0)
                nextID = 1;
            else
                nextID = list[list.Count - 1].ID + 1;
        }

        public static int GetNextID()
        {
            return nextID++;
        }

        public static void LabelColor(double amt, Label lbl)
        {
            lbl.Text = amt.ToString("N2");
            if (amt < 0)
                lbl.ForeColor = Color.Red;
            else if (amt > 0)
                lbl.ForeColor = Color.Green;
            else
                lbl.ForeColor = Color.Black;
        }

        public static void CheckEscape(Form thisForm, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                thisForm.Dispose();
        }

        public static void LoadItem(ListView list, FinanceEntry item)
        {
            var row = new ListViewItem(new[] { "" + item.ID, CATEGORIES[item.Category], item.Amount.ToString("N2"), item.Place, item.Description });
            list.Items.Add(row);
            list.Items[list.Items.Count-1].EnsureVisible();
        }

        public static void ClearList(ListView list)
        {
            foreach (ListViewItem item in list.Items)
                list.Items.Remove(item);
        }

        public static void CloseWindow(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }
    }
}
