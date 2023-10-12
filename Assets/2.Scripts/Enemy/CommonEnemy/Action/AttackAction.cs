using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : FSMAction
{
    public override void TakeAction()
    {
        if (fsmActionData.attack == false)
        {
            enemyFSM.Attack();
        }

        fsmMoveData.direction = Vector2.zero;
        enemyFSM.Move(fsmMoveData.direction);
    }
}
