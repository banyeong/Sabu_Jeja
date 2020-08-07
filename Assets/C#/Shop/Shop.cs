using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public ItemDataBase itemDataBase;
    public Transform slotRoot;

    private List<Slot> slots;

    public System.Action<ItemProperty> onSlotClick;

    // Start is called before the first frame update
    void Start()
    {
        slots = new List<Slot>();

        int slotCnt = slotRoot.childCount;

        for (int i = 0; i < slotCnt; i++)
        {
            var slot = slotRoot.GetChild(i).GetComponent<Slot>();

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

    public void OnClickSlot(Slot slot)
    {
        if(onSlotClick != null)
        {
            onSlotClick(slot.item);
        }
    }
}
