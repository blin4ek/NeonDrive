using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Fuel : MonoBehaviour
{
    private static UnityEvent OutFuel = new UnityEvent();
    private static MyEventFloat Change = new MyEventFloat();

    private float amount = 1f;
    private float amountBonus = 0.2f;


    void Start()
    {
        StartCoroutine(Ñonsumption());
        BonusUp.RegHandler(Increase);
    }

    IEnumerator Ñonsumption()
    {
        while (amount > 0)
        {
            amount -= 0.015f;
            Change?.Invoke(amount);
            yield return new WaitForSeconds(0.3f);
        }
        OutFuel?.Invoke();
    }

    private void Increase()
    {
        amount = Mathf.Clamp(amount + amountBonus, 0, 1);
    }

    public static void OutFuelRegHandler(UnityAction handler)
    {
        OutFuel.AddListener(handler);
    }

    public static void ChangeRegHandler(UnityAction<float> handler)
    {
        Change.AddListener(handler);
    }
}

class MyEventFloat : UnityEvent<float>
{ }
