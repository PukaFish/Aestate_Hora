using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private bool canAdd = true;

    public PointsManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Points")
        {
            destroyedObject();
        }
    }

    private void destroyedObject()
    {
        if (canAdd)
        {
            manager.increaseCounter();
            canAdd = false;

        }
        if (!canAdd)
        {
            Destroy(gameObject);
        }
    }
}
