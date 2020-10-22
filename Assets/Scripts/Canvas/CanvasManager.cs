using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class CanvasManager : MonoBehaviour
{
    [Header("Singleton")]
    public static CanvasManager instance;
    public static CanvasManager Instance { get { return instance; } }

    [Header("References")]
    [SerializeField] AfterGameStatus afterGame;
    [SerializeField] GameObject gameOverPanel;
    public GameObject ship;
    [Header("User Interface Elements")]
    [SerializeField] TextMeshProUGUI shipHealth_UI;
    [SerializeField] TextMeshProUGUI totalCurrencies_UI;
    [SerializeField] TextMeshProUGUI timer_UI;
    [SerializeField] TextMeshProUGUI gameOverCurrencies_UI;

    void Start()
    {
        ShrinkGameOverPanel();
    }
    void Update()
    {
        UpdateHealthUI();
        UpdateCurrenciesUI();
        UpdateTimerUI();
    }

    void UpdateHealthUI()
    {
        shipHealth_UI.text = ship.GetComponent<ShipController>().allStatus[ship.GetComponent<ShipController>().healthLevel - 1].health.ToString();
    }
    void UpdateCurrenciesUI()
    {
        totalCurrencies_UI.text = CurrencyManager.Instance.inGameCurrencies.ToString();
    }
    void UpdateTimerUI()
    {
        timer_UI.text = GameManager.Instance.time.ToString("#");
    }
    public void UpdateFinalScreenCurrencies()
    {
        gameOverCurrencies_UI.text = "Total of $ collected: " + CurrencyManager.instance.inGameCurrencies.ToString();
    }
    public void ExpandGameOverPanel()
    {
        gameOverPanel.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }
    public void ShrinkGameOverPanel()
    {
        gameOverPanel.transform.localScale = Vector3.zero;
    }



}
