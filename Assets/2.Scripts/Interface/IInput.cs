using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IUnitInput
{
    public UnityEvent<Vector2> MoveInput { get; set; }
    public UnityEvent AttackInput { get; set; }
}
