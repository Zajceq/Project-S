[System.Serializable]
public struct CpSData
{
    public double BaseCpS;
    public double Multiplier;

    public double TotalCpS => BaseCpS * Multiplier;

    public CpSData(double baseCpS, double multiplier)
    {
        this.BaseCpS = baseCpS;
        this.Multiplier = multiplier;
    }
}
