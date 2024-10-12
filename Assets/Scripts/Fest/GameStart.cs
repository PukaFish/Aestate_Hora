using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public PointsManager manager;
    public GameObject scoreboard;
    public GameObject relatedObjects;

    public void startActivity()
    {
        manager.startTimer();
        scoreboard.SetActive(true);
        relatedObjects.SetActive(true);
    }

}
