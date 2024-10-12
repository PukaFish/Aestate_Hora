using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PointsManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textScore;
    [SerializeField]
    private TMP_Text HitextScore;
    public int _pointObjects = 0;
    public int _currentHighScore = 0;

    [SerializeField]
    private TMP_Text textTimer;
    private float timeLeft = 30;
    public bool timerOn = false;

    public GameObject GlobalDataManagerGO;
    public GlobalDataManager manager;

    //public GameObject bottlesPrefab, _launchPosition;

    private void Start()
    {
        GlobalDataManagerGO = GameObject.FindWithTag("GDM");
        manager = GlobalDataManagerGO.GetComponent<GlobalDataManager>();
    }

    private void Update()
    {
        if (timerOn)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timerOn = false;
            }
        }

        textTimer.text = "Time Left: "  + (int) timeLeft;
        textScore.text = "Score: " + _pointObjects;
        HitextScore.text = "High Score: " + _currentHighScore;
    }

    public void increaseCounter()
    {
        _pointObjects++;
        highScoreStore();
    }

    public void highScoreStore()
    {
        if(_pointObjects > _currentHighScore)
        {
            manager.highestScore = _pointObjects;
             _currentHighScore = _pointObjects;
        }
        else
        {
            manager.highestScore = _currentHighScore;
        }
    }

    public void startTimer()
    {
        timerOn = true;
        timeLeft = 30;
        _pointObjects = 0;
        //GameObject game = Instantiate(bottlesPrefab) as GameObject;
    }
}
