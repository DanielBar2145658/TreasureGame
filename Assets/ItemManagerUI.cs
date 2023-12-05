using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagerUI : MonoBehaviour
{
    public GameObject[] Items;

    public void DisableItemUI(int i) 
    {
        Items[i].SetActive(false);
    }
    
}
