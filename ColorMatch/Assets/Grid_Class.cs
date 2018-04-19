using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Class : MonoBehaviour
{

    public GameObject tile;
    public GameObject[,] grid;

    public int gridSizeX;
    public int gridSizeY;

    private void Awake()
    {
        Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane)));
    }

    public void GenerateGrid(int x, int y)
    {
        grid = new GameObject[gridSizeX, gridSizeY];

        GameObject gridContainer = new GameObject();
        gridContainer.name = ("GridContainer");
        
        for (int _x = 0; _x < x; _x++)
        {
            for (int _y = 0; _y < y; _y++)
            {
                GameObject tempTile = Instantiate(tile, new Vector3(_x, _y, 0), Quaternion.identity);
                tempTile.name = ("Tile (" + _x.ToString() + "," + _y.ToString() + ")");
                tempTile.transform.SetParent(gridContainer.transform);
                grid[_x, _y] = tempTile;
                Tile_Class tempTileClass = tempTile.GetComponent<Tile_Class>();
                tempTileClass.SetColor(tempTileClass.RandomColor());
            }
        }

        gridContainer.transform.position = new Vector3(-4, -4.5f, 0);
    }
}
