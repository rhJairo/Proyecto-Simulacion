using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject Win_Panel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Win_Panel.gameObject.SetActive(true);
            float targetTime = 5.0f;
            void Update()
            {
                targetTime -= Time.deltaTime;
                if (targetTime < 0.0f)
                {
                    SceneManager.LoadScene("MainMenu");
                }
            }   
        }
    }
}
