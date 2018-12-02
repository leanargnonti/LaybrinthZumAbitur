using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasController : MonoBehaviour {


    public GameObject star_image;
    public GameObject star_object;
    public Text clocktext;

    private bool timerRunning = false;
    private int elapsedSeconds = 0;


    // Use this for initialization
    void Start () {
        InvokeRepeating("UpdateTimerGUI",1,1);
        timerRunning = true;
        star_image.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void showStar()
    {
        star_image.SetActive(true);
    }

    public void startTimer()
    {
        timerRunning = true;
    }

    public void stopTimer()
    {
        timerRunning = false;
    }

    //Wird alle 1 Sekunde aufgerufen
    private void UpdateTimerGUI()
    {
        if (timerRunning)
        {
            elapsedSeconds++;
            clocktext.text = "Zeit: " + getTime();
        }
    }

    public string getTime()
    {
        return "" + ((elapsedSeconds / 60 < 10) ? ("0" + elapsedSeconds / 60) : ("" + elapsedSeconds / 60))  + ":" + ((elapsedSeconds % 60 < 10) ? ("0" + elapsedSeconds % 60) : "" + (elapsedSeconds % 60));
    }
}