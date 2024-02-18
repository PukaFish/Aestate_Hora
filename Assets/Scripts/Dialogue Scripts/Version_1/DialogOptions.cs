using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogOptions : MonoBehaviour
{
    [SerializeField] private GameObject ButtonManager;
    [SerializeField] private GameObject IntroductoryOptions;
    [SerializeField] private GameObject Topic1Options;
    [SerializeField] private GameObject Topic2Options;
    [SerializeField] private GameObject Topic3Options;

    public void IntroOptions()
    {
        if(IntroductoryOptions.activeSelf != true)
        {
            IntroductoryOptions.gameObject.SetActive(true);
            Topic1Options.gameObject.SetActive(false);
            Topic2Options.gameObject.SetActive(false);
            Topic3Options.gameObject.SetActive(false);
        }
        else
        {
            IntroductoryOptions.gameObject.SetActive(false);
            Topic1Options.gameObject.SetActive(false);
            Topic2Options.gameObject.SetActive(false);
            Topic3Options.gameObject.SetActive(false);
        }

    }
}
