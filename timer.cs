using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using System;

public class timer : MonoBehaviour
{
    float countdown = -38;

    public TMP_Text tex;

    public GameObject drill;

    public GameObject measureCloudTop;

    public GameObject measureCloudBottom;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void resetTimer()
    {
        countdown = -38;
    }

    // Update is called once per frame
    void Update()
    {

        countdown +=Time.deltaTime;
        tex.text = Math.Abs(countdown).ToString("00.0");

        // Display Drill No 1 on Screen between 1 and 10 sec
        if (countdown > 1 && countdown < 10 && drill.activeInHierarchy == false)
        {
            Debug.Log("Drill 1 executed");
            drill.SetActive(true);
        }
        else if( countdown >10 && drill.activeInHierarchy == true)
        {
            Debug.Log("Drill 1 stopped");
            drill.SetActive(false);
        }

        // Display Measure Cloud Top on Screen between 20 and 30 sec
        if (countdown > 20 && countdown < 30 && measureCloudTop.activeInHierarchy == false)
        {
            measureCloudTop.SetActive(true);
        }
        else if( countdown >30 && measureCloudTop.activeInHierarchy == true)
        {
            measureCloudTop.SetActive(false);
        }


        // Display Measure Cloud Bottom on Screen between 40 and 50 sec
        if (countdown > 40 && countdown < 50 && measureCloudBottom.activeInHierarchy == false)
        {
            measureCloudBottom.SetActive(true);
        }
        else if( countdown >50 && measureCloudBottom.activeInHierarchy == true)
        {
            measureCloudBottom.SetActive(false);
        }

    }
}
