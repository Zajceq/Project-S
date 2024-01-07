using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private CoinsManager _coinsManager;
    [SerializeField] private TextMeshProUGUI _coinsText;

    private void Update()
    {
        _coinsText.text = NumberFormatter.ToShortString(_coinsManager.CurrentCoins);
    }
}
