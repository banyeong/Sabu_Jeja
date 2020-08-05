using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower_Shop : MonoBehaviour
{
    public ItemDataBase itemDataBase;
    public Transform slotRoot;

    private List<Flower_Slot> slots;

    public System.Action<ItemProperty> onSlotClick;

    // Start is called before the first frame update
    void Start()
    {
        slots = new List<Flower_Slot>();

        int slotCnt = slotRoot.childCount;

        for (int i = 0; i < slotCnt; i++)
        {
            var slot = slotRoot.GetChild(i).GetComponent<Flower_Slot>();

            if (i < itemDataBase.items.Count)
            {
                slot.SetItem(itemDataBase.items[i]);
            }
            else
            {
                //아이템이 없는 슬롯
                slot.GetComponent<Button>().interactable = false;
            }

            slots.Add(slot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSlot(Flower_Slot slot)
    {
        if(onSlotClick != null)
        {
            onSlotClick(slot.item);
        }
    }
}
