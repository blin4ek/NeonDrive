using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField] private GameObject linePrefab;
    private GameObject curretnLine;

    private LineRenderer line;
    private EdgeCollider2D lineCollider;

    private List<Vector2> fingerPosition = new List<Vector2>();

    private Camera mainCamera;

    private void Start()
    {
        GameOverEvent.RegHandler(Disactive);
        mainCamera = Camera.main;
    }

    private void Disactive()
    {
        gameObject.SetActive(false);
    }

    private void CreateLine()
    {
        curretnLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        line = curretnLine.GetComponent<LineRenderer>();
        lineCollider = curretnLine.GetComponent<EdgeCollider2D>();
        fingerPosition.Clear();
        fingerPosition.Add(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        fingerPosition.Add(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        line.SetPosition(0, fingerPosition[0]);
        line.SetPosition(1, fingerPosition[1]);
        lineCollider.points = fingerPosition.ToArray();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) CreateLine();

        if (Input.GetMouseButton(0))
        {
            Vector2 tempPoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempPoint, fingerPosition[fingerPosition.Count-1]) > 0.1f) UpdateLine(tempPoint);
        }
    }

    private void UpdateLine(Vector2 newPoint)
    {
        fingerPosition.Add(newPoint);
        line.positionCount++;
        line.SetPosition(line.positionCount-1, newPoint);
        lineCollider.points = fingerPosition.ToArray();
    }
}
