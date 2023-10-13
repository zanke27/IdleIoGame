using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class EnemyAttack : MonoBehaviour
{
    protected EnemyFSM enemyFSM;
    protected Enemy enemy;

    [SerializeField] private float attackDelay = 1f;

    protected bool waitBeforeNextAttack;

    public UnityEvent AttackFeedback;

    protected virtual void Awake()
    {
        enemy = GetComponent<Enemy>();
        enemyFSM = GetComponent<EnemyFSM>();
    }

    protected IEnumerator WaitBeforeNextAttackCor()
    {
        waitBeforeNextAttack = true;
        yield return new WaitForSeconds(attackDelay);
        waitBeforeNextAttack = false;
    }

    public virtual void Reset()
    {
        StartCoroutine(WaitBeforeNextAttackCor());
    }

    public abstract void Attack();
}
