using System;
using System.Collections;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    [SerializeField] private double _currentCoins;
    [SerializeField] private CpSManager _cpsManager;

    public double CurrentCoins {  get { return _currentCoins; } }

    private void OnEnable()
    {
        StartCoroutine(UpdateCoins());
    }

    private IEnumerator UpdateCoins()
    {
        while (true)
        {
            _currentCoins += _cpsManager.CpsData.TotalCpS * Time.deltaTime;
            yield return null;
        }
    }

    public void AddCoins(double amount)
    {
        _currentCoins += amount;
    }

    public void SubtractCoins(double amount)
    {
        _currentCoins = Math.Max(0, _currentCoins - amount);
    }

    public void MultiplyCoins(double multiplier)
    {
        _currentCoins *= multiplier;
    }
}
