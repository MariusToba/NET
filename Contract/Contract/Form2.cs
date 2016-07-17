using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Contract
{
    public partial class Form2 : Form
    {
        Contract[] listaContracte = new Contract[50];
        int index;

        public Form2(Contract[] listaC, int index)
        {
            this.listaContracte = listaC;
            this.index = index;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (index > 0)
            {
                chart1.ChartAreas.Add("area");
                chart1.ChartAreas["area"].AxisX.Minimum = 0;
                chart1.ChartAreas["area"].AxisX.Maximum = index;
                chart1.ChartAreas["area"].AxisX.Interval = 1;
                chart1.ChartAreas["area"].AxisY.Minimum = 0;
                chart1.ChartAreas["area"].AxisY.Interval = 100;

                chart1.Series.Add("Contracte");
                chart1.Series.Add("Suma");
                chart1.ChartAreas["area"].AxisY.Title = "Suma";
                chart1.ChartAreas["area"].AxisX.Title = "Contract";

                chart1.Series["Contracte"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Suma"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                
                


                for (int i = 0; i < index; i++)
                {
                    chart1.Series[0].Points.AddXY(i, listaContracte[i].getValoare());
                }               
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
