namespace gainapp;

public partial class Form1 : Form
{
    readonly CurveManager CM;

    public Form1()
    {
        InitializeComponent();

        CM = new CurveManager((int)numericUpDown1.Maximum);
        tbHorizontal.ValueChanged += (s, e) => UpdateCurves();
        tbVertical.ValueChanged += (s, e) => UpdateCurves();
        numericUpDown1.ValueChanged += (s, e) => UpdateCurves();
        button1.Click += (s, e) => { CM.Randomize(); UpdateCurves(); };

        UpdateCurves();
    }

    private void UpdateCurves()
    {
        formsPlot1.Plot.Clear();
        formsPlot2.Plot.Clear();

        int curveCount = (int)numericUpDown1.Value;

        double alignmentVariance = (double)tbHorizontal.Value / tbHorizontal.Maximum;
        double heightVariance = (double)tbVertical.Value / tbVertical.Maximum;

        List<double[]> curves = [];
        for (int i = 0; i < curveCount; i++)
        {
            double[] curve = CM.GetCurve(i, alignmentVariance, heightVariance);
            formsPlot2.Plot.AddScatterLines(CM.Xs, curve, lineWidth: 2);
            curves.Add(curve);
        }

        double[] yMean = new double[CM.Xs.Length];
        double[] yErr = new double[CM.Xs.Length];
        for (int i = 0; i < CM.Xs.Length; i++)
        {
            double[] points = curves.Select(x => x[i]).ToArray();
            yMean[i] = ScottPlot.Statistics.Descriptive.Mean(points);
            yErr[i] = ScottPlot.Statistics.Descriptive.StDev(points) / Math.Sqrt(points.Length);
        }
        var eb = formsPlot1.Plot.AddErrorBars(CM.Xs, yMean, null, yErr, color: Color.Black);
        eb.CapSize = 2;
        formsPlot1.Plot.AddScatter(CM.Xs, yMean, color: Color.Black);

        formsPlot1.Plot.SetAxisLimitsY(0, 1.5);
        formsPlot2.Plot.SetAxisLimitsY(0, 1.5);

        formsPlot1.Refresh();
        formsPlot2.Refresh();
    }
}
