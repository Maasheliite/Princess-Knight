using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    public GameObject swordPic;
    public GameObject swordpic2;

    public void SwordPickup()
    {
        swordPic.SetActive(true);
    }

    public void Sworduppers()
    {
        swordPic.SetActive(false);
        swordpic2.SetActive(true);
        FindObjectOfType<PlayerMovement>().BigBattle();
    }
}
