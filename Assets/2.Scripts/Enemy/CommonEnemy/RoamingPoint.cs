using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamingPoint : MonoBehaviour
{
    public Vector2 worldRoamingPos;

    private void Awake()
    {
        worldRoamingPos = transform.position;
    }
}
