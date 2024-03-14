using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DiaTrigger : MonoBehaviour
{
    [SerializeField] private List<dialogueString> dialogueStrings = new List<dialogueString>();
    [SerializeField] private Transform NPCTransform;

    //[SerializeField] private bool hasSpoken = false;

    public void TriggerDia()
    {
        FindObjectOfType<DiaMana>().DialogueStart(dialogueStrings, NPCTransform);
        gameObject.GetComponent<DiaMana>().DialogueStart(dialogueStrings, NPCTransform);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !hasSpoken)
        {
            other.gameObject.GetComponent<DiaMana>().DialogueStart(dialogueStrings, NPCTransform);
            hasSpoken = true;
        }
    }*/
}

[System.Serializable]
public class dialogueString
{
    public string name;
    public string text; //Text that NPC says
    public bool isEnd; //If line is the final line

    [Header("Branch")]
    public bool isQuestion;
    public string answerOption1;
    public string answerOption2;
    public string answerOption3;
    public int option1IndexJump;
    public int option2IndexJump;
    public int option3IndexJump;


    [Header("Triggered Events")]
    public UnityEvent startDialogueEvent;
    public UnityEvent endDialogueEvent;

}
