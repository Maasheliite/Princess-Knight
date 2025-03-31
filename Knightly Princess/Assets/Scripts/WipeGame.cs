using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WipeGame : MonoBehaviour
{
    public void WipeGameData()
    {
        SavedPositionManager.savedPositions = new Dictionary<int, Vector3>();

        ItemStatic.berries = false;
        ItemStatic.emptyBucket = false;
        ItemStatic.enterTime = 0;
        ItemStatic.filledBucket = false;
        ItemStatic.hasCut = false;
        ItemStatic.hasMoved = false;
        ItemStatic.HasWatered = false;
        ItemStatic.health = 100;
        ItemStatic.helmet = false;
        ItemStatic.isInRange = false;
        ItemStatic.magicSword = false;
        ItemStatic.ring = false;
        ItemStatic.shears = false;
        ItemStatic.sword = false;


        QuestTraccker.BerryQuest = 0;
        QuestTraccker.DemonQuest = 0;
        QuestTraccker.FarmerQuest = 0;
        QuestTraccker.WizardQuest = 0;
    }
}

