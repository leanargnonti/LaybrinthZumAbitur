using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalZoneController : MonoBehaviour {

    public GameObject youWinCanvas;
    public Text winText;
    public GameObject MainCanvas;

    // Use this for initialization
    void Start () {
        youWinCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        youWinCanvas.SetActive(true);
        MainCanvas.GetComponent<MainCanvasController>().stopTimer();
        winText.text = "Herzlichen Glückwunsch!\nDu hast dein Abitur in " 
            + MainCanvas.GetComponent<MainCanvasController>().getTime() + " Minuten\n\n" 
            + (MainCanvas.GetComponent<MainCanvasController>().star_image.activeSelf ? ("mit Auszeichnungen\n und einem Schnitt von 1,0\n") :"")  
            + " erhalten!!!";
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
