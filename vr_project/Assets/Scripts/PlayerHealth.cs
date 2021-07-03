using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100.0f;
    public float playerHealth;
    public float dmgMod = 1.0f;

    private Transform ui_healthBar;
    private GameObject rain;
    private GameObject[] rains;
    

    //experimental
    public static bool gameOver;
    public GameObject GameOverPanel;
    
    void Start()
    {
        playerHealth = maxHealth;
        ui_healthBar = GameObject.Find("HUD/Health/bar_health").transform;
        //UpdateHealthUI;
    }

    

    void Update()
    {
        
    }

    public void OnTriggerStay (Collider c)
    {
     
        if (c.gameObject.tag == "SafeZone" && playerHealth < 100.0f)
        {
            playerHealth += dmgMod * Time.deltaTime;
            UpdateHealthUI();
        }
        else
        {
            playerHealth -= dmgMod * Time.deltaTime;
            UpdateHealthUI();
        }
    }

    public void OnTriggerEnter(Collider c)
    {
        rains = GameObject.FindGameObjectsWithTag("Rain");

        if (c.gameObject.tag == "SafeZone")
        {
            foreach (GameObject rain in rains)
            {
                rain.GetComponent<Collider>().enabled = false;
            }
            
        }
        if (c.CompareTag("Puddle"))
        {


            StartCoroutine(tempPowerDown(c));
        }

    }
/*
    public void OnTriggerEnter1(Collider Puddle)
    {
        if (Puddle.CompareTag("Puddle"))
        {
            

            StartCoroutine(tempPowerDown(Puddle));
        }
    }*/

    IEnumerator tempPowerDown(Collider c)
    {
        foreach (GameObject rain in rains)
        {
            rain.GetComponent<Collider>().enabled = false;
        }
        playerHealth -= 20;
        yield return new WaitForSeconds(1);
        //dmgMod = 1.0f;
       
    }
  


    public void OnTriggerExit(Collider c)
    {
        rains = GameObject.FindGameObjectsWithTag("Rain");

        if (c.gameObject.tag == "SafeZone")
        {
            foreach (GameObject rain in rains)
            {
                rain.GetComponent<Collider>().enabled = true;
            }
        }
    }
        
        

    void UpdateHealthUI()
    {
        float health_ratio = playerHealth / maxHealth;
        ui_healthBar.localScale = new Vector3(health_ratio, 1, 1);
        if (health_ratio <= 0.0f)
        {
            //gameOver = True;
            GameOverPanel.SetActive(true);
        }
    }
}
