using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item", order = 1)]
public class ItemSO : ScriptableObject
{
    public Sprite ItemSprite;
    public string ItemName;
    public string Description;
    public float CpsIncrease;
    public int Level;
    public float BaseUpgradeCost;

    private float? upgradeCostCache = null;
    private float? currentCPSCache = null;

    public float GetUpgradeCost()
    {
        if (!upgradeCostCache.HasValue)
        {
            upgradeCostCache = BaseUpgradeCost * Mathf.Pow(1.07f, Level); //random value, WIP
        }
        return upgradeCostCache.Value;
    }

    public float GetCurrentCPS()
    {
        if (!currentCPSCache.HasValue)
        {
            currentCPSCache = CpsIncrease * Level;
        }
        return currentCPSCache.Value;
    }

    public void ResetCache()
    {
        upgradeCostCache = null;
        currentCPSCache = null;
    }

    public void UpgradeItem()
    {
        Level++;
        ResetCache();
    }
}