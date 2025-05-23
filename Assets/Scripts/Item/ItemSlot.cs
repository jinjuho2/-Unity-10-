using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Inventory inventory;
    public ItemData item;
    public int index;
    public Image icon;
    private Outline outline;

    public void Set(Player player)
    {
        item = player.itemData;   
        icon.sprite = item.icon;
    }

    public void Clear()
    {
        item = null;
        icon.sprite =null;
    }
}
