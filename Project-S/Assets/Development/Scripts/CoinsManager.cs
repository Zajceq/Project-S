using System;
using System.Collections;
using UnityEngine;

public class CoinsManager : Singleton<CoinsManager>
{
    [SerializeField] private double currentCoins;

    public double CurrentCoins {  get { return currentCoins; } }

    private void OnEnable()
    {
        StartCoroutine(UpdateCoins());
    }

    private IEnumerator UpdateCoins()
    {
        while (true)
        {
            currentCoins += CpSManager.Instance.CpsData.TotalCpS * Time.deltaTime;
            yield return null;
        }
    }

    public void AddCoins(double amount)
    {
        currentCoins += amount;
    }

    public void SubtractCoins(double amount)
    {
        currentCoins = Math.Max(0, currentCoins - amount);
    }

    public void MultiplyCoins(double multiplier)
    {
        currentCoins *= multiplier;
    }
}
