using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{

    public PlayerStat playerStat;


    protected virtual void Add(float amount)
    {

    }

    protected virtual void Subtract(float amount)
    {

    }

    protected virtual float GetPercentage()
    {
        return 0;
    }



}
