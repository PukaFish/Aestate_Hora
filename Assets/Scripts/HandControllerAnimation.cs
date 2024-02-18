using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandControllerAnimation : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer mesh;
    [SerializeField] private InputActionProperty TriggerAction;
    [SerializeField] private InputActionProperty GripAction;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float triggerValue = TriggerAction.action.ReadValue<float>();
        float gripValue = GripAction.action.ReadValue<float>();

        anim.SetFloat("Trigger", triggerValue);
        anim.SetFloat("Grip", gripValue);
    }

    public void ToggleVisibility()
    {
        mesh.enabled = !mesh.enabled;
    }
}
