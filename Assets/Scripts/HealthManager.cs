using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private Text healthText;

    private int maxHealth = 100;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
        UpdateHealthValue();
    }

    private void UpdateHealthValue()
    {
        healthText.text = currentHealth.ToString();
    }
}
