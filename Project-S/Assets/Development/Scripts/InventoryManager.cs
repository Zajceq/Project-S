using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : Singleton<InventoryManager>
{
    public List<ItemSO> availableItems;

    public void BuyItem(ItemSO item)
    {
        item.UpgradeItem();
    }

    public void UnlockItem(ItemSO item)
    {

    }

    public void UpdateUI()
    {

    }
}