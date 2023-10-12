using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAttackDecision : FSMDecision
{
    public override bool MakeADecision()
    {
        if (fsmActionData.attack)
            return false;

        return true;
    }
}
