using UnityEngine;
using UnityEngine.UI;

public class DisplayFuel : MonoBehaviour
{
    [SerializeField] private Image progressBar;

    private void Start()
    {
        Fuel.ChangeRegHandler(ChangeValue);
    }

    private void ChangeValue(float amount)
    {
        progressBar.fillAmount = amount;
    }
}
