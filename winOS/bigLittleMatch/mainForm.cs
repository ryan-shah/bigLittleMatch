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
        public int numMatches;
	}

    public partial class mainForm : Form
    {
		public List<girl> bigs = new List<girl>();
		public List<girl> littles = new List<girl>();
        public List<girl> bigsTemp = new List<girl>(); //to be modified when computing matches
        public List<girl> littlesTemp = new List<girl>(); //to be modified when computing matches

        public List<pair> results = new List<pair>();
		public List<girl> errors = new List<girl>();

        dataInputForm input = new dataInputForm();
        editBigsForm ebf = new editBigsForm();
        editLittlesForm elf = new editLittlesForm();

        public mainForm()
        {
            InitializeComponent();
            input.parentForm = this;
            ebf.parentForm = this;
            elf.parentForm = this;
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
                string headers = SR.ReadLine();
                while(!SR.EndOfStream)
                {
                    var line = SR.ReadLine();
                    var values = line.Split(',');
                    if (values.Length >= 4)
                    {
						girl curr = new girl();
                        curr.prefs = new List<string>();
						curr.name = values[2];
                        curr.numMatches = 1;
                        for(int i = 4; i < values.Length; i++)
                        {
                            curr.prefs.Add(values[i].ToLower());
                        }
                        if(values[3] == "Big")
                        {
							curr.isBig = true;
                            bigs.Add(curr);
                        } else if(values[3] == "Little")
                        {
							curr.isBig = false;
                            littles.Add(curr);
                        }
                    }
                }
                SR.Close();
            }
			//printLists();
        }

		private void delBig(string name, ref List<girl> littles, ref List<girl> bigs)
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

        public void del(girl g)
        {
            if(g.isBig)
            {
                delBig(g.name, ref littles, ref bigs);
            } else
            {
                delLittle(g.name, ref littles, ref bigs);
            }
        }

		private void delLittle(string name, ref List<girl> littles, ref List<girl> bigs)
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

        public void decreaseBig(int index, ref List<girl> littles, ref List<girl> bigs)
        {
            if(bigs[index].numMatches > 1)
            {
                girl curr = bigs[index];
                curr.numMatches -= 1;
                bigs[index] = curr;
            } else
            {
                delBig(bigs[index].name, ref littles, ref bigs);
            }
        }

		private int findBig(string name, ref List<girl> bigs)
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

		private void printLists(List<girl> ls)
		{
			string names = "";
			for (int i = 0; i < ls.Count; i++)
			{
				names = names + " " + (bigs[i].name);
			}
			System.Diagnostics.Debug.WriteLine(names);
		}

        private void computeMatches()
        {
            //clear old results
            results = new List<pair>();
            errors = new List<girl>();
            //set temp lists
            bigsTemp = bigs;
            littlesTemp = littles;

            int loopCounter = 0;
            bool changed = false;
            while (bigsTemp.Count > 0 && littlesTemp.Count > 0)
            {
                for (int i = 0; i < littlesTemp.Count; i++)
                {
                    //System.Diagnostics.Debug.WriteLine("littles[i].prefs.count " + littles[i].prefs.Count);
                    if (littlesTemp[i].prefs.Count > 0)
                    {
                        int bigPos = findBig(littlesTemp[i].prefs[0], ref bigsTemp);
                        //System.Diagnostics.Debug.WriteLine("big, bigpos : " + littles[i].prefs[0] + ", " + bigPos);
                        if (bigPos != -1 && bigsTemp[bigPos].prefs.Count > 0)
                        {
                            if (bigsTemp[bigPos].prefs[0].ToLower() == littlesTemp[i].name.ToLower())
                            {
                                pair match = new pair();
                                match.big = bigsTemp[bigPos].name;
                                match.little = littlesTemp[i].name;
                                //System.Diagnostics.Debug.WriteLine("match found " + bigs[bigPos].name + " " + littles[i].name);
                                decreaseBig(bigPos, ref littlesTemp, ref bigsTemp);
                                delLittle(littlesTemp[i].name, ref littlesTemp, ref bigsTemp);
                                results.Add(match);
                                changed = true;
                                i--;
                            }
                        }
                    }
                }
                if (!changed)
                {
                    loopCounter++;
                }
                else
                {
                    changed = false;
                    loopCounter = 0;
                }
                if (loopCounter > 3)
                {
                    break;
                }
            }
            foreach (girl g in bigsTemp)
            {
                errors.Add(g);
            }
            foreach (girl g in littlesTemp)
            {
                errors.Add(g);
            }
            printLists(errors);
        }

		private void computeMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computeMatches();
            List<string> bs = new List<string>();
            List<string> ls = new List<string>();
            foreach (var p in results)
            {
                bs.Add(p.big);
                ls.Add(p.little);
            }
            bigsBox.Lines = bs.ToArray();
            littleBox.Lines = ls.ToArray();
        }

        private void bigsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ebf.populate();
            ebf.Show();
        }

        private void littlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elf.populate();
            elf.Show();
        }
    }
}
