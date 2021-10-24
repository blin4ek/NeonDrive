using UnityEngine;

public class BodyCrash : CarCrash
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9) Crash?.Invoke();
    }
}