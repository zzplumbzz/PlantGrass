using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    private GameObject player;

    public void SetMaxHealth(float health)
    {
        player = GameObject.Find("Square");
        slider.maxValue = player.GetComponent<PlayerStats>().playerMaxHealth;
        slider.value = player.GetComponent<PlayerStats>().playerHealth;
    }

    public void SetHealth(float health)
    {
        slider.value = player.GetComponent<PlayerStats>().playerHealth;
    }
}
