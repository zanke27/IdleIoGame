using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestAction : FSMAction
{
    public override void TakeAction()
    {
        fsmMoveData.direction = Vector2.zero;
        enemyFSM.Move(fsmMoveData.direction);
    }
}
