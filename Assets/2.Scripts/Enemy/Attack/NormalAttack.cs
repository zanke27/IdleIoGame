using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : EnemyAttack
{
    public override void Attack()
    {
        if (waitBeforeNextAttack == false)
        {
            enemyFSM.SetAttackState(true);

            // ���������� �÷��̾ ���� �޴� �ڵ�

            AttackFeedback?.Invoke();
            StartCoroutine(WaitBeforeNextAttackCor());
        }
    }   
}
