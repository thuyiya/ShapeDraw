using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public GameObject linePrefab;

    Line activeLine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click 1");
            GameObject newLine = Instantiate(linePrefab);
            activeLine = newLine.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Click 2");
            activeLine = null;
        }

        if(activeLine != null)
        {
            Debug.Log("Click 3");
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }
}
