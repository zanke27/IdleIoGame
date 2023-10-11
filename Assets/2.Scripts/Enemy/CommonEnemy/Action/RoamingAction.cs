using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamingAction : FSMAction
{
    [SerializeField] private RoamingPoint roamingPoint1;
    [SerializeField] private RoamingPoint roamingPoint2;

    public override void TakeAction()
    {
        Vector2 direction;
        if (fsmMoveData.isLeftRoamingPoint == true)
        {
            direction = roamingPoint2.transform.position - transform.position;
            enemyFSM.roamingPoint = roamingPoint2;
        }
        else
        {
            direction = roamingPoint1.transform.position - transform.position;
            enemyFSM.roamingPoint = roamingPoint1;
        }

        fsmMoveData.direction = direction.normalized;
        enemyFSM.Move(fsmMoveData.direction);
    }
}
