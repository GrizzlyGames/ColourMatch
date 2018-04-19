using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Class : MonoBehaviour {

    public static Game_Class instance;

    public GameObject primaryTile;
    public GameObject secondaryTile;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }  
}