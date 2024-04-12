using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen1;
    public GameObject screen;

    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen1.FadeOutMimc();
        yield return new WaitForSeconds(fadeScreen1.fadeDuration-1);

        //Launch the new scene
        SceneManager.LoadScene(sceneIndex);
    }
}
