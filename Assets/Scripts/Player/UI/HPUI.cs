using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUI : Condition
{
    public Image uiBar;

   
    protected void Update()
    {
        uiBar.fillAmount = GetPercentage();
        if(playerStat.currentHealth >= 0 )
        playerStat.currentHealth -= 1 * Time.deltaTime;
    }

    protected override void Add(float amount)
    {
        playerStat.currentHealth  = Mathf.Min(playerStat.currentHealth + amount, playerStat.maxHealth);
    }

    protected override void Subtract(float amount)
    {
        playerStat.currentHealth = Mathf.Max(playerStat.currentHealth - amount, 0);
    }

    protected override float GetPercentage()
    {
        return playerStat.currentHealth / playerStat.maxHealth;
    }
}
