using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Fw_Item : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public Sprite itemImage;

        /*public bool Use()
        {
            bool isUsed = false;
            isUsed = true;

            return false;
        }*/
    }
}
