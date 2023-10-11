using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSMDecision : MonoBehaviour
{
    protected FSMActionData fsmActionData;
    protected FSMMoveData fsmMoveData;
    protected EnemyFSM enemyFSM;

    protected virtual void Awake()
    {
        fsmActionData = transform.GetComponentInParent<FSMActionData>();
        fsmMoveData = transform.GetComponentInParent<FSMMoveData>();
        enemyFSM = transform.GetComponentInParent<EnemyFSM>();
    }

    public abstract bool MakeADecision();
    // Transition을 발동시켜 State를 이동할 것인지 "결정"하는 IF문 같은 거
}
