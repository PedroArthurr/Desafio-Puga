using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [Header("Singleton")]
    public static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    [Header("References")]
    public Transform pivotToRestart;
    public GameObject ship;

    [Header("Behaviour")]
    [HideInInspector] public float gameTime = 1; //Tempo
    [HideInInspector] public bool endGame;



    [Header("Game Countdown")]
    [SerializeField] float matchTime;
    [HideInInspector] public float time;


    void Awake()
    {
        instance = this;
        time = matchTime;
    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            EndGame();
        }

        if (Input.GetButton("Cancel") && endGame)
            RestartGame();
    }


    public void EndGame()
    {
        if (!endGame)
        {
            CurrencyManager.instance.TotalizeCurrencies();
        }
        endGame = true;
        GetComponentInParent<CanvasManager>().UpdateFinalScreenCurrencies();

        SpawnManager.Instance.spawnAble = false;
        gameTime = 0;

        if (ship.GetComponent<ShipController>().allStatus[ship.GetComponent<ShipController>().healthLevel - 1].health > 0)
        {
            Won();
        }
        else
        {
            Lost();
        }
        GetComponentInParent<CanvasManager>().ExpandGameOverPanel();
    }

    public void Won()
    {

    }
    public void Lost()
    {

    }

    public void RestartGame()
    {
        DestroAllEnemies();
        endGame = false;
        GetComponentInParent<CanvasManager>().ShrinkGameOverPanel();
        ship.transform.position = new Vector3(pivotToRestart.position.x, ship.transform.position.y, pivotToRestart.position.z);
        ship.GetComponent<ShipController>().allStatus[ship.GetComponent<ShipController>().healthLevel - 1].health = 100;
        ship.GetComponent<ShipController>().EnebleMesh(true);
        // SpawnManager.Instance.DestroyerAllEnemy();
        SpawnManager.Instance.spawnAble = true;
        CurrencyManager.instance.inGameCurrencies = 0;
        gameTime = 1;
        time = matchTime;
    }
    public void Home()
    {
        GetComponentInParent<CanvasManager>().ShrinkGameOverPanel();
    }
    void DestroAllEnemies()
    {
        GameObject[] remainingEnemies;
        remainingEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject go in remainingEnemies)
        {
            Destroy(go);
        }
    }


}
