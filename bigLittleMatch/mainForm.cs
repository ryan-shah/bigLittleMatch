using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bigLittleMatch
{
    public struct pair
    {
        public string big;
        public string little;
    }

	public struct girl
	{
		public string name;
		public List<string> prefs;
		public bool isBig;
	}

    public partial class mainForm : Form
    {
		public List<girl> bigs = new List<girl>();
		public List<girl> littles = new List<girl>();
        public List<pair> results = new List<pair>();
		public List<girl> errors = new List<girl>();

        dataInputForm input = new dataInputForm();

        public mainForm()
        {
            InitializeComponent();
            input.parentForm = this;
        }

        private void manualInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.Show();
        }

        private void openCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                bigs = new List<girl>();
				littles = new List<girl>();
                StreamReader SR = new StreamReader(file.FileName);
                while(!SR.EndOfStream)
                {
                    var line = SR.ReadLine();
                    var values = line.Split(',');
                    if (values.Length >= 3)
                    {
						girl curr = new girl();
                        curr.prefs = new List<string>();
						curr.name = values[1];
                        for(int i = 2; i < values.Length; i++)
                        {
                            curr.prefs.Add(values[i].ToLower());
                        }
                        if(values[0] == "big")
                        {
							curr.isBig = true;
                            bigs.Add(curr);
                        } else if(values[0] == "little")
                        {
							curr.isBig = false;
                            littles.Add(curr);
                        }
                    }
                }
            }
			printLists();
        }

		private void delBig(string name)
		{
			for(int i = 0; i < bigs.Count; i++)
			{
				if(bigs[i].name.ToLower() == name.ToLower())
				{
					bigs.RemoveAt(i);
					break;
				}
			}
			for(int i = 0; i < littles.Count; i++)
			{
				for(int j = 0; j < littles[i].prefs.Count; j++)
				{
					if(littles[i].prefs[j].ToLower() == name.ToLower())
					{
						littles[i].prefs.RemoveAt(j);
						break;
					}
				}
			}
		}

		private void delLittle(string name)
		{
			for (int i = 0; i < littles.Count; i++)
			{
				if (littles[i].name.ToLower() == name.ToLower())
				{
					littles.RemoveAt(i);
					break;
				}
			}
			for (int i = 0; i < bigs.Count; i++)
			{
				for (int j = 0; j < bigs[i].prefs.Count; j++)
				{
					if (bigs[i].prefs[j].ToLower() == name.ToLower())
					{
						bigs[i].prefs.RemoveAt(j);
						break;
					}
				}
			}
		}

		private void del(girl g)
        {
            if(g.isBig)
			{
				delBig(g.name);
			} else
			{
				delLittle(g.name);
			}
        }

		private int findBig(string name)
		{
			for(int i = 0; i < bigs.Count; i++)
			{
				if(bigs[i].name.ToLower() == name.ToLower())
				{
					return i;
				}
			}
			return -1;
		}

		private void printLists()
		{
			string names = "";
			for (int i = 0; i < bigs.Count; i++)
			{
				names = names + " " + (bigs[i].name);
			}
			System.Diagnostics.Debug.WriteLine(names);
			names = "";
			for (int i = 0; i < littles.Count; i++)
			{
				names = names + " " + littles[i].name;
			}
			System.Diagnostics.Debug.WriteLine(names);
		}

		private void computeMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int loopCounter = 0;
			bool changed = false;
            while (bigs.Count > 0 && littles.Count > 0) {
                for(int i = 0; i < littles.Count; i++)
				{
					//System.Diagnostics.Debug.WriteLine("littles[i].prefs.count " + littles[i].prefs.Count);
					if(littles[i].prefs.Count > 0)
					{
						int bigPos = findBig(littles[i].prefs[0]);
						//System.Diagnostics.Debug.WriteLine("big, bigpos : " + littles[i].prefs[0] + ", " + bigPos);
						if (bigPos != -1 && bigs[bigPos].prefs.Count > 0)
						{
							if (bigs[bigPos].prefs[0].ToLower() == littles[i].name.ToLower())
							{
								pair match = new pair();
								match.big = bigs[bigPos].name;
								match.little = littles[i].name;
								System.Diagnostics.Debug.WriteLine("match found " + bigs[bigPos].name + " " + littles[i].name);
								delBig(bigs[bigPos].name);
								delLittle(littles[i].name);
								results.Add(match);
								changed = true;
								break;
							}
						}
					}
				}
				if(!changed)
				{
					loopCounter++;
				} else
				{
					changed = false;
					loopCounter = 0;
				}
				if(loopCounter > 3)
				{
					foreach(girl g in bigs)
					{
						errors.Add(g);
					}
					foreach(girl g in littles)
					{
						errors.Add(g);
					}
					break;
				}
            }
            List<string> bs = new List<string>();
            List<string> ls = new List<string>();
            foreach(var p in results)
            {
                bs.Add(p.big);
                ls.Add(p.little);
            }
            bigsBox.Lines = bs.ToArray();
            littleBox.Lines = ls.ToArray();
        }
    }
}
