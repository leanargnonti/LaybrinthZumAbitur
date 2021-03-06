﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateController : MonoBehaviour
{

    // Use this for initialization
    private bool isDoorUp = false;
    public GameObject door;
    private GameObject player;
    public Material inactiveMaterial;
    public GameObject questionCanvas;
    public string question = "";
    public List<string> answers;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isDoorUp)
        {
            player = other.gameObject;
            questionCanvas.GetComponent<QuestionCanvasController>().makeVisible(this.gameObject, question, answers);
            other.GetComponent<BasicBehaviour>().setPlayerEnabled(false);
        }
    }

     public void recieveSolution(bool result)
    {
        if (!isDoorUp && result)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material = inactiveMaterial;
            door.GetComponent<GlideController>().SetDestination(new Vector3(door.transform.position.x, door.transform.position.y - 5f, door.transform.position.z));
            isDoorUp = true;
            
        }
        player.GetComponent<BasicBehaviour>().setPlayerEnabled(true);
    }
}