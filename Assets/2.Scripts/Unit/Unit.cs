using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private UnitMove unitMove;
    private UnitAnimation unitAnimation;

    #region 기본 스텟 데이터

    [SerializeField] private int hp = 100;
    public int HP { get { return hp; } }

    [SerializeField] private int damage = 10;
    public int Damage { get { return damage; } }

    #endregion

    private void Awake()
    {
        unitMove = GetComponent<UnitMove>();
        unitAnimation = GetComponentInChildren<UnitAnimation>();
    }

    public void GetDamage(int damage)
    {
        hp -= damage;
    }
}
