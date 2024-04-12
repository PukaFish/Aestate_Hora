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

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Enemy"){
            //collision.gameObject.GetComponent<EnemyStats>().TakeDamage(1);

            GameObject sb = Instantiate(stickyBullet) as GameObject;
            ContactPoint contact = collision.contacts[0];
            sb.transform.position = contact.point;
            sb.transform.parent = collision.gameObject.transform;

            Destroy(gameObject);
        }
    }
}
