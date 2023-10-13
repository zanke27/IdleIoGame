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

        Debug.Log($"Direction: {fsmMoveData.direction}");
        // 공격 중에는 멈추고 싶음
        
        fsmMoveData.direction = Vector2.zero;
        enemyFSM.Move(fsmMoveData.direction);
    }
}
