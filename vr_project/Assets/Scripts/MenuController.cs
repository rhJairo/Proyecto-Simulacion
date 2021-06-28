using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panel_l;
    public GameObject panel_r;

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    public void OpenCredits()
    {
        if (panel_l != null)
        {
            bool isActive = panel_l.activeSelf;

            panel_l.SetActive(!isActive);
            panel_r.SetActive(!isActive);
        }
    }
}
