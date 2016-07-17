using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facemsoft4
{
    public partial class ScoreForm : Form
    {
        ArrayList scores = new ArrayList();
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("E:\\Projects\\C#\\facemsoft4\\Hangman.dat", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        scores.Add(s);
                    }
                }
            }
            if(scores.Count > 0)
            {
                foreach(string s in scores)
                {
                    ListViewItem itm = new ListViewItem(s.Split('|'));
                    listView1.Items.Add(itm);
                }
            }
        }
    }
}
