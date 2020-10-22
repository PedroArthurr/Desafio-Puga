
using UnityEngine;
using TMPro;

public class HomeCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI totalCurrencies;
    [SerializeField] AfterGameStatus afterGame;
    void Start()
    {
        afterGame.totalGameCurrency = PlayerPrefs.GetInt("Currencies");
        totalCurrencies.text = "Total amount of $ collected in game:\n" + afterGame.totalGameCurrency.ToString();
    }

}
