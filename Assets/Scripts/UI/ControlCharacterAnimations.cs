using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacterAnimations : MonoBehaviour
{
    public Animator animator;

    //Connect to animator
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }

    //Animation changes for 
    public void ShockEmote()
    {
        animator.SetBool("Shock", true);
        animator.SetBool("Normal", false);
        animator.SetBool("Happy", false);
    }

    public void HappyEmote()
    {
        animator.SetBool("Shock", false);
        animator.SetBool("Normal", false);
        animator.SetBool("Happy", true);
    }

    public void NormalEmote()
    {
        animator.SetBool("Shock", false);
        animator.SetBool("Normal", true);
        animator.SetBool("Happy", false);
    }
}
