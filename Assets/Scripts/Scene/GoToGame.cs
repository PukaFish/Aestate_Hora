using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void BusScene()
    {
        SceneManager.LoadScene("Tutorial_Bus");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void KitchenScene()
    {
        SceneManager.LoadScene("Kitchen");
    }
    public void HomeScene()
    {
        SceneManager.LoadScene("House");
    }
    public void RoomScene()
    {
        SceneManager.LoadScene("Room");
    }
}
