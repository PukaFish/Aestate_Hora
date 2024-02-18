using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    //Code from: Brackeys
    public string name;
    [TextArea(3,5)]
    public string[] sentences;

    public Dialogue(string title, string[] words)
    {
        name = title;
        sentences = words;
    }
}
