using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float maxHealth = 100f;
    public float currentHealth;

    public float maxHunger = 100f;
    public float currentHunger;

    public float maxStamina = 100f;
    public float currentStamina;

    private void Start()
    {
        currentHealth = maxHealth;
        currentHunger = maxHunger;
        currentStamina = maxStamina;
    }

}
