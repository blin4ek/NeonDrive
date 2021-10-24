using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class ColorBarrier : MonoBehaviour
{
    private Color[] colors = new Color[] { Color.red, Color.blue, Color.green, Color.cyan, Color.yellow, Color.magenta };

    [SerializeField] private SpriteRenderer[] spritesBariiers;
    [SerializeField] private Light2D[] lightBarriers;

    private static int numberColor = 0;
    private static float counter = 0;

    private Color tempColor = Color.red;

    private void Start()
    {
        foreach (var sprite in spritesBariiers)
        {
            sprite.color = Color.red;
        }
        foreach (var light in lightBarriers)
        {
            light.color = Color.red;
        }
    }

    private void OnEnable()
    {
        counter++;
        tempColor = Color.Lerp(tempColor, colors[numberColor], counter / 10f);
        if (counter == 10) { numberColor = Random.Range(0, 6); counter = 0; };
        foreach (var sprite in spritesBariiers)
        {
            sprite.color = tempColor;
        }
        foreach (var light in lightBarriers)
        {
            light.color = tempColor;
        }
    }

}