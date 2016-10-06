using UnityEngine;
using System.Collections;

public class switchMode : MonoBehaviour {

    public GameObject boat;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey("1"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = false;
            boat.GetComponent<boat>().enabled = true;
            boatCamera.SetActive(true);

            player.SetActive(false);
        }

        if(Input.GetKey("2"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = true;
            boat.GetComponent<boat>().enabled = false;
            boatCamera.SetActive(false);

            player.SetActive(true);
            player.transform.position = playerStartPos.transform.position;
        }
	}
}
