using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyFSM : MonoBehaviour, IUnitInput
{
    // ������ ����, ���� Ÿ�ֵ̹��� ������ �̺�Ʈ��

    [field: SerializeField] public UnityEvent<Vector2> MoveInput { get; set; }
    [field: SerializeField] public UnityEvent AttackInput { get; set; }

    [SerializeField] protected FSMState currentState;

    public Unit targetUnit;
    public RoamingPoint roamingPoint;

    private FSMActionData fsmActionData;
    public FSMActionData FSMActionData => fsmActionData;

    private FSMMoveData fsmMoveData;
    public FSMMoveData FsmMoveData => fsmMoveData;

    protected virtual void Awake()
    {
        GameObject fsm = transform.Find("FSM").gameObject;
        fsmActionData = fsm.GetComponent<FSMActionData>();
        fsmMoveData = fsm.GetComponent<FSMMoveData>();
    }

    private void Start()
    {
        targetUnit = Define.Player;
    }

    public void SetAttackState(bool isAttack)
    {
        fsmActionData.attack = isAttack;
    }

    public void Attack()
    {
        AttackInput?.Invoke();
    }

    public void Move(Vector2 moveDirection)
    {
        MoveInput?.Invoke(moveDirection);
        // ���� ��ġ�� ������ �̺�Ʈ�� �ʿ��ϸ� �߰�
    }

    public void ChangeState(FSMState state)
    {
        currentState = state;
    }

    protected virtual void Update()
    {
        currentState.UpdateState();
    }
}
