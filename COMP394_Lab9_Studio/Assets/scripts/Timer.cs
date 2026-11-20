using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] public float time = 120f; // 2 minutes default
    public int gemsNeeded = 5;
    public int gemsCollected = 0;
   [SerializeField] private TMP_Text timerTxt;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;
    private bool gameOver = false;
    private void Start()
    {
        updateTime();
    }
    private void Update()
    {
        if (gameOver)
        {
            return;
        }
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0f;
            GameOver();
        }
        updateTime();
    }
    private void GameOver()
    {
        gameOver = true;
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    private void GameWon()
    {
        gameOver = true;
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void AddGems(int collect)
    {
        gemsCollected += collect;
        if (gemsCollected >= gemsNeeded)
        {
            GameWon();
        }
    }
    private void updateTime()
    {
        timerTxt.text = $"Time: {time:F0}";
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
