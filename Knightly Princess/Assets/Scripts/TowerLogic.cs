using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLogic : MonoBehaviour
{
    public GameObject firstUp;
    public GameObject secondUp;
    public GameObject secondDown;
    public GameObject thirdDown;

    public GameObject player;

    public void GoUpTo2()
    {
        player.transform.position = secondDown.transform.position;
    }

    public void GoUpTo3()
    {
        player.transform.position = thirdDown.transform.position;
    }

    public void GoDownTo2()
    {
        player.transform.position = secondUp.transform.position;
    }

    public void GoDownTo1()
    {
        player.transform.position = firstUp.transform.position;
    }
    
}
