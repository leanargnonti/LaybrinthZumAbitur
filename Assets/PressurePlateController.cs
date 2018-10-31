using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateController : MonoBehaviour
{

    // Use this for initialization
    private bool isDoorUp = false;
    public GameObject door;
    public GameObject questionCanvas;
    public string question = "";
    public List<string> solutions;

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
            solutions.Add("cheat");
            questionCanvas.GetComponent<QuestionCanvasController>().makeVisible(this.gameObject, question, solutions);
        }
    }

     public void recieveSolution(bool result)
    {
        if (!isDoorUp)
        {
            Debug.Log("entered");
            door.GetComponent<GlideController>().SetDestination(new Vector3(door.transform.position.x, door.transform.position.y - 5f, door.transform.position.z));
            isDoorUp = true;
        }
    }
}