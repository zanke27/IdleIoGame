using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsRoamingEndDecision : FSMDecision
{
    public override bool MakeADecision()
    {
        float distance = Vector2.Distance(enemyFSM.roamingPoint.worldRoamingPos, transform.position);

        if (distance < 0.1f)
        {
            fsmMoveData.roamingPointArrived = true;
            fsmMoveData.isLeftRoamingPoint = !fsmMoveData.isLeftRoamingPoint;
            return true;
        }

        return false;
    }
}
