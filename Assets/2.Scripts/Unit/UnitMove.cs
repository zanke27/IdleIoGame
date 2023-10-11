using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnitMove : MonoBehaviour
{
    private Vector2 moveDir = Vector2.zero;
    public Vector2 MoveDir { get { return moveDir; } }
    
    private Rigidbody2D rb2D;
    [SerializeField] private float speed = 5;

    public UnityEvent<float> OnVelocityChange;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void SetMoveDir(Vector2 moveDir)
    {
        this.moveDir = moveDir;
    }

    private void FixedUpdate()
    {
        OnVelocityChange?.Invoke(rb2D.velocity.magnitude);

        rb2D.velocity = moveDir * speed;
    }
}
