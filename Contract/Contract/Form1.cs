using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    public partial class Form1 : Form
    {
        Contract[] listaContracte = new Contract[50];
        int index = 0;
        double suma = 0;

        public Form1()
        {
            this.numericUpDownContracte = new NumericUpDown();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text != "" && textBoxDenumire.Text != "" && textBoxValoare.Text != "")
            {
                Contract temp = new Contract(Int32.Parse(textBoxCod.Text), textBoxDenumire.Text, double.Parse(textBoxValoare.Text));
                listaContracte[index] = temp;
                index++;

                MessageBox.Show("Contract adaugat.");
                this.numericUpDownContracte.Maximum = index;
                this.numericUpDownContracte.Value = index;
                textBoxCod.Text = null;
                textBoxDenumire.Text = null;
                textBoxValoare.Text = null;

                this.suma = suma + temp;
                textBoxSuma.Text = suma.ToString();
            }
            else {
                MessageBox.Show("Introduceti date in campurile contractului.");
            }
           
            
        }

        private void numericUpDownContracte_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDownContracte.Maximum = index;
            int value = Convert.ToInt32(numericUpDownContracte.Value) - 1;
            
            if (value >= 0)
            {
                textBoxCod.Text = listaContracte[value].getCod().ToString();
                textBoxDenumire.Text = listaContracte[value].getDenumire();
                textBoxValoare.Text = listaContracte[value].getValoare().ToString();
            }
            else {
                textBoxCod.Text = null;
                textBoxDenumire.Text = null;
                textBoxValoare.Text = null;
            }
        }

        private void numericUpDownContracte_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericUpDownContracte.Value < index)
            {
                numericUpDownContracte.Value++;
            }
            
        }

        private void numericUpDownContracte_KeyDown(object sender, KeyEventArgs e)
        {
            if (numericUpDownContracte.Value >= 0)
            {
                numericUpDownContracte.Value--;
            }
            Console.WriteLine("Down");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("E:\\Contracte.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            for (int i = 0; i < index; i++)
            {
                bf.Serialize(fileStream, listaContracte[i]);
            }

            fileStream.Close();
        }

        private void trasareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Grafic = new Form2(this.listaContracte, this.index);
            Grafic.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
