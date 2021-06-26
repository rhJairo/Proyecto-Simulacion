using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public float targetTime = 5.0f;
        GameObject go_FPCamera = GameObject.Find("FPCamera");
        PlayerScript playerScript = thePlayer.GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.playerHealth == 0)
        {

            gameObject.SetActive(true);
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
