using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogo : MonoBehaviour
{
    public GameObject logo;
    Vector2 point;

    void Update()
    {
        point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Spawn(point);
        }
    }

    void Spawn(Vector2 point)
    {
        Instantiate(logo).transform.position = point;
    }
}
