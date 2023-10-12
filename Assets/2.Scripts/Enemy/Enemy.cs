using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    // 스텟 데이터를 SO로 받아오자

    protected bool isDead = false;
    protected EnemyAnimation enemyAnimation;
    protected EnemyAttack enemyAttack;
    protected CapsuleCollider2D capsuleCol;

    protected EnemyFSM enemyFSM;

    #region 인터페이스로 빼놓을까?
    [SerializeField] protected int maxHp = 100;
    protected int hp = 100;
    public int Hp => hp;

    public UnityEvent Die;
    public UnityEvent Hit;
    #endregion

    [SerializeField] protected bool isActive = false;

    protected virtual void Awake()
    {
        enemyAnimation = transform.Find("Visual").GetComponent<EnemyAnimation>();
        enemyAttack = GetComponent<EnemyAttack>();
        capsuleCol = GetComponent<CapsuleCollider2D>();
    }

    protected virtual void Start()
    {
        hp = maxHp;
    }

    public virtual void PerformAttack()
    {
        if (isDead == false && isActive == true)
        {
            enemyAttack.Attack();
        }
    }

    public virtual void Reset()
    {
        hp = maxHp;
        capsuleCol.enabled = false;
        isDead = true;
        isActive = false;
        enemyAttack.Reset();

        // 아직 덜 만듬
    }



}
