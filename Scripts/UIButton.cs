using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{
    public void Restart()
    {
        ADS.ShowAds();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Standart()
    {
        SceneManager.LoadScene(1);
    }

    public void Survival()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitToMainMenu()
    {
        ADS.ShowAds();
        SceneManager.LoadScene(0);   
    }
}