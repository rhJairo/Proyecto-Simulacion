using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class GazeController : MonoBehaviour
{

    public Image loadingImg;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            loadingImg.fillAmount = gvrTimer / totalTime;
        }

        float rounded = (float)Math.Floor(gvrTimer);

        print(rounded);
        if (rounded == totalTime)
        {
            GVRClick.Invoke();
            GVROff();
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        loadingImg.fillAmount = 0;
    }
}
