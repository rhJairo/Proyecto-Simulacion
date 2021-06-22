using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100.0f;
    float dmgMod = 1.0f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerStay (Collider c)
    {
        if (c.gameObject.tag == "Rain" && playerHealth > 0)
        {
            playerHealth -= dmgMod * Time.deltaTime;
        }
        else if (c.gameObject.tag == "SafeZone" && playerHealth < 100.0f)
        {
            playerHealth += dmgMod * Time.deltaTime;
        }
        else
        {
            playerHealth = 100.0f;
        }
    }
}
