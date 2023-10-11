using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FaceDirection(Vector2 moveDir)
    {
        Vector3 result = Vector3.Cross(Vector2.up, moveDir);

        if (result.z > 0)
            spriteRenderer.flipX = true;
        else if (result.z < 0)
            spriteRenderer.flipX = false;
    }
}
