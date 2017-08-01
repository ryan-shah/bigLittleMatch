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
    //pair struct for big+little
    public struct pair
    {
        public string big;
        public string little;
    }
    //girl struct for holding info
	public struct girl
	{
		public string name;
		public List<string> prefs;
		public bool isBig;
        public int numMatches;
	}

    public partial class mainForm : Form
    {
        //big and little lists to hold data
		public List<girl> bigs = new List<girl>(); //only changed when adding/reseting/permanately deleting bigs
		public List<girl> littles = new List<girl>(); //only changed when adding/reseting/permanately deleting littles
        public List<girl> bigsTemp = new List<girl>(); //to be modified when computing matches
        public List<girl> littlesTemp = new List<girl>(); //to be modified when computing matches

        public List<pair> results = new List<pair>(); //holds big+little match results
		public List<girl> errors = new List<girl>(); //holds bigs/littles for which matching failed

        //child forms
        dataInputForm input = new dataInputForm();
        editBigsForm ebf = new editBigsForm();
        editLittlesForm elf = new editLittlesForm();
        helpForm help = new helpForm();
        matchesForm matches = new matchesForm();

        //set parents of child forms
        private void setParents()
        {
            input.parentForm = this;
            ebf.parentForm = this;
            elf.parentForm = this;
            help.parentForm = this;
            matches.parentForm = this;
        }

        public void copyLists(List<girl> from, List<girl> to)
        {
            to.Clear();
            foreach(girl o in from)
            {
                to.Add(o);
            }
        }

        //opens a file and scans for big/little data
        //overwrites current data
        private void openFile()
        {
            //make sure user knows about overwrite
            bool open = false;
            DialogResult result;
            if (bigs.Count > 0 || littles.Count > 0) {
                result = MessageBox.Show("Importing a file will erase all current data.\nAre you sure you want to import?", "Open?", MessageBoxButtons.OKCancel);
            } else
            {
                result = DialogResult.OK;
            }
            if(result == DialogResult.OK)
            {
                open = true;
            }
            if (open)
            {
                //open file and prepare to read
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "csv files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    bigs = new List<girl>();
                    littles = new List<girl>();
                    StreamReader SR = new StreamReader(file.FileName);
                    //read header line;
                    string headers = SR.ReadLine();
                    //try catch to prevent crash on failure to read
                    try
                    {
                        //read each line
                        while (!SR.EndOfStream)
                        {
                            var line = SR.ReadLine();
                            //split line
                            var values = line.Split(',');
                            //make sure there are at least values so we dont go out of bounds
                            if (values.Length >= 4)
                            {
                                //pull values
                                girl curr = new girl();
                                curr.prefs = new List<string>();
                                curr.name = values[2];
                                curr.numMatches = 1;
                                //for the remainder of values
                                //last col is email so skips
                                for (int i = 4; i < values.Length -1; i++)
                                {
                                    curr.prefs.Add(values[i].ToLower());
                                }
                                if (values[3] == "Big")
                                {
                                    curr.isBig = true;
                                    bigs.Add(curr);
                                }
                                else if (values[3] == "Little")
                                {
                                    curr.isBig = false;
                                    littles.Add(curr);
                                }
                            }
                        }
                    } catch {
                        //show error box
                        MessageBox.Show("There was an error loading your data!\nPlease make sure your CSV file is formatted correctly");
                    }
                    SR.Close();
                }
                //update form to show lists
                updateLists();
            }
        }

        //set main screen boxes to current status of Bigs and Littles
        public void updateLists()
        {
            List<string> bs = new List<string>();
            List<string> ls = new List<string>();
            foreach (var g in bigs)
            {
                bs.Add(g.name);
            }
            foreach (var g in littles)
            {
                ls.Add(g.name);
            }
            bigsBox.Lines = bs.ToArray();
            littleBox.Lines = ls.ToArray();
        }

        //deletes a girl from bigs and littles
        public void del(girl g)
        {
            if (g.isBig)
            {
                delBig(g.name, ref littles, ref bigs);
            }
            else
            {
                delLittle(g.name, ref littles, ref bigs);
            }
        }

        //deletes a big from provided lists of littles and bigs
        //made with refs to allow deletion from temp or main lists
        private void delBig(string name, ref List<girl> littles, ref List<girl> bigs)
		{
            //remove from bigs
			for(int i = 0; i < bigs.Count; i++)
			{
				if(bigs[i].name.ToLower() == name.ToLower())
				{
					bigs.RemoveAt(i);
					break;
				}
			}
            //remove from littles pref lists
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

        //deletes a little from provided lists of littles and bigs
        //made with refs to allow deletion from temp or main lists
        private void delLittle(string name, ref List<girl> li, ref List<girl> bi)
		{
            //remove from littles
			for (int i = 0; i < li.Count; i++)
			{
				if (li[i].name.ToLower() == name.ToLower())
				{
					li.RemoveAt(i);
					break;
				}
			}
            //remove from big prefs
			for (int i = 0; i < bi.Count; i++)
			{
				for (int j = 0; j < bi[i].prefs.Count; j++)
				{
					if (bi[i].prefs[j].ToLower() == name.ToLower())
					{
						bi[i].prefs.RemoveAt(j);
						break;
					}
				}
			}
		}

        //if a big has > 1 little slots this function will decrement the # of slots
        //otherwise functions as delBig
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

        //finds the index of a big with the given name in a provided list of bigs
        //returns -1 if not found
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

        //given a list of girl (ie. bigs/littles) prints out names
		private void printLists(List<girl> ls)
		{
			string names = "";
			for (int i = 0; i < ls.Count; i++)
			{
				names = names + " " + (ls[i].name);
			}
			System.Diagnostics.Debug.WriteLine(names);
		}

        //computes matches.
        //the juicy part of this program
        private void computeMatches()
        {
            //clear old results
            results = new List<pair>();
            errors = new List<girl>();
            //set temp lists
            copyLists(bigs, bigsTemp);
            copyLists(littles, littlesTemp);

            //variable to make sure we dont infinite loop if there are leftover bigs + littles
            int loopCounter = 0;
            //variable to keep track of if we changed anything during the iteration.
            bool changed = false;
            //while lists are not empty...
            while (bigsTemp.Count > 0 && littlesTemp.Count > 0)
            {
                //for each little...
                for (int i = 0; i < littlesTemp.Count; i++)
                {
                    //System.Diagnostics.Debug.WriteLine("littles[i].prefs.count " + littles[i].prefs.Count);
                    //if the little has preferences...
                    if (littlesTemp[i].prefs.Count > 0)
                    {
                        //find the big who is the first pick
                        int bigPos = findBig(littlesTemp[i].prefs[0], ref bigsTemp);
                        //System.Diagnostics.Debug.WriteLine("big, bigpos : " + littles[i].prefs[0] + ", " + bigPos);
                        //if big exists and has preferences...
                        if (bigPos != -1 && bigsTemp[bigPos].prefs.Count > 0)
                        {
                            //if bigs first pick is the little
                            if (bigsTemp[bigPos].prefs[0].ToLower() == littlesTemp[i].name.ToLower())
                            {
                                //match the pair
                                pair match = new pair();
                                match.big = bigsTemp[bigPos].name;
                                match.little = littlesTemp[i].name;
                                //System.Diagnostics.Debug.WriteLine("match found " + bigs[bigPos].name + " " + littles[i].name);
                                //decrement the big's little count (deletes if == 1)
                                decreaseBig(bigPos, ref littlesTemp, ref bigsTemp);
                                //delete the little
                                delLittle(littlesTemp[i].name, ref littlesTemp, ref bigsTemp);
                                //add the match to results
                                results.Add(match);
                                //note that we made a change
                                changed = true;
                                //decrement loop because we deleted a little. prevents out of bounds error
                                i--;
                            }
                        }
                    }
                }
                //if we havent changed increment loop counter
                if (!changed)
                {
                    loopCounter++;
                } // otherwise reset changed and counter
                else
                {
                    changed = false;
                    loopCounter = 0;
                } // if we've looped 3 times with no change program is stuck
                if (loopCounter > 3)
                {
                    //quit the loop
                    break;
                }
            }
            //for each leftover girl add to errors
            foreach (girl g in bigsTemp)
            {
                errors.Add(g);
            }
            foreach (girl g in littlesTemp)
            {
                errors.Add(g);
            }
            string message = "Success! " + results.Count + " Matches found! " + errors.Count + " people unaacounted for.";
            MessageBox.Show(message, "Done", MessageBoxButtons.OK);
            //printLists(errors);
        }

        //saves data to csv
        public void saveFile()
        {
            //open save file dialog
            SaveFileDialog sfg = new SaveFileDialog();
            //recommended name
            sfg.FileName = "MatchingResults.csv";
            //filetype
            sfg.Filter = "csv files (*.csv)|*.csv|All Files (*.*)|*.*";
            //use last directory windows remembers
            sfg.RestoreDirectory = true;
            //if they hit ok to save
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                //write file
                using (StreamWriter outfile = new StreamWriter(sfg.FileName))
                {
                    //header
                    outfile.WriteLine("Big,Little");
                    //print matches
                    for (int i = 0; i < results.Count; i++)
                    {
                        outfile.WriteLine(results[i].big + "," + results[i].little);
                    }
                    //blank line
                    outfile.WriteLine("");
                    //header for errors
                    outfile.WriteLine("Unmatched Girls,Big/Little");
                    //write errors
                    for (int i = 0; i < errors.Count; i++)
                    {
                        string str = errors[i].name;
                        if (errors[i].isBig)
                        {
                            str = str + "," + "Big";
                        }
                        else
                        {
                            str = str + "," + "Little";
                        }
                        outfile.WriteLine(str);
                    }
                }
            }
        }

        public string[] printMatches()
        {
            List<String> res = new List<string>();
            foreach(pair p in results)
            {
                res.Add(p.big + " and " + p.little);
            }
            return res.ToArray();
        }

        public string[] printErrors()
        {
            List<string> res = new List<string>();
            foreach(girl g in errors)
            {
                string buff = g.name;
                if(g.isBig)
                {
                    buff = buff + " " + "(Big)";
                } else
                {
                    buff = buff + " " + "(Little)";
                }
                res.Add(buff);
            }
            return res.ToArray();
        }

        //form methods
        public mainForm()
        {
            InitializeComponent();
            setParents();
        }

        private void manualInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.ShowDialog();
        }

        private void openCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void computeMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computeMatches();
        }

        private void bigsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ebf.populate();
            ebf.ShowDialog();
        }

        private void littlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elf.populate();
            elf.ShowDialog();
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void LoadCSV_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void manualInput_Click(object sender, EventArgs e)
        {
            input.ShowDialog();
        }

        private void editBigs_Click(object sender, EventArgs e)
        {
            ebf.populate();
            ebf.ShowDialog();
        }

        private void editLittles_Click(object sender, EventArgs e)
        {
            elf.populate();
            elf.ShowDialog();
        }

        private void match_Click(object sender, EventArgs e)
        {
            computeMatches();
        }

        private void export_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.ShowDialog();
        }

        private void viewMatches_Click(object sender, EventArgs e)
        {
            matches.ShowDialog();
        }

        private void viewMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matches.ShowDialog();
        }
    }
}
