using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject titlePrefab;
    private BackgroundTile[,] allTiles;

    
    void Start()
    {
        allTiles = new BackgroundTile[width, height];
        SetUp();
    }

    void SetUp()
    {
        for (int i = 0; i < width; i ++) //creates the variable, requariement, increases the variable.
        {
            for (int j = 0; j < height; j ++)
            {
                Vector2 tempPosition = new Vector2(i, j);
                GameObject backgroundTile = Instantiate(titlePrefab, tempPosition, Quaternion.identity) as GameObject;
                backgroundTile.transform.parent = this.transform;
                backgroundTile.name = "(" + i + "," + j + ")";
            }
        }
    }
}
