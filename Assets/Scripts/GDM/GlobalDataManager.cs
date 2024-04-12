using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalDataManager : MonoBehaviour
{
    //Init
    private static GlobalDataManager instance = null;
    public static GlobalDataManager Instance
    {
        get { return instance; }
    }

    [Header("General Information")]
    public int Day;
    public int highestScore;

    [Header("Day 0")]
    public bool askedForMoney = false; //Will mention the player got money in the epliogue.
    public bool askedAboutFantasia = false; //allows for rare Fantasia apperance.

    [Header("Day 1")]
    public bool firstConvo = false; //Allows for player to move on Day 2 of Conversations
    public bool askedForNoCalls = false; //Allows for players to stop recieving calls from mom. What a villian.
    [Header("Topics")]
    public bool aboutGames = false;
    public bool aboutBooks = false;
    [Header("Books")]
    public bool Elysium1 = false;
    public bool Fantasia1 = false;


    [Header("Day 2")]
    public bool secondConvo = false;
    [Header("Topics")]
    public bool aboutDreams = false;
    public bool aboutFamily = false;

    [Header("Day 3")]
    public bool thirdConvo = false;
    [Header("Topics")]
    public bool aboutSelf = false;
    public bool aboutWants = false;

    [Header("Day 4")]
    public bool fourthConvo = false;
    [Header("Topics")]

    [Header("Day 5")]
    public bool fifthConvo = false;
    [Header("Topics")]

    [Header("Day 6")]
    public bool sixthConvo = false;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
