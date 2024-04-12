using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.InputSystem;

public class DiaMana : MonoBehaviour
{
    //https://youtu.be/BEaOHWkZhtE?si=yY7xMUog76P7L3TB
    [SerializeField] private GameObject dialogueParent;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Button option1Button;
    [SerializeField] private Button option2Button;
    [SerializeField] private Button option3Button;

    [SerializeField] private Button[] talkButton;

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private float turnSpeed = 2f;

    private List<dialogueString> dialogueList;

    [Header("Player")]
    //Connect to player
    private Transform playerCamera;

    private int currentDialogueindex = 0;

    private void Start()
    {
        dialogueParent.SetActive(false);
        //playerCamera = Camera.main.transform;
    }

    public void DialogueStart(List<dialogueString> textToPrint, Transform NPC)
    {
        for (int i = 0; i < talkButton.Length; i++)
        {
            int buttonIndex = i; // Capturing the current value of i for each iteration
            talkButton[buttonIndex].gameObject.SetActive(false);
        }
        dialogueParent.SetActive(true);

        //StartCoroutine(TurnCameraTowardsNPC(NPC));
        dialogueList = textToPrint;
        currentDialogueindex = 0;

        DisableButtons();
        StartCoroutine(PrintDialogue());
    }

    private void DisableButtons()
    {
        option1Button.interactable = false;
        option2Button.interactable = false;
        option3Button.interactable = false;

        option1Button.GetComponentInChildren<TMP_Text>().text = "No Option";
        option2Button.GetComponentInChildren<TMP_Text>().text = "No Option";
        option3Button.GetComponentInChildren<TMP_Text>().text = "No Option";
    }

    private IEnumerator TurnCameraTowardsNPC(Transform NPC)
    {
        Quaternion startRotation = playerCamera.rotation;
        Quaternion targetRotation = Quaternion.LookRotation(NPC.position - playerCamera.position);

        float elapsedTime = 0f;
        while(elapsedTime < 1f)
        {
            playerCamera.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime);
            elapsedTime += Time.deltaTime * turnSpeed;
            yield return null;
        }

        playerCamera.rotation = targetRotation;
    }

    private bool optionSelected = false;

    private IEnumerator PrintDialogue()
    {
        while(currentDialogueindex < dialogueList.Count)
        {
            dialogueString line = dialogueList[currentDialogueindex];
            line.startDialogueEvent?.Invoke();
            nameText.text = line.name;

            if (line.isQuestion)
            {
                yield return StartCoroutine(TypeText(line.text));

                option1Button.interactable = true;
                option2Button.interactable = true;
                option3Button.interactable = true;

                option1Button.GetComponentInChildren<TMP_Text>().text = line.answerOption1;
                option2Button.GetComponentInChildren<TMP_Text>().text = line.answerOption2;
                option3Button.GetComponentInChildren<TMP_Text>().text = line.answerOption3;

                option1Button.onClick.AddListener(() => HandleOptionSelected(line.option1IndexJump));
                option2Button.onClick.AddListener(() => HandleOptionSelected(line.option2IndexJump));
                option3Button.onClick.AddListener(() => HandleOptionSelected(line.option3IndexJump));

                yield return new WaitUntil(() => optionSelected);
            }
            else
            {
                yield return StartCoroutine(TypeText(line.text));
            }

            line.endDialogueEvent?.Invoke();
            optionSelected = false;
        }

        DialogueStop();
    }

    private void HandleOptionSelected(int indexJump)
    {
        optionSelected = true;
        DisableButtons();

        currentDialogueindex = indexJump;
    }

    private IEnumerator TypeText(string text)
    {
        dialogueText.text = "";
        foreach(char letter in text.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        if (!dialogueList[currentDialogueindex].isQuestion)
        {
            yield return new WaitUntil(() => AnyVRButtonPressed());
        }

        if (dialogueList[currentDialogueindex].isEnd)
        {
            DialogueStop();
        }

        currentDialogueindex++;
    }

    private bool AnyVRButtonPressed()
    {
        // Check if right trigger button on the VR controller is currently pressed
        return Gamepad.current != null && Gamepad.current.rightTrigger.isPressed;
    }

    private void DialogueStop()
    {
        StopAllCoroutines();
        dialogueText.text = "";
        dialogueParent.SetActive(false);
        for (int i = 0; i < talkButton.Length; i++)
        {
            int buttonIndex = i; // Capturing the current value of i for each iteration
            talkButton[buttonIndex].gameObject.SetActive(true);
        }
    }

}
