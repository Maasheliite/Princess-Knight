using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFill : MonoBehaviour
{
    
    public void EmptyBucket()
    {
        if (ItemStatic.emptyBucket)
        {
            ItemStatic.emptyBucket = false;
            ItemStatic.filledBucket = true;
        }
    }
}
