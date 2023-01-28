using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{

    public Slider visualHealth;

    public void SetMaxHealth(int max)
    {
        visualHealth.maxValue = max;
    }


    public void SetHealth(int health)
    {
        visualHealth.value = health;
    }
}
