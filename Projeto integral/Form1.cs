using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title ="Função",
                    Values = new ChartValues<double>()
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                    Title = "X",
                    Labels = new string[] {}
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "f(x)"
            });
        }
    }
}
