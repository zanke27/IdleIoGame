using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPlayerDecision : FSMDecision
{
    [SerializeField] private float chaseRange = 3f;

    public override bool MakeADecision()
    {
        float distance = Vector2.Distance(enemyFSM.targetUnit.transform.position, transform.position);

        if (distance < chaseRange)
            return true;

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
