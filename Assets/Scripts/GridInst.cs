using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridInst : MonoBehaviour
{
    [SerializeField] GameObject gridPrefab;
    [SerializeField] float number;

    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            for (int y = 0; y < number; y++)
            {
                GameObject grid = Instantiate(gridPrefab) as GameObject;
                grid.transform.position = new Vector3(i, y, 0f);
            }
        }
    }
}
