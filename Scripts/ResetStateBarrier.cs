using UnityEngine;

public class ResetStateBarrier : MonoBehaviour
{
    [SerializeField] private GameObject col;
    
    private void OnEnable()
    {
        col.SetActive(true);
    }
}
