using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poppy_Emotions : MonoBehaviour
{
    public Animator animator;

    //Connect to animator
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }

    public void waveTrigger()
    {
        animator.ResetTrigger("jog");
        animator.ResetTrigger("idle");
        animator.SetTrigger("wave");
    }
    public void idleTrigger()
    {
        animator.ResetTrigger("jog");
        animator.ResetTrigger("wave");
        animator.SetTrigger("idle");
    }
}
