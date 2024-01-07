using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private CoinsManager coinsManager;

    public void BuyUpgrade(double cost)
    {
        if (coinsManager.CurrentCoins >= cost)
        {
            coinsManager.SubtractCoins(cost);
            // Upgrade logic
        }
        else
        {
            Debug.Log("Unable to Buy");
        }
    }

    public void EarnBonusCoins(double bonusAmount)
    {
        coinsManager.AddCoins(bonusAmount);
    }
}
