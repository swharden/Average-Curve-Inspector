namespace gainapp;

public partial class Form1 : Form
{
    readonly CurveManager CM = new(10);

    public Form1()
    {
        InitializeComponent();

        trackBar1.ValueChanged += (s, e) => UpdateCurves();
        numericUpDown1.ValueChanged += (s, e) => UpdateCurves();
        button1.Click += (s, e) => { CM.Randomize(); UpdateCurves(); };

        UpdateCurves();
    }

    private void UpdateCurves()
    {
        formsPlot2.Plot.Clear();
        double alignment = (double)trackBar1.Value / trackBar1.Maximum;
        for (int i = 0; i < numericUpDown1.Value; i++)
        {
            formsPlot2.Plot.AddSignal(CM.GetCurve(i, alignment));
        }
        formsPlot2.Refresh();
    }
}
