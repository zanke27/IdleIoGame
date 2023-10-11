using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMState : MonoBehaviour
{
    private EnemyFSM enemyFSM = null;
    private List<FSMAction> actions = new List<FSMAction>();
    private List<FSMTransition> transitions = new List<FSMTransition>();

    private void Awake()
    {
        enemyFSM = GetComponentInParent<EnemyFSM>();

        GetComponents<FSMAction>(actions);
        GetComponentsInChildren<FSMTransition>(transitions);
    }

    public void UpdateState()
    {
        foreach(FSMAction action in actions)
        {
            action.TakeAction();
        }

        foreach(FSMTransition transition in transitions)
        {
            bool result = false;
            foreach(FSMDecision decision in transition.decisions)
            {
                result = decision.MakeADecision();
                if (result == false) break;
            }

            if (result)
            {
                if (transition.positiveState != null)
                {
                    enemyFSM.ChangeState(transition.positiveState);
                    return;
                }
            }
            else
            {
                if (transition.negativeState != null)
                {
                    enemyFSM.ChangeState(transition.negativeState);
                    return;
                }
            }
        }


    }
}
