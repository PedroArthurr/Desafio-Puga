using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    [Header("Singleton")]
    public static CurrencyManager instance;
    public static CurrencyManager Instance { get { return instance; } }


    [Header("References")]
    public GameObject coinMesh;
    [SerializeField] AfterGameStatus afterGame;

    [Header("Settings")]
    public int maxCountForCurrencys;

    [Header("Behaviour")]
    public int inGameCurrencies;
    public int finalCurrencies;

    void Awake()
    {
        inGameCurrencies = 0;
        instance = this;
    }
    public void AddCurrency(int valueToAdd)
    {
        inGameCurrencies += valueToAdd;
    }
    public void TotalizeCurrencies()
    {
        finalCurrencies = inGameCurrencies;
        afterGame.totalGameCurrency += finalCurrencies;
        SaveGame();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("Currencies", afterGame.totalGameCurrency);
    }
    public void LoadGame()
    {
        finalCurrencies = PlayerPrefs.GetInt("Currencies");
    }
}
