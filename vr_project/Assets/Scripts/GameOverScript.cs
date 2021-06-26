using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
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
