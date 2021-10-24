using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text recordText;

    private int score;

    void Start()
    {
        gameOverPanel.SetActive(false);
        GameOverEvent.RegHandler(GameOver);
        CarBreakingBarrier.RegHandler(() => score++);
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.text += "\n" + score;
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1: recordText.text += "\n" + PlayerPrefs.GetInt(PlayerPrefsKeys.RECORD_STANDART, 0); break;
            case 2: recordText.text += "\n" + PlayerPrefs.GetInt(PlayerPrefsKeys.RECORD_SURVIVAL, 0); break;
        }
    }
}