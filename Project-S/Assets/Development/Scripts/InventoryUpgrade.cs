using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUpgrade : MonoBehaviour
{
    [SerializeField] private ItemSO itemSO;

    [Header("Data")]
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI cpsText;
    [SerializeField] private TextMeshProUGUI amountToBuyText;
    [SerializeField] private TextMeshProUGUI costText;

    public ItemSO ItemSO
    {
        get { return itemSO; }
        set { itemSO = value; }
    }

    private void Start()
    {
        if (itemSO != null) 
        { 
            UpdateData();
        }
    }

    public void UpdateData()
    {
        image.sprite = itemSO.ItemSprite;
        levelText.text = itemSO.ItemLevel.ToString();
        nameText.text = itemSO.ItemName.ToString();
        cpsText.text = NumberFormatter.ToShortString(itemSO.CpsIncrease);
        amountToBuyText.text = "Buy" + "1";
        costText.text = NumberFormatter.ToShortString(itemSO.GetUpgradeCost());
    }

    public void BuyItem()
    {
        var cost = itemSO.GetUpgradeCost();

        if (CoinsManager.Instance.CurrentCoins >= cost)
        {
            CoinsManager.Instance.SubtractCoins(cost);
            CpSManager.Instance.UpdateBaseCpS(itemSO.CpsIncrease);
            itemSO.UpgradeItem();
            UpdateData();
            InventoryManager.Instance.UpdateUI();
        }
        else
        {
            Debug.Log("Unable to Buy");
        }
    }

    public void UnlockItem(ItemSO item)
    {
        item.IsUnlocked = true;
        InventoryManager.Instance.AddItemToList(item);
        InventoryManager.Instance.UpdateUI();
    }
}
