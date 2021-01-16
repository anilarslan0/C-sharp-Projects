using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Map_with_Live_Chart_Geo_Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary["TR"] = 100;
            dictionary["RU"] = 50;
            dictionary["US"] = 80;
            dictionary["CF"] = 70;
            dictionary["AM"] = 20;
            dictionary["AF"] = 10;
            geomap.HeatMap = dictionary;
            geomap.Source = $"{Application.StartupPath}\\MAP.xml";
            this.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;

        }
    }
}
