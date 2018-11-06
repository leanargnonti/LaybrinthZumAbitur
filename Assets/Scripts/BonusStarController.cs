using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusStarController : MonoBehaviour {

    // Use this for initialization
    private bool isCollected = false;
    public GameObject mainCanvas;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!isCollected)
        {
            this.gameObject.SetActive(false);
            isCollected = true;
            mainCanvas.GetComponent<MainCanvasController>().showStar();
        }
    }

    public bool checkCollected() { return isCollected; }

}
