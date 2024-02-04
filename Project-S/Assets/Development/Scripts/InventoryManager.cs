using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField] private CoinsManager coinsManager;
    [SerializeField] private Canvas inventoryCanvas;
    [SerializeField] private List<ItemSO> availableItems;

    [SerializeField] private GameObject inventoryUpgradePrefab;
    [SerializeField] private Transform upgradesParent;


    public void BuyItem(ItemSO item)
    {
        var cost = item.GetUpgradeCost();
        if (coinsManager.CurrentCoins >= cost)
        {
            coinsManager.SubtractCoins(cost);
            item.UpgradeItem();
            UpdateUI();
        }
        else
        {
            Debug.Log("Unable to Buy");
        }
    }

    public void UnlockItem(ItemSO item)
    {
        item.IsUnlocked = true;
        availableItems.Add(item);
        UpdateUI();
    }

    public void UpdateUI()
    {
        foreach (Transform child in upgradesParent)
        {
            Destroy(child.gameObject);
        }

        foreach (ItemSO item in availableItems)
        {
            var itemUI = Instantiate(inventoryUpgradePrefab, upgradesParent);
            var equipmentUpgrade = itemUI.GetComponent<InventoryUpgrade>();
            if (equipmentUpgrade != null)
            {
                equipmentUpgrade.ItemSO = item;
                equipmentUpgrade.UpdateData();
            }
        }
    }

    public void ToggleCanvasVisibility()
    {
        inventoryCanvas.gameObject.SetActive(!inventoryCanvas.gameObject.activeSelf);
    }
}