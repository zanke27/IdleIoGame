using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAction : FSMAction
{
    public override void TakeAction()
    {
        Vector2 direction = enemyFSM.targetUnit.transform.position - transform.position;

        fsmMoveData.direction = direction.normalized;
        enemyFSM.Move(fsmMoveData.direction);
    }
}
