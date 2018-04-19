using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Constructor : MonoBehaviour {

    private Grid_Class game;

    private void Awake()
    {
        game = GetComponent<Grid_Class>();
    }

    void Start()
    {
        game.GenerateGrid(game.gridSizeX, game.gridSizeY);
    }
}
