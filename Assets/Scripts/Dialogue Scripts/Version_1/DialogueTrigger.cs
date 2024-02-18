using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DialogueTrigger : MonoBehaviour
{
    //Code from: Brackeys + Edits made by Ducc Lover

    public Dialogue dialogue;
    public GameObject instructions;

    private void Start()
    {
        instructions.SetActive(true);
    }

    public void TriggerDialouge()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        instructions.SetActive(false);
    }
}
