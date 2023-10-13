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

            // 실질적으로 플레이어가 공격 받는 코드

            AttackFeedback?.Invoke();
            StartCoroutine(WaitBeforeNextAttackCor());
        }
    }   
}
