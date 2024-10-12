using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private GameObject stickyBullet;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }
}
