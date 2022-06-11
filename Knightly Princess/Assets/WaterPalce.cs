using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPalce : MonoBehaviour
{
    public void FullBucket()
    {
        if (ItemStatic.filledBucket)
        {
            ItemStatic.filledBucket = false;
            ItemStatic.HasWatered = true;
        }
    }
}
