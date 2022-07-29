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

namespace Kursach
{
    public partial class Diagram : Form
    {
        private MainForm form;
        int maxRank;
        public Diagram(MainForm form,int maxRank)
        {
            InitializeComponent();
            this.form = form;
            this.maxRank = maxRank;
            Update();
        }

        private void  Update()
        {
            chart1.Series.Clear();
            for (int i = 0; i < form.factory.WorkShops.Count; i++)
                chart1.Series.Add(form.factory.WorkShops[i].Number);
            
            double[] avg = this.form.factory.WorkShops[0].AverageSalaryForRank();
            for (int i = 0; i < form.factory.WorkShops.Count; i++)
                chart1.Series[form.factory.WorkShops[i].Number].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            for (int i = 0; i < form.factory.WorkShops.Count; i++)
            {
                avg = this.form.factory.WorkShops[i].AverageSalaryForRank();
                for (int j = 0; j < 10; j++)
                {
                    chart1.Series[form.factory.WorkShops[i].Number].Points.AddXY(j+1, avg[j]);
                }
            }
        }

        private void Diagram_Load(object sender, EventArgs e)
        {
            Axis ax = new Axis();
            ax.Title = "Разряд";
            chart1.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Зарплата";
            chart1.ChartAreas[0].AxisY = ay;
        }
    }
}
