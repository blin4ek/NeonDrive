using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangerFont : MonoBehaviour
{
    [SerializeField] private Text[] chars;

    private int finalFontSize = 225;

    void Start()
    {
        StartCoroutine(ChangeSize());
    }

    IEnumerator ChangeSize()
    {
        int sizeFont = 1;

        while (chars[0].fontSize < finalFontSize)
        {
            sizeFont += 3;

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i].fontSize = sizeFont;  
            }
            yield return null;
        }
    }
}