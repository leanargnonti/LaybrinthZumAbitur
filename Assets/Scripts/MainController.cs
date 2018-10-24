using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("e"))
        {
            door1.GetComponent<GlideController>().SetDestination(new Vector3(door1.transform.position.x, door1.transform.position.y - 2f, door1.transform.position.z));
        }
        if (Input.GetKeyDown("r"))
        {
            door1.GetComponent<GlideController>().SetDestination(new Vector3(door1.transform.position.x, door1.transform.position.y + 2f, door1.transform.position.z));
        }
    }
}
