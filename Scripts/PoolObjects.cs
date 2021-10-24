using UnityEngine;

public class PoolObjects : MonoBehaviour
{
    public GameObject[] items;
    [SerializeField] private GameObject item;
    [SerializeField] private int numberOfItem;

    private void Start()
    {
        items = new GameObject[numberOfItem];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = Instantiate(item);
            items[i].SetActive(false);
        }
    }

    public static void ReturnItem(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public static void TakeItem(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public GameObject GetFreeItem()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (!items[i].activeSelf) { return items[i]; }
        }
        return null;
    }
}
