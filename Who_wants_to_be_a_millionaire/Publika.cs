using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_wants_to_be_a_millionaire
{
    public partial class Publika : Form
    {
        public Publika(int a, int b, int c, int d)
        {
            InitializeComponent();

            var odg = chart1.Series.Add("odg");
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            odg.Points.AddXY("A", a);
            odg.Points.AddXY("B", b);
            odg.Points.AddXY("C", c);
            odg.Points.AddXY("D", d);
            chart1.Series["odg"].IsValueShownAsLabel = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
