using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMoveAnim(float value)
    {
        animator.SetFloat("Speed", value);
    }

    public void SetPlayerSkillAnim()
    {
        animator.SetTrigger("Skill");
    }
}
