using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMoveAnim(float value)
    {
        animator.SetFloat("Speed", value);
    }

    public void SetAttackAnim()
    {
        Debug.Log("Attack");
        animator.SetTrigger("Skill");
    }
}
