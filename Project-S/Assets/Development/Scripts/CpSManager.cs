using UnityEngine;

public class CpSManager : Singleton<CpSManager>
{
    [SerializeField] private CpSData _cpsData;

    public CpSData CpsData {  get { return _cpsData; }}

    public void IncreaseMultiplier(double multiplayerAmount)
    {
        _cpsData.Multiplier += multiplayerAmount;
    }

    public void UpdateBaseCpS(double CpSAmount)
    {
        _cpsData.BaseCpS += CpSAmount;
    }
}
