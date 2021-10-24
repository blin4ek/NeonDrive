using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    [SerializeField] private Text[] chars;

    private byte tempValue;
    private Color32 startColor;

    void Start()
    {
        StartCoroutine(Flick());
    }

    IEnumerator Flick()
    {
        startColor = chars[2].color;
        while (true)
        {
            int numberChar = Random.Range(0, 7);
            Text[] blinkChars = new Text[numberChar];

            for (int i = 0; i < numberChar; i++)
            {
                blinkChars[i] = chars[Random.Range(0, chars.Length)];
            }  
            
            yield return new WaitForSeconds(2f);

            for (int i = 0; i < Random.Range(20, 41); i++)
            {
                tempValue = (byte)Random.Range(0, 100);

                foreach (var text in blinkChars)
                {
                    text.color = new Color32(tempValue, tempValue, tempValue, 255);
                }

                yield return new WaitForSeconds(0.05f);
            }

            foreach (var text in blinkChars)
            {
                text.color = startColor;
            }
        }
    }
}
