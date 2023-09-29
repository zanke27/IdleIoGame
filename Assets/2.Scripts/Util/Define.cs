using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{
    private static Unit player = null;

    public static Unit Player
    { 
        get
        {
            if (player == null)
                player = GameObject.Find("Player").GetComponent<Unit>();
            return player;
        }
    }
}
