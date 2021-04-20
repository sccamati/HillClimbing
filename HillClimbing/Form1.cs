using HillClimbing.classes;
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

namespace HillClimbing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            int T = Convert.ToInt32(Tbox.Text);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));

            double pom = d;
            while (pom < 1)
            {
                round++;
                pom *= 10;
            }
            List<Individual> individuals = new List<Individual>();
            List<List<Individual>> ListofListVc = new List<List<Individual>>();
            List<Individual> ListVcBest = new List<Individual>();
            Individual Vc;
            Individual VBest = null;
            Individual Vn;

            bool local;
            List<Individual> listVc;

            for (int i = 0; i < T; i++)
            {
                listVc = new List<Individual>();
                Vc = HC.MakeFirstInd(a, b, d, l, generator);
                if (i == 0)
                {
                    VBest = Vc.Clone();
                }
                while (true)
                {
                    Vn = HC.MakeVn(Vc, a, b, l, round);
                    if (Vn.Fx > Vc.Fx)
                    {
                        Vc = Vn.Clone();
                    }
                    else
                    {
                        break;
                    }
                    listVc.Add(Vc.Clone());
                }
                ListofListVc.Add(listVc);
                if(VBest.Fx < Vc.Fx)
                {
                    VBest = Vc.Clone();
                }
                ListVcBest.Add(VBest.Clone());
            }
            individuals.Add(VBest);
            var bindingList = new BindingList<Individual>(individuals);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;

            MakeChart(ListofListVc, ListVcBest);
        }

        private void MakeChart(List<List<Individual>> Vc, List<Individual> Vbest)
        {
            chart.Series.Clear();
            var chartMaker = chart.ChartAreas[0];
            ChartArea CA = chart.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = Vc.Count;
            chartMaker.AxisX.Interval = (double)1 /Vc.Max(vc => vc.Count);
              Random rnd = new Random();


                for (int i = 0; i < Vc.Count; i++)
                {
                    chart.Series.Add("Vc" + i.ToString());
                if(Vc[i].Count > 1)
                {
                    chart.Series["Vc" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                else
                {
                    chart.Series["Vc" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                }
                    
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    chart.Series["Vc" + i.ToString()].Color = randomColor;
                    chart.Series["Vc" + i.ToString()].BorderWidth = 4;
                }
                chart.Series.Add("Best");
                chart.Series["Best"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series["Best"].Color = Color.Red;
                chart.Series["Best"].BorderWidth = 1;
            


            for (int j = 0; j < Vc.Count; j++)
            {
                double point = 0;
                var part = (double)1 /Vc[j].Count;
                for (int i = 0; i < Vc[j].Count; i++)
                {
                    chart.Series["Vc" + j.ToString()].Points.AddXY(j + point, Vc[j][i].Fx);
                    chart.Series["Best"].Points.AddXY(j + point, Vbest[j].Fx);
                    point += part;

                }
                
            }


        }


    }
}

