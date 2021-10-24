using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    private Text textScore;

    void Start()
    {
        textScore = GetComponent<Text>();
        ScoreCounter.RegHandler(OnIncreaseScore);
        GameOverEvent.RegHandler(() => textScore.gameObject.SetActive(false));
    }

    private void OnIncreaseScore(int score)
    {
        textScore.text = score.ToString();
    }
}