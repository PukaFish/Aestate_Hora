using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScreen : MonoBehaviour
{
    //Followed this tutorial: https://www.youtube.com/watch?v=JCyJ26cIM0Y

    public bool fadeOnStart = true;
    public bool fadeOutStart = false;
    public float fadeDuration = 10;
    public Color fadeColor;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (fadeOnStart)
        {
            FadeIn();
        }
        if (fadeOutStart)
        {
            FadeOut();
        }
    }
    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }

    public void FadeOutMimc()
    {
        Fade(0, 0);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;

        while(timer <= fadeDuration)
        {
            //Color Transition
            Color newColor = fadeColor;
            //alphaIn is 0 while alphaOut is 1
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer/fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        //Makes sure that it is transparent
        Color newColor2 = fadeColor;
        //alphaIn is 0 while alphaOut is 1
        newColor2.a = alphaOut;

        rend.material.SetColor("_Color", newColor2);
        Destroy(this.gameObject);
    }
}
