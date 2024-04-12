using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    public Animator aiAnim;
    Vector3 dest;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
        if (ai.remainingDistance <= ai.stoppingDistance)
        {
            aiAnim.ResetTrigger("wave");
            aiAnim.ResetTrigger("jog");
            aiAnim.SetTrigger("idle");
        }
        else
        {
            aiAnim.ResetTrigger("wave");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("jog");
        }
    }
}
