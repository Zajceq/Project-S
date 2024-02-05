using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item", order = 1)]
public class ItemSO : ScriptableObject
{
    public Sprite ItemSprite;
    public string ItemName;
    public double CpsIncrease;
    public int ItemLevel;
    public double BaseUpgradeCost;
    public bool IsUnlocked = false;

    private double? upgradeCostCache = null;
    private double? currentCPSCache = null;

    public double GetUpgradeCost()
    {
        if (!upgradeCostCache.HasValue)
        {
            upgradeCostCache = BaseUpgradeCost * Mathf.Pow(1.07f, ItemLevel); //random value, WIP
        }
        Debug.Log("upgradeCostCache: " + upgradeCostCache.Value);
        return upgradeCostCache.Value;
    }

    public double GetCurrentCPS()
    {
        if (!currentCPSCache.HasValue)
        {
            currentCPSCache = CpsIncrease * ItemLevel;
        }
        Debug.Log("currentCPSCache: " + currentCPSCache.Value);
        return currentCPSCache.Value;
    }

    public void ResetCache()
    {
        upgradeCostCache = null;
        currentCPSCache = null;
    }

    public void UpgradeItem()
    {
        ItemLevel++;
        ResetCache();
    }
}