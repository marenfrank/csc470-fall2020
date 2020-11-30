using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    public int maxHealth = 100;
    public int currentHealth;
    public Image fill;


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;


    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }





}