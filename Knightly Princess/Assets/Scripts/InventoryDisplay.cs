using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryDisplay : MonoBehaviour
{
    public GameObject InventoryTab;
    public GameObject Berries;
    public GameObject FilledBucket;
    public GameObject EmptyBucket;
    public GameObject Shears;
    public GameObject Ring;
    public GameObject Helmet;
    public GameObject Sword;
    public GameObject MagicSword;

    public GameObject QuestLog;
    public RectTransform textObject;
    public RectTransform TextParent;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            setEverythingActive();
        }



        if (Input.GetKeyUp(KeyCode.Space))
        {
            setEverythingClosed();
        }
    }

    private void setEverythingActive()
    {
        InventoryTab.SetActive(true);
        QuestLog.SetActive(true);
        GenerateQuestLog();

        if (ItemStatic.berries) Berries.SetActive(true);
        if (ItemStatic.filledBucket) FilledBucket.SetActive(true);
        if (ItemStatic.emptyBucket) EmptyBucket.SetActive(true);
        if (ItemStatic.shears) Shears.SetActive(true);
        if (ItemStatic.ring) Ring.SetActive(true);
        if (ItemStatic.helmet) Helmet.SetActive(true);
        if (ItemStatic.sword && ItemStatic.magicSword == false) Sword.SetActive(true);
        if (ItemStatic.magicSword) MagicSword.SetActive(true);


    }

    private void GenerateQuestLog()
    {
        GameObject w = Instantiate(textObject.gameObject, TextParent);
        w.GetComponent<TMP_Text>().text = "- The foolish knight went up north to the demon castle by himself. Get him out of there!";

        if (QuestTraccker.BerryQuest == 1)
        {
            GameObject e = Instantiate(textObject.gameObject, TextParent);
            e.GetComponent<TMP_Text>().text = "- Find some berries and deliver them to the stranger near the central statue!";
        }
        if (QuestTraccker.DemonQuest == 1)
        {
            GameObject r = Instantiate(textObject.gameObject, TextParent);
            r.GetComponent<TMP_Text>().text = "- The demon guard isn't letting you past. Maybe you could trick him?";
        }
        if (QuestTraccker.FarmerQuest == 1)
        {
            GameObject t = Instantiate(textObject.gameObject, TextParent);
            t.GetComponent<TMP_Text>().text = "- Bring the farmer's cow some water from the lake south of his house!";
        }
        if (QuestTraccker.WizardQuest == 1)
        {
            GameObject y = Instantiate(textObject.gameObject, TextParent);
            y.GetComponent<TMP_Text>().text = "- The wizard claims you need to see the invisible...";
        }
    }

    private void setEverythingClosed()
    {

        InventoryTab.SetActive(false);
        QuestLog.SetActive(false);


        Berries.SetActive(false);
        FilledBucket.SetActive(false);
        EmptyBucket.SetActive(false);
        Shears.SetActive(false);
        Ring.SetActive(false);
        Helmet.SetActive(false);
        Sword.SetActive(false);
        MagicSword.SetActive(false);
        for (int i = TextParent.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(TextParent.transform.GetChild(i).gameObject);
        }
    }
}
