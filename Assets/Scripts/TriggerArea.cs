using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerArea : XRBaseInteractor
{
    private XRBaseInteractable currentInteractable = null;

    private void OnTriggerEnter(Collider other)
    {
        SetInteractable(other);
    }

    private void SetInteractable(Collider other)
    {
        if(TryGetInteractable(other, out XRBaseInteractable interactable))
        {
            if(currentInteractable == null)
            {
                currentInteractable = interactable;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ClearInteractable(other);
    }

    private void ClearInteractable(Collider other)
    {
        if (TryGetInteractable(other, out XRBaseInteractable interactable))
        {
            if (currentInteractable == interactable)
            {
                currentInteractable = null;
            }
        }
    }

    [System.Obsolete]
    private bool TryGetInteractable(Collider collider, out XRBaseInteractable interactable)
    {
        interactable = interactionManager.TryGetInteractableForCollider(collider);
        return interactable != null;
    }

    [System.Obsolete]
    public override void GetValidTargets(List<XRBaseInteractable> targets)
    {
        targets.Clear();
        targets.Add(currentInteractable);

    }

    [System.Obsolete]
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && currentInteractable == interactable && !interactable.isSelected;
    }

    [System.Obsolete]
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return false;
    }
}
