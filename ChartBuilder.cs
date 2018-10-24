using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace Profiling
{
    internal class ChartBuilder : IChartBuilder
    {
        public Control Build(List<ExperimentResult> result, string title)
        {
            var control = new ZedGraphControl();
            // generate some fake data
            var classResults = result.Select(x => x.ClassResult).ToArray();
            var structResults = result.Select(x => x.StructResult).ToArray();
            var sizes = result.Select(x => x.Size.ToString()).ToArray();

            //generate pane
            var pane = control.GraphPane;
            pane.Title.Text = title;

            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.Title.Text = "Размер массива";
            pane.YAxis.Title.Text = "Время выполнения";

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            pane.XAxis.Scale.TextLabels = sizes;
            pane.XAxis.Type = AxisType.Text;


            //var pointsCurve;

            var pointsCurve = pane.AddCurve("Ссылочный тип данных", null, classResults, Color.Black);
            pointsCurve.Line.IsVisible = true;
            pointsCurve.Line.Width = 3.0F;
            //Create your own scale of colors.

            pointsCurve.Symbol.Fill = new Fill(new[] {Color.Blue, Color.Green, Color.Red});
            pointsCurve.Symbol.Fill.Type = FillType.Solid;
            pointsCurve.Symbol.Type = SymbolType.Circle;
            pointsCurve.Symbol.Border.IsVisible = true;

            var pointsCurve2 = pane.AddCurve("Значимый тип данных", null, structResults, Color.Yellow);
            pointsCurve2.Line.IsVisible = true;
            pointsCurve2.Line.Width = 3.0F;
            //Create your own scale of colors.

            pointsCurve2.Symbol.Fill = new Fill(new[] {Color.Blue, Color.Green, Color.Red});
            pointsCurve2.Symbol.Fill.Type = FillType.Solid;
            pointsCurve2.Symbol.Type = SymbolType.Circle;
            pointsCurve2.Symbol.Border.IsVisible = true;

            pane.AxisChange();
            control.Refresh();
            return control;
        }
    }
}