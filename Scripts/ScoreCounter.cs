using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    private int recordStandart;
    private int recordSurvival;

    private static MyEventint ScoreChange = new MyEventint();

    void Start()
    {
        score = 0;
        recordStandart = PlayerPrefs.GetInt(PlayerPrefsKeys.RECORD_STANDART, 0);
        recordSurvival = PlayerPrefs.GetInt(PlayerPrefsKeys.RECORD_SURVIVAL, 0);

        CarBreakingBarrier.RegHandler(IncreaseScore);  
        GameOverEvent.RegHandler(Save);
    }

    public static void RegHandler(UnityAction<int> handler)
    {
        ScoreChange.AddListener(handler);
    }

    private void OnDestroy()
    {
        ScoreChange.RemoveAllListeners();
    }

    private void IncreaseScore()
    {
        ScoreChange?.Invoke(++score);
    }

    private void Save()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1: if (score > recordStandart) PlayerPrefs.SetInt(PlayerPrefsKeys.RECORD_STANDART, score); break;
            case 2: if (score > recordSurvival) PlayerPrefs.SetInt(PlayerPrefsKeys.RECORD_SURVIVAL, score); break;
        }
    }
}

class MyEventint : UnityEvent<int>
{ }