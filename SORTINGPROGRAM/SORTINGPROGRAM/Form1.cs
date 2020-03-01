using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SORTINGPROGRAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<object> displayListInListBox(List<int> originalList, bool sorted = false)
        {
            List<int> newList = originalList.ToList();
            List<object> output = new List<object>();

            if (sorted)
            {
                List<int> duplicates = new List<int>();

                foreach (int i in newList)
                {
                    List<int> temp = newList.Where(x => x == i).ToList();

                    if (duplicates.Contains(i)) continue;
                    if (temp.Count > 1)
                    {
                        output.Add(i + " (" + temp.Count + ") ");
                        duplicates.Add(i);
                    }
                    else output.Add(i.ToString());
                }
            }
            else
            {
                foreach (int i in newList)
                    output.Add(i.ToString());
            }

            return output;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            listBoxAscending.Items.Clear();
            listBoxDescending.Items.Clear();
            listBoxOriginal.Items.Clear();

            int start = int.Parse(txtBoxStart.Text);
            int end = int.Parse(txtBoxEnd.Text);

            Random r = new Random();

            List<int> randomSequence = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                randomSequence.Add(r.Next(start, end + 1));
            }

            listBoxOriginal.Items.AddRange(displayListInListBox(randomSequence).ToArray());
            randomSequence.Sort();

            listBoxAscending.Items.AddRange(displayListInListBox(randomSequence, true).ToArray());

            randomSequence.Reverse();
            listBoxDescending.Items.AddRange(displayListInListBox(randomSequence, true).ToArray());

        }

        private void ConfirmInputs()
        {
            int start = txtBoxStart.Text == string.Empty ? int.MinValue :  int.Parse(txtBoxStart.Text); //if txtbox is empty, assume value of min
            int end = txtBoxEnd.Text == string.Empty ? int.MinValue :  int.Parse(txtBoxEnd.Text);

            buttonSort.Enabled = !((start > 999 || start < 1) || (end > 1000 || end < 1) || (start > end));
        }


        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            string validValues = "1234567890";

            if (validValues.Contains(e.KeyCode.ToString().Last()) || e.KeyCode == Keys.Back) e.SuppressKeyPress = false;
            else e.SuppressKeyPress = true;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfirmInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
