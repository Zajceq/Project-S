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
        cpsText.text = itemSO.CpsIncrease.ToString();
        amountToBuyText.text = "IN PROGRESS";
        costText.text = "IN PROGRESS";
    }
}
