using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMTransition : MonoBehaviour
{
    public List<FSMDecision> decisions;

    public FSMState positiveState;
    public FSMState negativeState;
}
