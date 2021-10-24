using UnityEngine;

public class CabCrash : CarCrash
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9 || collision.gameObject.layer == 8) Crash?.Invoke();
    }
}
