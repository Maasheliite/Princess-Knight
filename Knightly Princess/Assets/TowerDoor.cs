using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDoor : MonoBehaviour
{
    
    public void WizzardTowerDoor()
    {
        if (ItemStatic.ring)
        {
            FindObjectOfType<LevelLoader>().LoadWizzard();
        }
    }
}
