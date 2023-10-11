using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCheckDecision : FSMDecision
{
    private float nowTime = 0f;
    [SerializeField] private float restTime = 3f;
    private bool timeCheckEnd = false;

    public override bool MakeADecision()
    {
        if (timeCheckEnd == true)
        {
            nowTime = 0f;
            timeCheckEnd = false;
            fsmMoveData.roamingPointArrived = false;
            return true;
        }
        return false;
    }

    private void Update()
    {
        if (fsmMoveData.roamingPointArrived == false) return;

        nowTime += Time.deltaTime;
        if (nowTime > restTime)
            timeCheckEnd = true;
        
    }
}
