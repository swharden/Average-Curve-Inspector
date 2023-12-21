using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace gainapp;

public class CurveManager
{
    readonly Random Rand = new();
    readonly double[] CurveOffsetFractions; // values from -1 to +1

    public CurveManager(int count)
    {
        CurveOffsetFractions = new double[count];
        Randomize();
    }

    public void Randomize()
    {
        for (int i = 0; i < CurveOffsetFractions.Length; ++i)
        {
            CurveOffsetFractions[i] = Rand.NextDouble() * 2 - 1;
        }
    }

    public double[] GetCurve(int index, double alignment)
    {
        double variance = 1 - alignment;

        double[] bell = ScottPlot.DataGen.Ones(40);
        FftSharp.Windows.Blackman window = new();
        window.ApplyInPlace(bell);

        double[] curve = new double[100];
        int offsetIndex = curve.Length / 2 - bell.Length / 2;
        offsetIndex += (int)(variance * bell.Length * CurveOffsetFractions[index]);

        for (int i = 0; i < bell.Length; i++)
        {
            int destIndex = offsetIndex + i;
            if (destIndex >= 0 && destIndex < curve.Length)
            {
                curve[destIndex] = bell[i];
            }
        }

        return curve;
    }
}
