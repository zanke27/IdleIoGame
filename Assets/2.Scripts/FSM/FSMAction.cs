using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSMAction : MonoBehaviour
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

    public abstract void TakeAction();
}
