using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionData : MonoBehaviour
{
    //Global Data Manager
    public GameObject GlobalDataManagerGO;
    public GlobalDataManager manager;

    private void Awake()
    {
        GlobalDataManagerGO = GameObject.FindWithTag("GDM");
        manager = GlobalDataManagerGO.GetComponent<GlobalDataManager>();
    }

    //Day 0
    public void money()
    {
        manager.askedForMoney = true;
    }

    public void Fanny()
    {
        manager.askedAboutFantasia = true;
    }

    //Day 1
    public void noMoreCalls()
    {
        manager.askedForNoCalls = true;
    }
    //
    public void firstCovo()
    {
        manager.firstConvo = true;
    }

    //Library
    public void books()
    {
        manager.aboutBooks = true;
    }
    public void games()
    {
        manager.aboutGames = true;
    }
    public void Elly1()
    {
        manager.Elysium1 = true;
    }
    public void Fanny1()
    {
        manager.Fantasia1 = true;
    }
}
