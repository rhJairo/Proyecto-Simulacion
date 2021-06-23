using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100.0f;
    public float playerHealth;
    public float dmgMod = 1.0f;

    private Transform ui_healthBar;

    void Start()
    {
        playerHealth = maxHealth;
        ui_healthBar = GameObject.Find("HUD/Health/bar_health").transform;

    }

    void Update()
    {
        
    }

    public void OnTriggerStay (Collider c)
    {
        if (c.gameObject.tag == "Rain" && playerHealth > 0)
        {
            playerHealth -= dmgMod * Time.deltaTime;
            UpdateHealthUI();
        }
        else if (c.gameObject.tag == "SafeZone" && playerHealth < 100.0f)
        {
            playerHealth += dmgMod * Time.deltaTime;
            UpdateHealthUI();
        }
        else
        {
            playerHealth = maxHealth;
        }
    }

    void UpdateHealthUI()
    {
        float health_ratio = playerHealth / maxHealth;
        ui_healthBar.localScale = new Vector3(health_ratio, 1, 1);
    }
}
