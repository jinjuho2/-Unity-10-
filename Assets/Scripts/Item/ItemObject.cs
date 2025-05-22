using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour , IInteractable
{
    public ItemData itemData;
    private Player player;
    public string GetInteractPrompt()
    {
        string str = $"{itemData.displayName} \n {itemData.description}";
        return str;
    }

    public void OnInteract(Player player)
    {
        player.itemData = itemData;
        player.addItem?.Invoke();
        Destroy(gameObject);

    }
}
