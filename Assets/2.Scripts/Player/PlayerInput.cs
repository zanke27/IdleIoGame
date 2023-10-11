using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour, IUnitInput
{
    [SerializeField] private Joystick playerJoystick;

    [field: SerializeField] public UnityEvent<Vector2> MoveInput { get; set; }
    [field: SerializeField] public UnityEvent AttackInput { get; set; }

    private void Update()
    {
        MoveEvent();
        AttackEvent();
    }

    private void MoveEvent()
    {
        MoveInput?.Invoke(playerJoystick.Direction.normalized);
    }

    public void AttackEvent()
    {
        if (Input.GetKeyDown(KeyCode.L))
            AttackInput?.Invoke();
    }
}
