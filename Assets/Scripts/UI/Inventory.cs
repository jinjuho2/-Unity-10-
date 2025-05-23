using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemSlot[] slots;

    public Transform slotPanel;

    private void Start()
    {
        slots = new ItemSlot[slotPanel.childCount];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlot>();
            slots[i].index = i;
            slots[i].inventory = this;
            slots[i].Clear();
        }
    }
    public void AddItem(Player player)
    {
        ItemData data = player.itemData;

        if (data.canStack)
        {
            ItemSlot slot = GetItemStack(data);
            if (slot != null)
            {
                UpdateUI(player);
                player.itemData = null;
                return;
            }
        }


        ItemSlot emptySlot = GetEmptySlot();

        if (emptySlot != null)
        {
            emptySlot.item = data;
            UpdateUI(player);
            player.itemData = null;
            return;
        }

        player.itemData = null;
    }

    public void UseItem(Player player)
    {

    }

    ItemSlot GetItemStack(ItemData data)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == data )
            {
                return slots[i];
            }
        }
        return null;
    }
    public void UpdateUI(Player player)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                slots[i].Set(player);
            }
            else
            {
                slots[i].Clear();
            }
        }
    }

    ItemSlot GetEmptySlot()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                return slots[i];
            }
        }
        return null;
    }
}
