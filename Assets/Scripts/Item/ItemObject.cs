using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour , IInteractable
{
    public ItemData itemData;

    public string GetInteracePrompt()
    {
        string str = $"{itemData.displayName} \n {itemData.description}";
        return str;
    }

    public void OnInteract()
    {
        //
    }
}
