using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPlayerDistanceDecision : FSMDecision
{
    [SerializeField] private float chaseRange = 3f;

    [SerializeField] private bool inDistance = true; 

    public override bool MakeADecision()
    {
        float distance = Vector2.Distance(enemyFSM.targetUnit.transform.position, transform.position);

        if (inDistance) // ChaseRange 안에 있는지 체크
        {
            if (distance < chaseRange)
                return true;
        }
        else
        {
            if (distance > chaseRange)
                return true;
        }

        return false;
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (UnityEditor.Selection.activeGameObject == gameObject)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, chaseRange);
            Gizmos.color = Color.white;
        }
    }
#endif
}
