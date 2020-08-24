using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacters : MonoBehaviour
{
    public GameObject[] characters;
    Vector3 point;

    void Update()
    {
        RaycastHit raycast;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        if (Physics.Raycast(ray, out raycast))
        {
            point = raycast.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            SpawnCharacter(point);
        }
    }

    void SpawnCharacter(Vector3 point)
    {
        Instantiate(characters[Random.Range(0, characters.Length - 1)], point, Quaternion.Euler(0f, 180f, 0f));
    }
}
