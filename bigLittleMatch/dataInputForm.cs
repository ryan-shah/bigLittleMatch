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
    public partial class dataInputForm : Form
    {
        public mainForm parentForm;

        public dataInputForm()
        {
            InitializeComponent();
        }

        private void addBigs_Click(object sender, EventArgs e)
        {
			girl g = new girl();
			g.isBig = true;
			g.name = nameBox.Text;
			g.prefs = prefBox.Lines.ToList();
            parentForm.bigs.Add(g);
            resetForm();
        }

        private void addLittles_Click(object sender, EventArgs e)
        {
			girl g = new girl();
			g.isBig = true;
			g.name = nameBox.Text;
			g.prefs = prefBox.Lines.ToList();
			parentForm.littles.Add(g);
            resetForm();
        }
        private void resetForm()
        {
            nameBox.ResetText();
            prefBox.ResetText();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
