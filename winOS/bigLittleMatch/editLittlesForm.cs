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
    public partial class editLittlesForm : Form
    {
        public mainForm parentForm;

        public editLittlesForm()
        {
            InitializeComponent();
        }
        public void populate()
        {
            nameBox.ResetText();
            nameBox.Items.Clear();
            choicesBox.Clear();
            for (int i = 0; i < parentForm.littles.Count; i++)
            {
                nameBox.Items.Add(parentForm.littles[i].name);
            }
        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choicesBox.Lines = parentForm.littles[nameBox.SelectedIndex].prefs.ToArray();
            delBtn.Enabled = true;
        }



        private void delBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this little?\nDoing so will remove her name from all lists,\nincluding Big's preferences.";
            string caption = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if(result == DialogResult.OK)
            {
                parentForm.del(parentForm.littles[nameBox.SelectedIndex]);
                populate();
                delBtn.Enabled = false;
                parentForm.updateLists();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            girl curr = new girl();
            curr.name = nameBox.Text;
            curr.isBig = false;
            curr.prefs = choicesBox.Lines.ToList();
            parentForm.littles[nameBox.SelectedIndex] = curr;
        }
    }
}
