using UnityEngine;
using TMPro;

public class CpSUI : MonoBehaviour
{
    [SerializeField] private CpSManager _cpsManager;
    [SerializeField] private TextMeshProUGUI _cpsText;

    private void Update()
    {
        _cpsText.text = NumberFormatter.ToShortString(_cpsManager.CpsData.TotalCpS) + "/s";
    }
}
