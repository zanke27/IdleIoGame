using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{


    public override void GetDamage(int damage)
    {
        // �߰����� ����� �ʿ��� �� ���Ƽ� ��ӹ޾Ƴ���
        hp -= damage;
    }
}
