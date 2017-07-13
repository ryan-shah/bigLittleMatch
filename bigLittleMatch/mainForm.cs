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
        public string first;
        public string second;
    }

    public partial class mainForm : Form
    {
        public Dictionary<string, List<string>> bigs = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> littles = new Dictionary<string, List<string>>();
        public List<pair> results = new List<pair>();

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
                bigs = new Dictionary<string, List<string>>();
                littles = new Dictionary<string, List<string>>();
                StreamReader SR = new StreamReader(file.FileName);
                while(!SR.EndOfStream)
                {
                    var line = SR.ReadLine();
                    var values = line.Split(',');
                    if (values.Length >= 3)
                    {
                        List<string> prefs = new List<string>();
                        for(int i = 2; i < values.Length; i++)
                        {
                            prefs.Add(values[i].ToLower());
                        }
                        if(values[0] == "big")
                        {
                            bigs.Add(values[1].ToLower(), prefs);
                        } else if(values[0] == "little")
                        {
                            littles.Add(values[1].ToLower(), prefs);
                        }
                    }
                }
            }
        }

        private void del(string name)
        {
            foreach(var pair in bigs)
            {
                if(pair.Key.ToLower() == name.ToLower())
                {
                    bigs.Remove(pair.Key);
                    break;
                }
                for(int i =0; i < pair.Value.Count; i++)
                {
                    if(pair.Value[i].ToLower() == name.ToLower())
                    {
                        pair.Value.RemoveAt(i);
                        break;
                    }
                }
            }
            foreach (var pair in littles)
            {
                if (pair.Key.ToLower() == name.ToLower())
                {
                    littles.Remove(pair.Key);
                    break;
                }
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    if (pair.Value[i].ToLower() == name.ToLower())
                    {
                        pair.Value.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void computeMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (bigs.Count > 0 && littles.Count > 0) {
                List<string> ToRemove = new List<string>();
                foreach (var pair in bigs)
                {
                    bool toBreak = false;
                    for (int i = 0; i < pair.Value.Count; i++)
                    {
                        if (littles.ContainsKey(pair.Value[i]))
                        {
                            if (littles[pair.Value[i]][0].ToLower() == pair.Key.ToLower())
                            {
                                pair p;
                                p.first = pair.Key;
                                p.second = pair.Value[i];
                                results.Add(p);
                                System.Diagnostics.Debug.WriteLine("pair of " + p.first + " " + p.second);
                                ToRemove.Add(p.first);
                                ToRemove.Add(p.second);
                                toBreak = true;
                                break;
                            }
                        }
                    }
                    if(toBreak)
                    {
                        break;
                    }
                }
                for(int i = 0; i < ToRemove.Count; i++)
                {
                    del(ToRemove[i]);
                }
            }
            List<string> bs = new List<string>();
            List<string> ls = new List<string>();
            foreach(var p in results)
            {
                bs.Add(p.first);
                ls.Add(p.second);
            }
            bigsBox.Lines = bs.ToArray();
            littleBox.Lines = ls.ToArray();
        }
    }
}
