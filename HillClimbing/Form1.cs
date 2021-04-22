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
            panelTest.Visible = false;
            chart.MouseWheel += chart_MouseWheel;
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
            List<Individual> listVc;

            for (int i = 0; i < T; i++)
            {
                listVc = new List<Individual>();
                Vc = HC.MakeFirstInd(a, b, d, l, generator);
                listVc.Add(Vc.Clone());
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
                        listVc.Add(Vc.Clone());
                    }
                    else
                    {
                        break;
                    }
                }
                ListofListVc.Add(listVc);
                if (VBest.Fx < Vc.Fx)
                {
                    VBest = Vc.Clone();
                }
                ListVcBest.Add(VBest.Clone());
                if (VBest.Xreal == 10.999)
                {
                    break;
                }

            }
            individuals.Add(VBest);
            var bindingList = new BindingList<Individual>(individuals);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;
            ToTxt.WriteToFile(ListofListVc, T, d);
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
            Random rnd = new Random();

            if (Vc.Count > 1)
            {
                chartMaker.AxisX.Interval = 1;
            }
            if (Vc.Count > 40)
            {
                chartMaker.AxisX.Interval = 2;
            }
            if (Vc.Count > 99)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (Vc.Count > 100)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (Vc.Count > 500)
            {
                chartMaker.AxisX.Interval = 50;
            }
            if (Vc.Count > 999)
            {
                chartMaker.AxisX.Interval = 100;
            }
            if (Vc.Count > 1999)
            {
                chartMaker.AxisX.Interval = 200;
            }
            
            
           
            
            
           



            for (int i = 0; i < Vc.Count; i++)
            {
                chart.Series.Add("Vc" + i.ToString());
                if (Vc[i].Count > 1)
                {
                    chart.Series["Vc" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart.Series["Vc" + i.ToString()].BorderWidth = 3;
                }
                else
                {
                    chart.Series["Vc" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart.Series["Vc" + i.ToString()].MarkerSize = 10;
                }
                chart.Series["Vc" + i.ToString()].Color = Color.Green;
                chart.Series[i].IsVisibleInLegend = false;
            }
            chart.Series[0].IsVisibleInLegend = true;

            chart.Series.Add("Best");
            chart.Series["Best"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Best"].Color = Color.Red;
            chart.Series["Best"].BorderWidth = 1;

            for (int j = 0; j < Vc.Count; j++)
            {
                double point = 0;
                var part = (double)1 / Vc[j].Count;
                for (int i = 0; i < Vc[j].Count; i++)
                {
                    chart.Series["Vc" + j.ToString()].Points.AddXY(j + point, Vc[j][i].Fx);
                    chart.Series["Best"].Points.AddXY(j + point, Vbest[j].Fx);
                    point += part;

                }

            }
            chart.Series[0].Name = "Vc";
        }

        private void startTestBtn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));

            double pom = d;
            while (pom < 1)
            {
                round++;
                pom *= 10;
            }
            List<List<Individual>> ListofListVc = new List<List<Individual>>();
            List<Individual> ListVcBest = new List<Individual>();
            Individual Vc;
            Individual VBest = null;
            Individual Vn;
            List<Individual> listVc;
            List<Generation> listGen = new List<Generation>();

            for (int i = 0; i < 3000; i++)
            {
                Generation generation = new Generation
                {
                    Iteration = i + 1
                };
                listGen.Add(generation);
            }
            for (int j = 0; j < 10000; j++)
            {
                for (int i = 0; i < 3000; i++)
                {
                    listVc = new List<Individual>();
                    Vc = HC.MakeFirstInd(a, b, d, l, generator);
                    listVc.Add(Vc.Clone());
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
                            listVc.Add(Vc.Clone());
                        }
                        else
                        {
                            break;
                        }

                    }
                    ListofListVc.Add(listVc);
                    if (VBest.Fx < Vc.Fx)
                    {
                        VBest = Vc.Clone();
                    }
                    ListVcBest.Add(VBest.Clone());
                    if (VBest.Xreal == 10.999)
                    {
                        listGen[i].SolveCount += 1;
                        break;
                    }
                }
            }

            for (int i = 1; i < listGen.Count; i++)
            {
                listGen[i].Cumulation += listGen[i - 1].SolveCount + listGen[i - 1].Cumulation;
            }

            MakeTestChart(listGen);
            var bindingList = new BindingList<Generation>(listGen);
            var source = new BindingSource(bindingList, null);
            testTable.DataSource = source;
        }

        private void MakeTestChart(List<Generation> genList)
        {
            var chartMaker = testChart.ChartAreas[0];
            ChartArea CA = testChart.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = genList.Count;
            chartMaker.AxisY.Maximum = 100;
            chartMaker.AxisY.Interval = 10;
            chartMaker.AxisX.Interval = 100;
            testChart.Series[0].IsVisibleInLegend = false;

            if (testChart.Series.Count == 1)
            {
                testChart.Series.Add("expense");
            }
            else
            {
                testChart.Series["expense"].Points.Clear();
            }

            testChart.Series["expense"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            testChart.Series["expense"].Color = Color.Green;
            testChart.Series["expense"].BorderWidth = 1;

            for (int i = 0; i < genList.Count; i++)
            {
                testChart.Series["expense"].Points.AddXY(i, genList[i].Cumulation / 1000);
            }
        }

        private void algorithm_Click(object sender, EventArgs e)
        {
            panelTest.Visible = false;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            panelTest.Visible = true;
        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();

                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                }
            }
            catch { }
        }
    }
}

