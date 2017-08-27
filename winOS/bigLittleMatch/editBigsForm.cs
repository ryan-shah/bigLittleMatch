using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigLittleMatch
{
    public partial class editBigsForm : Form
    {
        public mainForm parentForm;

        public editBigsForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            nameBox.ResetText();
            nameBox.Items.Clear();
            choicesBox.Clear();
            for (int i = 0; i < parentForm.bigs.Count; i++)
            {
                nameBox.Items.Add(parentForm.bigs[i].name);
            }
        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choicesBox.Lines = parentForm.bigs[nameBox.SelectedIndex].prefs.ToArray();
            littlesCount.Value = parentForm.bigs[nameBox.SelectedIndex].numMatches;
            delBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            girl curr;
            curr.name = nameBox.Text;
            curr.isBig = true;
            curr.numMatches = (int)littlesCount.Value;
            curr.prefs = choicesBox.Lines.ToList();
            parentForm.bigs[nameBox.SelectedIndex] = curr;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this big?\nDoing so will remove her name from all lists,\nincluding Little's preferences.";
            string caption = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                parentForm.del(parentForm.bigs[nameBox.SelectedIndex]);
                populate();
                delBtn.Enabled = false;
                parentForm.updateLists();
            }
        }
    }
}
