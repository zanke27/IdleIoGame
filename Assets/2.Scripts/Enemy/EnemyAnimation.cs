using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : UnitAnimation
{
    protected EnemyFSM enemyFSM;

    protected override void Awake()
    {
        base.Awake();
        enemyFSM = GetComponent<EnemyFSM>();
    }

    public void SetAttackAnim()
    {
        animator.SetTrigger("Attack");
    }

}
