using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{


    public override void GetDamage(int damage)
    {
        // 추가적인 계산이 필요할 것 같아서 상속받아놨음
        hp -= damage;
    }
}
