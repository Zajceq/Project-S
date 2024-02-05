using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField] private Canvas inventoryCanvas;
    [SerializeField] private List<ItemSO> availableItems;

    [SerializeField] private GameObject inventoryUpgradePrefab;
    [SerializeField] private Transform upgradesParent;

#if UNITY_EDITOR
    private void Awake()
    {
        ResetUpgrades();
    }

    private void ResetUpgrades()
    {
        foreach (ItemSO item in availableItems)
        {
            item.ItemLevel = 0;
        }
        UpdateUI();
    }
#endif

    private void Start()
    {
        UpdateUI();
    }


    public void AddItemToList(ItemSO item)
    {
        if (!availableItems.Contains(item))
        {
            availableItems.Add(item);
        }
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
            var inventoryUpgrade = itemUI.GetComponent<InventoryUpgrade>();
            if (inventoryUpgrade != null)
            {
                inventoryUpgrade.ItemSO = item;
                inventoryUpgrade.UpdateData();
            }
        }
    }

    public void ToggleCanvasVisibility()
    {
        inventoryCanvas.gameObject.SetActive(!inventoryCanvas.gameObject.activeSelf);
    }
}