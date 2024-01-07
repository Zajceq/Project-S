using UnityEngine;

public class CpSManager : MonoBehaviour
{
    [SerializeField] private CpSData _cpsData;

    public CpSData CpsData {  get { return _cpsData; }}

    public void IncreaseMultiplier(double amount)
    {
        _cpsData.Multiplier += amount;
    }

    public void UpdateBaseCpS(double newBaseCpS)
    {
        _cpsData.BaseCpS = newBaseCpS;
    }
}
