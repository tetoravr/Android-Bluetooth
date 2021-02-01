using UnityEngine;

namespace AwesomeCharts {
    public class LineChartController2 : MonoBehaviour {

        public LineChart chart;

        private void Start() {
            ConfigChart();
            //AddChartData();
        }

        private void ConfigChart() {

            chart.Config.ValueIndicatorSize = 17;

            chart.XAxis.DashedLine = true;
            chart.XAxis.LineThickness = 1;
            chart.XAxis.LabelColor = Color.white;
            chart.XAxis.LabelSize = 18;

            chart.YAxis.DashedLine = true;
            chart.YAxis.LineThickness = 1;
            chart.YAxis.LabelColor = Color.white;
            chart.YAxis.LabelSize = 16;
        }

        public void AddChartData(float suds) {

            chart.GetChartData().DataSets[0].AddEntry(new LineEntry(Time.realtimeSinceStartup, suds));
            chart.SetDirty();
        }
    }
}
