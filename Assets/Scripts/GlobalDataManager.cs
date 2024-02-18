using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalDataManager : MonoBehaviour
{
    public int Day;

    public int RoomCounter;
    public bool ConversationOne;
    public bool ConversationTwo;
    public bool ConversationThree;
    public bool ConversationFour;
    public bool ConversationFive;
    public bool ConversationSix;


    public int ActivitiesCounter;
    public int highScore;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
