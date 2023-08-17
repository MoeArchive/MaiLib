namespace MaiLib;

/// <summary>
///     Construct a collection to store charts in relate of SD and DX.
/// </summary>
public abstract class ChartPack : Chart, IChart
{
    /// <summary>
    ///     Stores shared information
    /// </summary>
    private TrackInformation? globalInformation;

    /// <summary>
    ///     Stores SD and DX chart
    ///     [0] SD [1] DX
    /// </summary>
    private List<Chart>[] sddxCharts;

    /// <summary>
    ///     Default constructor
    /// </summary>
    public ChartPack()
    {
        sddxCharts = new List<Chart>[2];
    }

    /// <summary>
    ///     Accesses this.sddxCharts
    /// </summary>
    /// <value>this.sddxCharts</value>
    public List<Chart>[] SDDXCharts
    {
        get => sddxCharts;
        set => sddxCharts = value;
    }

    /// <summary>
    ///     Accesses this.globalInformation
    /// </summary>
    /// <value>this.globalInformation</value>
    public TrackInformation? GlobalInformation
    {
        get => globalInformation;
        set => globalInformation = value;
    }

    // public abstract bool CheckValidity();

    public override string Compose()
    {
        throw new NotImplementedException();
    }

    // public abstract void Update();
}