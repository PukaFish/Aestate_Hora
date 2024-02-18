using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlink : MonoBehaviour
{
    public Color startColor = Color.cyan;
    public Color endColor = Color.clear;
    [Range(0, 10)]
    public float speed = 1;
    private Renderer ren;

    [SerializeField] private bool isTriggerActive = false;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggerActive)
        {
            ren.material.color = endColor;
        }
        else
        {
            ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));

        }
    }

    public void OnTriggerExit(Collider other)
    {
        isTriggerActive = false;
    }

    public void OnTriggerStay(Collider other)
    {
        isTriggerActive = true;
    }
}
