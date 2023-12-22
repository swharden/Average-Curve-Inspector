using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace gainapp;

public class CurveManager
{
    readonly Random Rand = new();
    readonly double[] HorizontalOffset; // values from -1 to +1
    readonly double[] VerticalOffset; // values from -1 to +1
    public readonly double[] Xs = ScottPlot.Generate.Consecutive(100);

    public CurveManager(int count)
    {
        HorizontalOffset = new double[count];
        VerticalOffset = new double[count];
        Randomize();
    }

    public void Randomize()
    {
        for (int i = 0; i < HorizontalOffset.Length; ++i)
        {
            HorizontalOffset[i] = Rand.NextDouble() * 2 - 1;
            VerticalOffset[i] = Rand.NextDouble() * 2 - 1;
        }
    }

    public double[] GetCurve(int index, double alignmentVariance, double heightVariance)
    {
        double[] bell = ScottPlot.DataGen.Ones(40);
        FftSharp.Windows.Blackman window = new();
        window.ApplyInPlace(bell);

        double[] curve = new double[Xs.Length];
        int offsetIndex = curve.Length / 2 - bell.Length / 2;
        offsetIndex += (int)(alignmentVariance * bell.Length * HorizontalOffset[index]);

        double heightMultiplier = 1 + heightVariance * VerticalOffset[index];

        for (int i = 0; i < bell.Length; i++)
        {
            int destIndex = offsetIndex + i;
            if (destIndex >= 0 && destIndex < curve.Length)
            {
                curve[destIndex] = bell[i] * heightMultiplier;
            }
        }

        return curve;
    }
}
